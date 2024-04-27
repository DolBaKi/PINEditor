using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using KartRider.Common.Data;
using System.Net.NetworkInformation;

namespace PINEditor
{
    public partial class PINEditor : Form
    {
        public PINEditor()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.DefaultExt = "pin";
            openFileDlg.Filter = "PIN File(*.pin;)|*.pin";
            openFileDlg.ShowDialog();
            if (openFileDlg.FileName.Length > 0)
            {
                foreach (string filename in openFileDlg.FileNames)
                {
                    filedir = filename;
                }
            }
            PINFile pinFile = new PINFile(filedir);
            bObjects= new List<BmlObject>(pinFile.BmlObjects);
            Amethod = new List<PINFile.AuthMethod>(pinFile.AuthMethods);
            unk1Box.Text = Convert.ToString(pinFile.Header.Unk1);
            unk2Box.Text = Convert.ToString(pinFile.Header.Unk2);
            unk3Box.Text = Convert.ToString(pinFile.Header.Unk3);
            unk4Box.Text = Convert.ToString(pinFile.Header.Unk4);
            unk5Box.Text = Convert.ToString(pinFile.Header.Unk5);
            localeIDBox.Text = Convert.ToString(pinFile.Header.LocaleID);
            localeTypeBox.Text = Convert.ToString(pinFile.Header.LocaleType);
            minorVersionBox.Text = Convert.ToString(pinFile.Header.MinorVersion);
            loginTypeBox.Text = Convert.ToString(pinFile.Header.LoginType);
            aesKeyBox.Text = pinFile.Header.AESKey;
            urlBox.Text = pinFile.Header.URL;
            patchUrlBox.Text = pinFile.Header.PatchURL;
            BmlView(pinFile.BmlObjects);
            BmlTreeWrite(pinFile.BmlObjects);
            IP_Port_Write(pinFile);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PINFile pinFile = new PINFile(filedir);
            pinFile.Header.Unk1 = Convert.ToByte(unk1Box.Text);
            pinFile.Header.Unk2 = Convert.ToUInt16(unk2Box.Text);
            pinFile.Header.Unk3 = Convert.ToByte(unk3Box.Text);
            pinFile.Header.Unk4 = Convert.ToByte(unk4Box.Text);
            pinFile.Header.Unk5 = Convert.ToByte(unk5Box.Text);

            pinFile.Header.LocaleID = Convert.ToUInt16(localeIDBox.Text);
            pinFile.Header.LocaleType = Convert.ToByte(localeTypeBox.Text);

            pinFile.Header.MinorVersion = Convert.ToUInt16(minorVersionBox.Text);

            pinFile.Header.LoginType = Convert.ToByte(loginTypeBox.Text);

            pinFile.Header.AESKey = aesKeyBox.Text;

            pinFile.Header.URL = urlBox.Text;
            pinFile.Header.PatchURL = patchUrlBox.Text;
            pinFile.BmlObjects = bObjects;
            pinFile.AuthMethods = Amethod;
            /*foreach (PINFile.AuthMethod authMethod in pinFile.AuthMethods)
            {
                authMethod.LoginServers.Clear();
                authMethod.LoginServers.Add(new PINFile.IPEndPoint
                {
                    IP = ipv4Box.Text,
                    Port = Convert.ToUInt16(portBox.Text)
                });
            }*/
            File.WriteAllBytes(string.Concat(new string[]
                {
                    filedir
            }), pinFile.GetEncryptedData());
        }

        void Bmldeep(List<Tuple<string,BmlObject>> subObjects)
        {
            for (int j = 0; j < subObjects.Count; j++)
            {
                Console.WriteLine("SubObjects no : {0}, {1}", j + 1, subObjects[j].Item1);
                Console.WriteLine("Name : {0}", subObjects[j].Item2.Name);
                Console.WriteLine("Value : {0}", subObjects[j].Item2.Value);
                foreach (KeyValuePair<string, string> item in subObjects[j].Item2.Values)
                {
                    Console.WriteLine("[{0}:{1} {2}]", item.Key, item.Value, item.Value.GetType().Name);
                }
                Bmldeep(subObjects[j].Item2.SubObjects);
            }
        }

        public void BmlView(List<BmlObject> bmlObjects)
        {
            int cnt = 01;
            for (int i = 0; i < bmlObjects.Count; i++)
            {
                Console.WriteLine("BML no : {0}", i + 1);
                Console.WriteLine("Name : {0}", bmlObjects[i].Name);
                Console.WriteLine("Value : {0}", bmlObjects[i].Value);
                Bmldeep(bmlObjects[i].SubObjects);
            }
        }

