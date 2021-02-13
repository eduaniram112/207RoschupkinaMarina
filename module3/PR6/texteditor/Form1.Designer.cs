
namespace texteditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextCopyStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCutStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPasteStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSelectAllStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextFormatStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatBoldStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatItalicsStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatUnderlineStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatStrikeStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsAutosaveStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsThemeStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.themeLightStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.themeDarkStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFontStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBoldStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItalicsStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUnderlineStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrikeStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.faqStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(870, 917);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "add tad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Create_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(191, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1522, 773);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1514, 730);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "new file";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(38, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1437, 614);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextCopyStripMenuItem1,
            this.contextCutStripMenuItem2,
            this.contextPasteStripMenuItem3,
            this.contextSelectAllStripMenuItem4,
            this.contextFormatStripMenuItem5});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 184);
            // 
            // contextCopyStripMenuItem1
            // 
            this.contextCopyStripMenuItem1.Name = "contextCopyStripMenuItem1";
            this.contextCopyStripMenuItem1.Size = new System.Drawing.Size(166, 36);
            this.contextCopyStripMenuItem1.Text = "copy";
            this.contextCopyStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // contextCutStripMenuItem2
            // 
            this.contextCutStripMenuItem2.Name = "contextCutStripMenuItem2";
            this.contextCutStripMenuItem2.Size = new System.Drawing.Size(166, 36);
            this.contextCutStripMenuItem2.Text = "cut";
            this.contextCutStripMenuItem2.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // contextPasteStripMenuItem3
            // 
            this.contextPasteStripMenuItem3.Name = "contextPasteStripMenuItem3";
            this.contextPasteStripMenuItem3.Size = new System.Drawing.Size(166, 36);
            this.contextPasteStripMenuItem3.Text = "paste";
            this.contextPasteStripMenuItem3.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // contextSelectAllStripMenuItem4
            // 
            this.contextSelectAllStripMenuItem4.Name = "contextSelectAllStripMenuItem4";
            this.contextSelectAllStripMenuItem4.Size = new System.Drawing.Size(166, 36);
            this.contextSelectAllStripMenuItem4.Text = "select all";
            this.contextSelectAllStripMenuItem4.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // contextFormatStripMenuItem5
            // 
            this.contextFormatStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatBoldStripMenuItem1,
            this.formatItalicsStripMenuItem2,
            this.formatUnderlineStripMenuItem3,
            this.formatStrikeStripMenuItem4});
            this.contextFormatStripMenuItem5.Name = "contextFormatStripMenuItem5";
            this.contextFormatStripMenuItem5.Size = new System.Drawing.Size(166, 36);
            this.contextFormatStripMenuItem5.Text = "format";
            // 
            // formatBoldStripMenuItem1
            // 
            this.formatBoldStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formatBoldStripMenuItem1.Name = "formatBoldStripMenuItem1";
            this.formatBoldStripMenuItem1.Size = new System.Drawing.Size(218, 40);
            this.formatBoldStripMenuItem1.Text = "bold";
            this.formatBoldStripMenuItem1.Click += new System.EventHandler(this.formatBoldStripMenuItem1_Click);
            // 
            // formatItalicsStripMenuItem2
            // 
            this.formatItalicsStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.formatItalicsStripMenuItem2.Name = "formatItalicsStripMenuItem2";
            this.formatItalicsStripMenuItem2.Size = new System.Drawing.Size(218, 40);
            this.formatItalicsStripMenuItem2.Text = "italics";
            this.formatItalicsStripMenuItem2.Click += new System.EventHandler(this.formatItalicsStripMenuItem2_Click);
            // 
            // formatUnderlineStripMenuItem3
            // 
            this.formatUnderlineStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.formatUnderlineStripMenuItem3.Name = "formatUnderlineStripMenuItem3";
            this.formatUnderlineStripMenuItem3.Size = new System.Drawing.Size(218, 40);
            this.formatUnderlineStripMenuItem3.Text = "underline";
            this.formatUnderlineStripMenuItem3.Click += new System.EventHandler(this.formatUnderlineStripMenuItem3_Click);
            // 
            // formatStrikeStripMenuItem4
            // 
            this.formatStrikeStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.formatStrikeStripMenuItem4.Name = "formatStrikeStripMenuItem4";
            this.formatStrikeStripMenuItem4.Size = new System.Drawing.Size(218, 40);
            this.formatStrikeStripMenuItem4.Text = "strikeout";
            this.formatStrikeStripMenuItem4.Click += new System.EventHandler(this.formatStrikeStripMenuItem4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.settingsStripMenuItem1,
            this.formatStripMenuItem1,
            this.helpStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1878, 38);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 34);
            this.fileToolStripMenuItem.Text = "&file";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.newToolStripMenuItem.Text = "&new";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.Create_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.openToolStripMenuItem.Text = "&open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.saveToolStripMenuItem.Text = "&save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.saveAsToolStripMenuItem.Text = "save &as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(66, 34);
            this.editToolStripMenuItem.Text = "&edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(316, 40);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(316, 40);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(316, 40);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(316, 40);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(316, 40);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(316, 40);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // settingsStripMenuItem1
            // 
            this.settingsStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsAutosaveStripMenuItem1,
            this.settingsThemeStripMenuItem2});
            this.settingsStripMenuItem1.Name = "settingsStripMenuItem1";
            this.settingsStripMenuItem1.Size = new System.Drawing.Size(103, 34);
            this.settingsStripMenuItem1.Text = "settings";
            // 
            // settingsAutosaveStripMenuItem1
            // 
            this.settingsAutosaveStripMenuItem1.Name = "settingsAutosaveStripMenuItem1";
            this.settingsAutosaveStripMenuItem1.Size = new System.Drawing.Size(214, 40);
            this.settingsAutosaveStripMenuItem1.Text = "autosave";
            this.settingsAutosaveStripMenuItem1.Click += new System.EventHandler(this.settingsAutosaveStripMenuItem1_Click);
            // 
            // settingsThemeStripMenuItem2
            // 
            this.settingsThemeStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeLightStripMenuItem1,
            this.themeDarkStripMenuItem1});
            this.settingsThemeStripMenuItem2.Name = "settingsThemeStripMenuItem2";
            this.settingsThemeStripMenuItem2.Size = new System.Drawing.Size(214, 40);
            this.settingsThemeStripMenuItem2.Text = "theme";
            // 
            // themeLightStripMenuItem1
            // 
            this.themeLightStripMenuItem1.Name = "themeLightStripMenuItem1";
            this.themeLightStripMenuItem1.Size = new System.Drawing.Size(172, 40);
            this.themeLightStripMenuItem1.Text = "light";
            this.themeLightStripMenuItem1.Click += new System.EventHandler(this.themeLightStripMenuItem1_Click);
            // 
            // themeDarkStripMenuItem1
            // 
            this.themeDarkStripMenuItem1.Name = "themeDarkStripMenuItem1";
            this.themeDarkStripMenuItem1.Size = new System.Drawing.Size(172, 40);
            this.themeDarkStripMenuItem1.Text = "dark";
            this.themeDarkStripMenuItem1.Click += new System.EventHandler(this.themeDarkStripMenuItem1_Click);
            // 
            // formatStripMenuItem1
            // 
            this.formatStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFontStripMenuItem1,
            this.menuBoldStripMenuItem2,
            this.menuItalicsStripMenuItem3,
            this.menuUnderlineStripMenuItem4,
            this.menuStrikeStripMenuItem5});
            this.formatStripMenuItem1.Name = "formatStripMenuItem1";
            this.formatStripMenuItem1.Size = new System.Drawing.Size(93, 34);
            this.formatStripMenuItem1.Text = "format";
            // 
            // menuFontStripMenuItem1
            // 
            this.menuFontStripMenuItem1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuFontStripMenuItem1.Name = "menuFontStripMenuItem1";
            this.menuFontStripMenuItem1.Size = new System.Drawing.Size(218, 40);
            this.menuFontStripMenuItem1.Text = "font";
            this.menuFontStripMenuItem1.Click += new System.EventHandler(this.menuFontStripMenuItem1_Click);
            // 
            // menuBoldStripMenuItem2
            // 
            this.menuBoldStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuBoldStripMenuItem2.Name = "menuBoldStripMenuItem2";
            this.menuBoldStripMenuItem2.Size = new System.Drawing.Size(218, 40);
            this.menuBoldStripMenuItem2.Text = "bold";
            this.menuBoldStripMenuItem2.Click += new System.EventHandler(this.formatBoldStripMenuItem1_Click);
            // 
            // menuItalicsStripMenuItem3
            // 
            this.menuItalicsStripMenuItem3.Name = "menuItalicsStripMenuItem3";
            this.menuItalicsStripMenuItem3.Size = new System.Drawing.Size(218, 40);
            this.menuItalicsStripMenuItem3.Text = "italics";
            this.menuItalicsStripMenuItem3.Click += new System.EventHandler(this.formatItalicsStripMenuItem2_Click);
            // 
            // menuUnderlineStripMenuItem4
            // 
            this.menuUnderlineStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.menuUnderlineStripMenuItem4.Name = "menuUnderlineStripMenuItem4";
            this.menuUnderlineStripMenuItem4.Size = new System.Drawing.Size(218, 40);
            this.menuUnderlineStripMenuItem4.Text = "underline";
            this.menuUnderlineStripMenuItem4.Click += new System.EventHandler(this.formatUnderlineStripMenuItem3_Click);
            // 
            // menuStrikeStripMenuItem5
            // 
            this.menuStrikeStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.menuStrikeStripMenuItem5.Name = "menuStrikeStripMenuItem5";
            this.menuStrikeStripMenuItem5.Size = new System.Drawing.Size(218, 40);
            this.menuStrikeStripMenuItem5.Text = "strikeout";
            this.menuStrikeStripMenuItem5.Click += new System.EventHandler(this.formatStrikeStripMenuItem4_Click);
            // 
            // helpStripMenuItem1
            // 
            this.helpStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faqStripMenuItem1,
            this.aboutStripMenuItem1});
            this.helpStripMenuItem1.Name = "helpStripMenuItem1";
            this.helpStripMenuItem1.Size = new System.Drawing.Size(71, 34);
            this.helpStripMenuItem1.Text = "help";
            // 
            // faqStripMenuItem1
            // 
            this.faqStripMenuItem1.Name = "faqStripMenuItem1";
            this.faqStripMenuItem1.Size = new System.Drawing.Size(252, 40);
            this.faqStripMenuItem1.Text = "hotkeys";
            this.faqStripMenuItem1.Click += new System.EventHandler(this.faqStripMenuItem1_Click);
            // 
            // aboutStripMenuItem1
            // 
            this.aboutStripMenuItem1.Name = "aboutStripMenuItem1";
            this.aboutStripMenuItem1.Size = new System.Drawing.Size(252, 40);
            this.aboutStripMenuItem1.Text = "about author";
            this.aboutStripMenuItem1.Click += new System.EventHandler(this.aboutStripMenuItem1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "txt files \"(*.txt)|*.txt| RTF (*.rtf*)|*.rtf*\"";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 120000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1878, 1066);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem faqStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem settingsStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextCopyStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem cutStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pasteStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem selectAllStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem formatStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem contextCutStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem contextPasteStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem contextSelectAllStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem contextFormatStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem formatBoldStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formatItalicsStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem formatUnderlineStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem formatStrikeStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuFontStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuBoldStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItalicsStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuUnderlineStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuStrikeStripMenuItem5;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem settingsAutosaveStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsThemeStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem themeLightStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem themeDarkStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
    }
}

