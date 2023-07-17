
namespace PINEditor
{
    partial class PINEditor
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.aesKeyBox = new System.Windows.Forms.TextBox();
            this.patchUrlBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.loginTypeBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.unk5Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.unk4Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.minorVersionBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.unk3Box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.localeTypeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unk2Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.localeIDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unk1Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 411);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.aesKeyBox);
            this.tabPage1.Controls.Add(this.patchUrlBox);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.loginTypeBox);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.urlBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.unk5Box);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.unk4Box);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.minorVersionBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.unk3Box);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.localeTypeBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.unk2Box);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.localeIDBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.unk1Box);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(792, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Primary Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // aesKeyBox
            // 
            this.aesKeyBox.Location = new System.Drawing.Point(108, 229);
            this.aesKeyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aesKeyBox.Name = "aesKeyBox";
            this.aesKeyBox.Size = new System.Drawing.Size(317, 21);
            this.aesKeyBox.TabIndex = 19;
            // 
            // patchUrlBox
            // 
            this.patchUrlBox.Location = new System.Drawing.Point(108, 278);
            this.patchUrlBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patchUrlBox.Name = "patchUrlBox";
            this.patchUrlBox.Size = new System.Drawing.Size(317, 21);
            this.patchUrlBox.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F);
            this.label12.Location = new System.Drawing.Point(52, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "AESKey";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F);
            this.label9.Location = new System.Drawing.Point(39, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "PatchURL";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginTypeBox
            // 
            this.loginTypeBox.Location = new System.Drawing.Point(108, 204);
            this.loginTypeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginTypeBox.Name = "loginTypeBox";
            this.loginTypeBox.Size = new System.Drawing.Size(317, 21);
            this.loginTypeBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F);
            this.label11.Location = new System.Drawing.Point(38, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "LoginType";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(108, 254);
            this.urlBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(317, 21);
            this.urlBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F);
            this.label10.Location = new System.Drawing.Point(73, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "URL";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unk5Box
            // 
            this.unk5Box.Location = new System.Drawing.Point(108, 179);
            this.unk5Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unk5Box.Name = "unk5Box";
            this.unk5Box.Size = new System.Drawing.Size(317, 21);
            this.unk5Box.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F);
            this.label5.Location = new System.Drawing.Point(68, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "Unk5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unk4Box
            // 
            this.unk4Box.Location = new System.Drawing.Point(108, 154);
            this.unk4Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unk4Box.Name = "unk4Box";
            this.unk4Box.Size = new System.Drawing.Size(317, 21);
            this.unk4Box.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F);
            this.label6.Location = new System.Drawing.Point(68, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unk4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minorVersionBox
            // 
            this.minorVersionBox.Location = new System.Drawing.Point(108, 130);
            this.minorVersionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minorVersionBox.Name = "minorVersionBox";
            this.minorVersionBox.Size = new System.Drawing.Size(317, 21);
            this.minorVersionBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F);
            this.label7.Location = new System.Drawing.Point(24, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "MinorVersion";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unk3Box
            // 
            this.unk3Box.Location = new System.Drawing.Point(108, 105);
            this.unk3Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unk3Box.Name = "unk3Box";
            this.unk3Box.Size = new System.Drawing.Size(317, 21);
            this.unk3Box.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F);
            this.label8.Location = new System.Drawing.Point(68, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "Unk3";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // localeTypeBox
            // 
            this.localeTypeBox.Location = new System.Drawing.Point(108, 80);
            this.localeTypeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.localeTypeBox.Name = "localeTypeBox";
            this.localeTypeBox.Size = new System.Drawing.Size(317, 21);
            this.localeTypeBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F);
            this.label4.Location = new System.Drawing.Point(31, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "LocaleType";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unk2Box
            // 
            this.unk2Box.Location = new System.Drawing.Point(108, 55);
            this.unk2Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unk2Box.Name = "unk2Box";
            this.unk2Box.Size = new System.Drawing.Size(317, 21);
            this.unk2Box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F);
            this.label3.Location = new System.Drawing.Point(68, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unk2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // localeIDBox
            // 
            this.localeIDBox.Location = new System.Drawing.Point(108, 30);
            this.localeIDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.localeIDBox.Name = "localeIDBox";
            this.localeIDBox.Size = new System.Drawing.Size(317, 21);
            this.localeIDBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F);
            this.label2.Location = new System.Drawing.Point(47, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "LocaleID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unk1Box
            // 
            this.unk1Box.Location = new System.Drawing.Point(108, 6);
            this.unk1Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unk1Box.Name = "unk1Box";
            this.unk1Box.Size = new System.Drawing.Size(317, 21);
            this.unk1Box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F);
            this.label1.Location = new System.Drawing.Point(68, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unk1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(792, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bml Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Type,
            this.Value});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(274, 6);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(514, 377);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 120;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 107;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 352;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(5, 6);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(263, 378);
            this.treeView1.TabIndex = 0;
            // 
            // PINEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "PINEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox unk1Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox localeTypeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unk2Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox localeIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aesKeyBox;
        private System.Windows.Forms.TextBox patchUrlBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox loginTypeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox unk5Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unk4Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox minorVersionBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox unk3Box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.TreeView treeView1;
    }
}