        void treewritedeep(List<Tuple<string,BmlObject>> subObjects,TreeNode parentNode)
        {
            for (int j = 0; j < subObjects.Count; j++)
            {
                TreeNode node = new TreeNode(subObjects[j].Item2.Name);
                parentNode.Nodes.Add(node);
                treewritedeep(subObjects[j].Item2.SubObjects, node);
            }
        }

        public void BmlTreeWrite(List<BmlObject> bmlObjects)
        {
            treeView1.Nodes.Clear();
            for (int i = 0; i < bmlObjects.Count; i++)
            {
                TreeNode a = new TreeNode(bmlObjects[i].Name.ToString());
                treeView1.Nodes.Add(a);
                treewritedeep(bmlObjects[i].SubObjects, a);
            }
        }
        void TreeToList(TreeNode node)
        {
            listView1.Items.Add(new ListViewItem(new string[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }));
            foreach (TreeNode n in node.Nodes)
            {
                TreeToList(n);
            }
        }

        public string filedir;

        public string listdir;

        public List<BmlObject> bObjects;

        public List<PINFile.AuthMethod> Amethod;

        public string ss;

        public string listss;

        void nodeDeep(TreeNode parentNode, List<Tuple<string,BmlObject>> subObjects,string target)
        {
            for(int i=0;i<subObjects.Count;i++)
            {
                if (subObjects[i].Item2.Name == target)
                {
                    ss = target;
                    for(int j=0;j<subObjects[i].Item2.SubObjects.Count;j++)
                    {
                        ListViewItem.ListViewSubItem[] subItemss;
                        ListViewItem item;
                        item = new ListViewItem(subObjects[i].Item2.SubObjects[j].Item2.Name, 0);
                        subItemss = new ListViewItem.ListViewSubItem[]
                                  { new ListViewItem.ListViewSubItem(item, item.GetType().Name.ToString()),
                                new ListViewItem.ListViewSubItem(item, null)
                                  };

                        item.SubItems.AddRange(subItemss);
                        listView1.Items.Add(item);
                    }
                    foreach (KeyValuePair<string, string> item in subObjects[i].Item2.Values)
                    {
                        ListViewItem.ListViewSubItem[] subItemss;
                        ListViewItem item1 = null;
                        item1 = new ListViewItem(item.Key, 0);
                        subItemss = new ListViewItem.ListViewSubItem[]
                                  { new ListViewItem.ListViewSubItem(item1, item.Value.GetType().Name.ToString()),
                                new ListViewItem.ListViewSubItem(item1, item.Value)
                                  };

                        item1.SubItems.AddRange(subItemss);
                        listView1.Items.Add(item1);
                    }
                    return;
                }
            }
            for(int i=0;i<subObjects.Count;i++)
            {
                TreeNode node = parentNode.Nodes[i];
                nodeDeep(node, subObjects[i].Item2.SubObjects, target);
            }
            return;
        }

