namespace DarkScript_2
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.editorPanel = new System.Windows.Forms.Panel();
            this.editorSplit = new System.Windows.Forms.SplitContainer();
            this.editorNumeric = new FastColoredTextBoxNS.FastColoredTextBox();
            this.editorVerbose = new FastColoredTextBoxNS.FastColoredTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEMEVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEMEVDAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorSplit)).BeginInit();
            this.editorSplit.Panel1.SuspendLayout();
            this.editorSplit.Panel2.SuspendLayout();
            this.editorSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorVerbose)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editorPanel
            // 
            this.editorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorPanel.Controls.Add(this.editorSplit);
            this.editorPanel.Location = new System.Drawing.Point(13, 46);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(1213, 697);
            this.editorPanel.TabIndex = 0;
            // 
            // editorSplit
            // 
            this.editorSplit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editorSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorSplit.Location = new System.Drawing.Point(0, 0);
            this.editorSplit.Name = "editorSplit";
            // 
            // editorSplit.Panel1
            // 
            this.editorSplit.Panel1.Controls.Add(this.editorNumeric);
            // 
            // editorSplit.Panel2
            // 
            this.editorSplit.Panel2.Controls.Add(this.editorVerbose);
            this.editorSplit.Size = new System.Drawing.Size(1213, 697);
            this.editorSplit.SplitterDistance = 403;
            this.editorSplit.SplitterWidth = 20;
            this.editorSplit.TabIndex = 0;
            // 
            // editorNumeric
            // 
            this.editorNumeric.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.editorNumeric.AutoIndent = false;
            this.editorNumeric.AutoIndentChars = false;
            this.editorNumeric.AutoIndentExistingLines = false;
            this.editorNumeric.AutoScrollMinSize = new System.Drawing.Size(27, 16);
            this.editorNumeric.BackBrush = null;
            this.editorNumeric.CharHeight = 16;
            this.editorNumeric.CharWidth = 8;
            this.editorNumeric.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editorNumeric.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editorNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorNumeric.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.editorNumeric.IsReplaceMode = false;
            this.editorNumeric.Location = new System.Drawing.Point(0, 0);
            this.editorNumeric.Name = "editorNumeric";
            this.editorNumeric.Paddings = new System.Windows.Forms.Padding(0);
            this.editorNumeric.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editorNumeric.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("editorNumeric.ServiceColors")));
            this.editorNumeric.Size = new System.Drawing.Size(399, 693);
            this.editorNumeric.TabIndex = 0;
            this.editorNumeric.Zoom = 100;
            this.editorNumeric.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.editorNumeric_TextChanged);
            this.editorNumeric.SelectionChanged += new System.EventHandler(this.editorNumeric_SelectionChanged);
            this.editorNumeric.SelectionChangedDelayed += new System.EventHandler(this.editorNumeric_SelectionChangedDelayed);
            this.editorNumeric.Scroll += new System.Windows.Forms.ScrollEventHandler(this.editorNumeric_Scroll);
            this.editorNumeric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Box_KeyDown);
            // 
            // editorVerbose
            // 
            this.editorVerbose.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.editorVerbose.AutoIndent = false;
            this.editorVerbose.AutoIndentChars = false;
            this.editorVerbose.AutoIndentExistingLines = false;
            this.editorVerbose.AutoScrollMinSize = new System.Drawing.Size(27, 16);
            this.editorVerbose.BackBrush = null;
            this.editorVerbose.CharHeight = 16;
            this.editorVerbose.CharWidth = 8;
            this.editorVerbose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editorVerbose.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editorVerbose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorVerbose.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.editorVerbose.IsReplaceMode = false;
            this.editorVerbose.Location = new System.Drawing.Point(0, 0);
            this.editorVerbose.Name = "editorVerbose";
            this.editorVerbose.Paddings = new System.Windows.Forms.Padding(0);
            this.editorVerbose.ReadOnly = true;
            this.editorVerbose.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editorVerbose.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("editorVerbose.ServiceColors")));
            this.editorVerbose.Size = new System.Drawing.Size(786, 693);
            this.editorVerbose.TabIndex = 0;
            this.editorVerbose.Zoom = 100;
            this.editorVerbose.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.editorVerbose_TextChanged);
            this.editorVerbose.SelectionChanged += new System.EventHandler(this.editorVerbose_SelectionChanged);
            this.editorVerbose.SelectionChangedDelayed += new System.EventHandler(this.editorVerbose_SelectionChangedDelayed);
            this.editorVerbose.Scroll += new System.Windows.Forms.ScrollEventHandler(this.editorVerbose_Scroll);
            this.editorVerbose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Box_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.saveEMEVDToolStripMenuItem,
            this.saveProjectAsToolStripMenuItem,
            this.saveEMEVDAsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.openProjectToolStripMenuItem.Text = "Open";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openEMEVDToolStripMenuItem_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // saveEMEVDToolStripMenuItem
            // 
            this.saveEMEVDToolStripMenuItem.Name = "saveEMEVDToolStripMenuItem";
            this.saveEMEVDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveEMEVDToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.saveEMEVDToolStripMenuItem.Text = "Save EMEVD";
            this.saveEMEVDToolStripMenuItem.Click += new System.EventHandler(this.saveEMEVDToolStripMenuItem_Click);
            // 
            // saveProjectAsToolStripMenuItem
            // 
            this.saveProjectAsToolStripMenuItem.Name = "saveProjectAsToolStripMenuItem";
            this.saveProjectAsToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.saveProjectAsToolStripMenuItem.Text = "Save Project As";
            this.saveProjectAsToolStripMenuItem.Click += new System.EventHandler(this.saveProjectAsToolStripMenuItem_Click);
            // 
            // saveEMEVDAsToolStripMenuItem
            // 
            this.saveEMEVDAsToolStripMenuItem.Name = "saveEMEVDAsToolStripMenuItem";
            this.saveEMEVDAsToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.saveEMEVDAsToolStripMenuItem.Text = "Save EMEVD As";
            this.saveEMEVDAsToolStripMenuItem.Click += new System.EventHandler(this.saveEMEVDAsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshProjectToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // refreshProjectToolStripMenuItem
            // 
            this.refreshProjectToolStripMenuItem.Name = "refreshProjectToolStripMenuItem";
            this.refreshProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshProjectToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.refreshProjectToolStripMenuItem.Text = "Refresh Verbose";
            this.refreshProjectToolStripMenuItem.Click += new System.EventHandler(this.refreshProjectToolStripMenuItem_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 755);
            this.Controls.Add(this.editorPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI";
            this.Text = "DarkScript 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUI_KeyDown);
            this.editorPanel.ResumeLayout(false);
            this.editorSplit.Panel1.ResumeLayout(false);
            this.editorSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorSplit)).EndInit();
            this.editorSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorVerbose)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel editorPanel;
        private System.Windows.Forms.SplitContainer editorSplit;
        private FastColoredTextBoxNS.FastColoredTextBox editorNumeric;
        private FastColoredTextBoxNS.FastColoredTextBox editorVerbose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveEMEVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveEMEVDAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshProjectToolStripMenuItem;
    }
}

