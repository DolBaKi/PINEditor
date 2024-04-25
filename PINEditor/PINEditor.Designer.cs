
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
            this.Apply = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addBtn = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1143, 33);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1143, 616);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1135, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Primary Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // aesKeyBox
            // 
            this.aesKeyBox.Location = new System.Drawing.Point(154, 344);
            this.aesKeyBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aesKeyBox.Name = "aesKeyBox";
            this.aesKeyBox.Size = new System.Drawing.Size(451, 28);
            this.aesKeyBox.TabIndex = 19;
            // 
            // patchUrlBox
            // 
            this.patchUrlBox.Location = new System.Drawing.Point(154, 417);
            this.patchUrlBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.patchUrlBox.Name = "patchUrlBox";
            this.patchUrlBox.Size = new System.Drawing.Size(451, 28);
            this.patchUrlBox.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F);
            this.label12.Location = new System.Drawing.Point(74, 346);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "AESKey";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F);
            this.label9.Location = new System.Drawing.Point(56, 422);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "PatchURL";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginTypeBox
            // 
            this.loginTypeBox.Location = new System.Drawing.Point(154, 306);
            this.loginTypeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginTypeBox.Name = "loginTypeBox";
            this.loginTypeBox.Size = new System.Drawing.Size(451, 28);
            this.loginTypeBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F);
            this.label11.Location = new System.Drawing.Point(54, 309);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "LoginType";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(154, 381);
            this.urlBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(451, 28);
            this.urlBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F);
            this.label10.Location = new System.Drawing.Point(104, 384);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "URL";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unk5Box
            // 
            this.unk5Box.Location = new System.Drawing.Point(154, 268);
            this.unk5Box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unk5Box.Name = "unk5Box";
            this.unk5Box.Size = new System.Drawing.Size(451, 28);
            this.unk5Box.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F);
            this.label5.Location = new System.Drawing.Point(97, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Unk5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unk4Box
            // 
            this.unk4Box.Location = new System.Drawing.Point(154, 231);
            this.unk4Box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unk4Box.Name = "unk4Box";
            this.unk4Box.Size = new System.Drawing.Size(451, 28);
            this.unk4Box.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F);
            this.label6.Location = new System.Drawing.Point(97, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unk4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minorVersionBox
            // 
            this.minorVersionBox.Location = new System.Drawing.Point(154, 195);
            this.minorVersionBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minorVersionBox.Name = "minorVersionBox";
            this.minorVersionBox.Size = new System.Drawing.Size(451, 28);
            this.minorVersionBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F);
            this.label7.Location = new System.Drawing.Point(34, 198);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "MinorVersion";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unk3Box
            // 
            this.unk3Box.Location = new System.Drawing.Point(154, 158);
            this.unk3Box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unk3Box.Name = "unk3Box";
            this.unk3Box.Size = new System.Drawing.Size(451, 28);
            this.unk3Box.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F);
            this.label8.Location = new System.Drawing.Point(97, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Unk3";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // localeTypeBox
            // 
            this.localeTypeBox.Location = new System.Drawing.Point(154, 120);
            this.localeTypeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.localeTypeBox.Name = "localeTypeBox";
            this.localeTypeBox.Size = new System.Drawing.Size(451, 28);
            this.localeTypeBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F);
            this.label4.Location = new System.Drawing.Point(44, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "LocaleType";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unk2Box
            // 
            this.unk2Box.Location = new System.Drawing.Point(154, 82);
            this.unk2Box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unk2Box.Name = "unk2Box";
            this.unk2Box.Size = new System.Drawing.Size(451, 28);
            this.unk2Box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F);
            this.label3.Location = new System.Drawing.Point(97, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unk2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // localeIDBox
            // 
            this.localeIDBox.Location = new System.Drawing.Point(154, 45);
            this.localeIDBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.localeIDBox.Name = "localeIDBox";
            this.localeIDBox.Size = new System.Drawing.Size(451, 28);
            this.localeIDBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F);
            this.label2.Location = new System.Drawing.Point(67, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "LocaleID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unk1Box
            // 
            this.unk1Box.Location = new System.Drawing.Point(154, 9);
            this.unk1Box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unk1Box.Name = "unk1Box";
            this.unk1Box.Size = new System.Drawing.Size(451, 28);
            this.unk1Box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F);
            this.label1.Location = new System.Drawing.Point(97, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unk1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Apply);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1135, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bml Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(1013, 489);
            this.Apply.Margin = new System.Windows.Forms.Padding(4);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(107, 34);
            this.Apply.TabIndex = 4;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 492);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(594, 28);
            this.textBox1.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(319, 492);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 32);
            this.label15.TabIndex = 2;
            this.label15.Text = "Value";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Type,
            this.Value});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(319, 9);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 432);
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
            this.Type.Width = 109;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 251;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(7, 9);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(301, 432);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.nodeMouseClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.addBtn);
            this.tabPage3.Controls.Add(this.portBox);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.ipBox);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.nameBox);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.delBtn);
            this.tabPage3.Controls.Add(this.listView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1135, 584);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "IP Data";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(903, 123);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(83, 35);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(797, 125);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(100, 28);
            this.portBox.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(794, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 18);
            this.label16.TabIndex = 6;
            this.label16.Text = "Port";
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(613, 125);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(169, 28);
            this.ipBox.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(610, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "IP";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(497, 125);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 28);
            this.nameBox.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(494, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Name";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(497, 29);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(86, 34);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.IP,
            this.Port});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(9, 10);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(465, 566);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "name";
            this.columnHeader1.Width = 162;
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.Width = 187;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            this.Port.Width = 112;
            // 
            // PINEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 675);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Text = "PINEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button delBtn;
    }
}

