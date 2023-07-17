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
            openFileDlg.Filter = "PIN(*.pin;)|*.pin";
            openFileDlg.ShowDialog();
            if (openFileDlg.FileName.Length > 0)
            {
                foreach (string filename in openFileDlg.FileNames)
                {
                    filedir = filename;
                }
            }
            PINFile pinFile = new PINFile(filedir);
            Console.Clear();
            Console.WriteLine(pinFile.Header.AESKey);
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
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PINFile pinFile = new PINFile(filedir);
            pinFile.Header.Unk1 = Convert.ToByte(unk1Box.Text);
            pinFile.Header.Unk2 = Convert.ToByte(unk2Box.Text);
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
            File.WriteAllBytes(string.Concat(new string[]
                {
                    filedir
            }), pinFile.GetEncryptedData());
        }

        public string filedir;
    }
}