        private void nodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            ss = null;
            for (int i = 0; i < bObjects.Count; i++)
            {
                if(bObjects[i].Name==newSelected.Text)
                {
                    ss = newSelected.Text;
                    for (int j = 0; j < bObjects[i].SubObjects.Count; j++)
                    {
                        ListViewItem.ListViewSubItem[] subItems;
                        ListViewItem item = null;
                        item = new ListViewItem(bObjects[i].SubObjects[j].Item2.Name, 0);
                        subItems = new ListViewItem.ListViewSubItem[]
                                  { new ListViewItem.ListViewSubItem(item,item.GetType().Name.ToString()),
                                new ListViewItem.ListViewSubItem(item, null)
                                  };

                        item.SubItems.AddRange(subItems);
                        listView1.Items.Add(item);
                    }
                }
                nodeDeep(treeView1.Nodes[i], bObjects[i].SubObjects, newSelected.Text);
                /*for (int j = 0; j < bObjects[i].SubObjects.Count; j++)
                {
                    if(bObjects[i].SubObjects[j].Item2.Name==newSelected.Text)
                    {
                        ss = newSelected.Text;
                        foreach (KeyValuePair<string, string> item in bObjects[i].SubObjects[j].Item2.Values)
                        {
                            ListViewItem.ListViewSubItem[] subItemss;
                            ListViewItem item1 = null;
                            item1 = new ListViewItem(item.Key, 0);
                            subItemss = new ListViewItem.ListViewSubItem[]
                                      { new ListViewItem.ListViewSubItem(item1, item.Value.GetType().Name.ToString()),
                                new ListViewItem.ListViewSubItem(item1, item.Value)
                                      };

                            item1.SubItems.AddRange(subItemss);
                            listView1.Items.Add(item1);
                        }
                    }
                }*/
            }
        }

        List<Tuple<string, BmlObject>> Bmldeepchange(List<Tuple<string, BmlObject>> sObjects)
        {
            List<Tuple<string, BmlObject>> subObjects = new List<Tuple<string, BmlObject>>(sObjects);
            for (int i=0;i<subObjects.Count;i++)
            {
                if(subObjects[i].Item2.Name == ss)
                {
                    Dictionary<string, string> pair = new Dictionary<string, string>();
                    foreach (ListViewItem items in listView1.Items)
                    {
                        foreach (KeyValuePair<string, string> item in subObjects[i].Item2.Values)
                        {
                            if (item.Key == items.Text) pair[item.Key] = items.SubItems[2].Text;
                        }
                    }
                    foreach (KeyValuePair<string, string> item in pair)
                    {
                        Console.WriteLine("[{0}:{1}]", item.Key, item.Value);
                        subObjects[i].Item2.Values[item.Key] = item.Value;
                    }
                }
                else
                {
                    List<Tuple<string, BmlObject>> sbtuples = new List<Tuple<string, BmlObject>>(Bmldeepchange(subObjects[i].Item2.SubObjects));
                    for(int j=0;j<sbtuples.Count;j++)
                    {
                        subObjects[i].Item2.SubObjects[j] = sbtuples[j];
                    }
                }
            }
            return subObjects;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a location to edit");
                return;
            }
            listView1.SelectedItems[0].SubItems[2].Text = textBox1.Text;
            for (int i = 0; i < bObjects.Count; i++)
            {
                List<Tuple<string, BmlObject>> sbtuples = new List<Tuple<string, BmlObject>>(Bmldeepchange(bObjects[i].SubObjects));
                for (int j = 0; j < bObjects[i].SubObjects.Count; j++)
                {
                    bObjects[i].SubObjects[j] = sbtuples[j];
                }
            }
        }

        private void IP_Port_Write(PINFile pinFile)
        {
            listView2.Items.Clear();
            foreach (PINFile.AuthMethod authMethod in pinFile.AuthMethods)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Name:{0}", authMethod.Name);
                Console.WriteLine("IP:{0} Port{1}", authMethod.LoginServers[0].IP, authMethod.LoginServers[0].Port);
            }
            for(int i=0;i<pinFile.AuthMethods.Count;i++)
            {
                ListViewItem newItem = new ListViewItem(new String[]{pinFile.AuthMethods[i].Name,pinFile.AuthMethods[i].LoginServers[0].IP,pinFile.AuthMethods[i].LoginServers[0].Port.ToString()});
                listView2.Items.Add(newItem);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a location to delete");
                return;
            }
            var idxColl = listView2.SelectedIndices;
            for(int i=idxColl.Count-1;i>=0;i--)
            {
                int idx = idxColl[i];
                listView2.Items[idx].Remove();
                Amethod.RemoveAt(idx);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int cnt = listView2.Items.Count;
            ListViewItem newItem = new ListViewItem(new String[] {nameBox.Text, ipBox.Text, portBox.Text });
            listView2.Items.Add(newItem);
            PINFile.AuthMethod authMethod = new PINFile.AuthMethod();
            authMethod.Name = nameBox.Text;
            authMethod.LoginServers = new List<PINFile.IPEndPoint>();
            authMethod.LoginServers.Add(new PINFile.IPEndPoint
            {
                IP = ipBox.Text,
                Port = Convert.ToUInt16(portBox.Text)
            });
            Amethod.Add(authMethod);
        }

        void delDeep(List<Tuple<string, BmlObject>> subObjects)
        {
            for(int i=0;i<subObjects.Count;i++)
            {
                if(subObjects[i].Item1 == ss)
                {
                    Dictionary<string, string> pair = new Dictionary<string, string>(subObjects[i].Item2.Values);
                    bool flag = false;
                    foreach (KeyValuePair<string, string> item in pair)
                    {
                        if (flag) break;
                        if (item.Key == listView1.SelectedItems[0].Text)
                        {
                            pair.Remove(item.Key);
                            listView1.Items.Remove(listView1.SelectedItems[0]);
                            flag = true;
                            break;
                        }
                    }
                    subObjects[i].Item2.Values.Clear();
                    foreach (KeyValuePair<string, string> item in pair)
                    {
                        Console.WriteLine("[{0}:{1}]", item.Key, item.Value);
                        subObjects[i].Item2.Values.Add(item.Key,item.Value);
                    }
                    return;
                }
                else
                {
                    delDeep(subObjects[i].Item2.SubObjects);
                }
            }
        }

        private void bmldelBtn_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select to delete");
                return;
            }
            for(int i=0;i<bObjects.Count;i++)
            {
                delDeep(bObjects[i].SubObjects);
            }
        }

        private void bignodedelBtn_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;
            for(int i=0;i<bObjects.Count;i++)
            {
                if(bObjects[i].Name==treeView1.SelectedNode.Text)
                {
                    treeView1.Nodes.Remove(treeView1.SelectedNode);
                    bObjects.RemoveAt(i);
                }
            }
        }

        private void bignodeaddBtn_Click(object sender, EventArgs e)
        {
            if (bignodeBox == null) return;
            treeView1.Nodes.Add(bignodeBox.Text);
            BmlObject bObj = new BmlObject();
            bObj.Name = bignodeBox.Text;
            bObjects.Add(bObj);
        }

        void subnodedeldeep(List<Tuple<string, BmlObject>> subObjects,TreeNode parentNode)
        {
            for (int i = 0; i < subObjects.Count; i++)
            {
                TreeNode node = parentNode.Nodes[i];
                if (subObjects[i].Item2.Name == ss && node.Text == ss)
                {
                    parentNode.Nodes.Remove(node);
                    subObjects.RemoveAt(i);
                    return;
                }
                else
                {
                    subnodedeldeep(subObjects[i].Item2.SubObjects, node);
                }
            }
            return;
        }

        private void subnodedelBtn_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;
            for (int i = 0; i < bObjects.Count; i++)
            {
                subnodedeldeep(bObjects[i].SubObjects, treeView1.Nodes[i]);
            }
        }

        bool isexistinbml(List<Tuple<string, BmlObject>> subObjects, string target)
        {
            for (int i = 0; i < subObjects.Count; i++)
            {
                if (subObjects[i].Item2.Name == target)
                {
                    return true;
                }
                else
                {
                    return isexistinbml(subObjects[i].Item2.SubObjects, target);
                }
            }
            return false;
        }

        void subnodeadd(List<Tuple<string, BmlObject>> subObjects, string target, TreeNode parentNode)
        {
            for (int i = 0; i < subObjects.Count; i++)
            {
                TreeNode node = parentNode.Nodes[i];
                if (subObjects[i].Item1 == ss)
                {
                    Tuple<string, BmlObject> tuples = new Tuple<string, BmlObject>(target, new BmlObject());
                    tuples.Item2.Name = target;
                    subObjects[i].Item2.SubObjects.Add(tuples);
                    parentNode.Nodes[i].Nodes.Add(target);
                    BmlView(bObjects);
                    return;
                }
                else
                {
                    subnodeadd(subObjects[i].Item2.SubObjects, target, node);
                }
            }
            return;
        }

        private void subnodeaddBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(ss);
            for(int i=0;i<bObjects.Count;i++)
            {
                if(isexistinbml(bObjects[i].SubObjects,subnodeBox.Text))
                {
                    MessageBox.Show("SubObject Name is exist");
                    return;
                }
            }
            for (int i = 0; i < bObjects.Count; i++)
            {
                if(bObjects[i].Name == ss)
                {
                    Tuple<string, BmlObject> tuples = new Tuple<string, BmlObject>(subnodeBox.Text, new BmlObject());
                    tuples.Item2.Name = subnodeBox.Text;
                    bObjects[i].SubObjects.Add(tuples);
                    treeView1.Nodes[i].Nodes.Add(subnodeBox.Text);
                    BmlView(bObjects);
                    return;
                }
            }
            for(int i=0; i<bObjects.Count; i++)
            {
                subnodeadd(bObjects[i].SubObjects, subnodeBox.Text, treeView1.Nodes[i]);
            }
        }

        void addDeep(List<Tuple<string, BmlObject>> subObjects)
        {
            for (int i = 0; i < subObjects.Count; i++)
            {
                if (subObjects[i].Item1 == ss)
                {
                    subObjects[i].Item2.Values.Add(bmlnameBox.Text, bmlvalueBox.Text);
                    ListViewItem.ListViewSubItem[] subItemss;
                    ListViewItem item1 = null;
                    item1 = new ListViewItem(bmlnameBox.Text, 0);
                    subItemss = new ListViewItem.ListViewSubItem[]
                              { new ListViewItem.ListViewSubItem(item1, subObjects[i].Item2.Values[bmlnameBox.Text].GetType().Name.ToString()),
                                new ListViewItem.ListViewSubItem(item1, subObjects[i].Item2.Values[bmlnameBox.Text])
                              };

                    item1.SubItems.AddRange(subItemss);
                    listView1.Items.Add(item1);
                    return;
                }
                else
                {
                    addDeep(subObjects[i].Item2.SubObjects);
                }
            }
        }

        private void bmladdBtn_Click(object sender, EventArgs e)
        {
            for(int i=0;i<bObjects.Count;i++)
            {
                addDeep(bObjects[i].SubObjects);
            }
        }
    }
}
