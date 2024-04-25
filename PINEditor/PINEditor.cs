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
            openFileDlg.Filter = "PIN File ONLY(*.pin;)|*.pin";
            openFileDlg.ShowDialog();
            if (openFileDlg.FileName.Length > 0)
            {
                foreach (string filename in openFileDlg.FileNames)
                {
                    filedir = filename;
                }
            }
            PINFile pinFile = new PINFile(filedir);
            Console.WriteLine(pinFile.Header.AESKey);
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
            BmlTreeWrite(pinFile.BmlObjects);
            IP_Port_Write(pinFile);
            Console.WriteLine("-Authmethod-");
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

        public void BmlView(List<BmlObject> bmlObjects)
        {
            for (int i = 0; i < bmlObjects.Count; i++)
            {
                Console.WriteLine("BML no : {0}", i + 1);
                Console.WriteLine("Name : {0}", bmlObjects[i].Name);
                Console.WriteLine("Value : {0}", bmlObjects[i].Value);
                for (int j = 0; j < bmlObjects[i].SubObjects.Count; j++)
                {
                    Console.WriteLine("SubObjects no : {0}, {1}", j + 1, bmlObjects[i].SubObjects[j].Item1);
                    Console.WriteLine("Name : {0}", bmlObjects[i].SubObjects[j].Item2.Name);
                    Console.WriteLine("Value : {0}", bmlObjects[i].SubObjects[j].Item2.Value);
                    foreach (KeyValuePair<string, string> item in bmlObjects[i].SubObjects[j].Item2.Values)
                    {
                        Console.WriteLine("[{0}:{1}]", item.Key, item.Value);
                    }
                }
            }
        }

        public void BmlTreeWrite(List<BmlObject> bmlObjects)
        {
            treeView1.Nodes.Clear();
            for (int i = 0; i < bmlObjects.Count; i++)
            {
                TreeNode a = new TreeNode(bmlObjects[i].Name.ToString());
                treeView1.Nodes.Add(a);
                for (int j = 0; j < bmlObjects[i].SubObjects.Count; j++)
                {
                    TreeNode b = new TreeNode(bmlObjects[i].SubObjects[j].Item1.ToString());
                    a.Nodes.Add(b);
                    foreach (KeyValuePair<string, string> item in bmlObjects[i].SubObjects[j].Item2.Values)
                    {
                        TreeNode c = new TreeNode(item.Key.ToString());
                        b.Nodes.Add(c);
                    }
                }
            }
        }
        void TreeToList(TreeNode node)

        {
            listView1.Items.Add(
                new ListViewItem(
                     new string[]
                     {
                         node.Text,
                         node.FullPath.Count(f => f == '\\').ToString()
                     }));
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

        private void nodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            ss = null;
            Console.WriteLine(newSelected.Text);
            for (int i = 0; i < bObjects.Count; i++)
            {
                if(bObjects[i].Name==newSelected.Text)
                {
                    listdir = newSelected.Text;
                    for (int j = 0; j < bObjects[i].SubObjects.Count; j++)
                    {
                        ListViewItem.ListViewSubItem[] subItems;
                        ListViewItem item = null;
                        item = new ListViewItem(bObjects[i].SubObjects[j].Item2.Name, 0);
                        subItems = new ListViewItem.ListViewSubItem[]
                                  { new ListViewItem.ListViewSubItem(item, "Container"),
                                new ListViewItem.ListViewSubItem(item, null)
                                  };

                        item.SubItems.AddRange(subItems);
                        listView1.Items.Add(item);
                    }
                }
                for (int j = 0; j < bObjects[i].SubObjects.Count; j++)
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
                                      { new ListViewItem.ListViewSubItem(item1, item.Value.GetType().ToString()),
                                new ListViewItem.ListViewSubItem(item1, item.Value)
                                      };

                            item1.SubItems.AddRange(subItemss);
                            listView1.Items.Add(item1);
                        }
                        Console.WriteLine(listView1.Items.Count);
                    }
                }
            }
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
                for (int j = 0; j < bObjects[i].SubObjects.Count; j++)
                {
                    if (bObjects[i].SubObjects[j].Item2.Name == ss)
                    {
                        Dictionary<string, string> pair = new Dictionary<string, string>();
                        foreach (ListViewItem items in listView1.Items)
                        {
                            foreach (KeyValuePair<string, string> item in bObjects[i].SubObjects[j].Item2.Values)
                            {
                                if (item.Key == items.Text) pair[item.Key] = items.SubItems[2].Text;
                            }
                        }
                        foreach (KeyValuePair<string, string> item in pair)
                        {
                            Console.WriteLine("[{0}:{1}]", item.Key, item.Value);
                            bObjects[i].SubObjects[j].Item2.Values[item.Key] = item.Value;
                        }
                    }
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
    }
}
