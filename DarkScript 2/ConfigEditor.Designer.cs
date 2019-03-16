namespace DarkScript_2
{
    partial class ConfigEditor
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
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.askBtn = new System.Windows.Forms.RadioButton();
            this.overwriteBtn = new System.Windows.Forms.RadioButton();
            this.backupBtn = new System.Windows.Forms.RadioButton();
            this.loadBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.Location = new System.Drawing.Point(291, 201);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(82, 31);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(203, 201);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(82, 31);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.loadBtn);
            this.groupBox1.Controls.Add(this.backupBtn);
            this.groupBox1.Controls.Add(this.overwriteBtn);
            this.groupBox1.Controls.Add(this.askBtn);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // askBtn
            // 
            this.askBtn.AutoSize = true;
            this.askBtn.Location = new System.Drawing.Point(43, 54);
            this.askBtn.Name = "askBtn";
            this.askBtn.Size = new System.Drawing.Size(121, 21);
            this.askBtn.TabIndex = 0;
            this.askBtn.Text = "Ask what to do";
            this.askBtn.UseVisualStyleBackColor = true;
            // 
            // overwriteBtn
            // 
            this.overwriteBtn.AutoSize = true;
            this.overwriteBtn.Location = new System.Drawing.Point(43, 104);
            this.overwriteBtn.Name = "overwriteBtn";
            this.overwriteBtn.Size = new System.Drawing.Size(244, 21);
            this.overwriteBtn.TabIndex = 1;
            this.overwriteBtn.Text = "Overwrite existing with new project";
            this.overwriteBtn.UseVisualStyleBackColor = true;
            // 
            // backupBtn
            // 
            this.backupBtn.AutoSize = true;
            this.backupBtn.Location = new System.Drawing.Point(43, 129);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(275, 21);
            this.backupBtn.TabIndex = 4;
            this.backupBtn.Text = "Backup existing and create new project";
            this.backupBtn.UseVisualStyleBackColor = true;
            // 
            // loadBtn
            // 
            this.loadBtn.AutoSize = true;
            this.loadBtn.Location = new System.Drawing.Point(43, 79);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(159, 21);
            this.loadBtn.TabIndex = 5;
            this.loadBtn.Text = "Load existing project";
            this.loadBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "When loading an EMEVD with an existing project file:";
            // 
            // ConfigEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(387, 244);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfigEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton loadBtn;
        private System.Windows.Forms.RadioButton backupBtn;
        private System.Windows.Forms.RadioButton overwriteBtn;
        private System.Windows.Forms.RadioButton askBtn;
        private System.Windows.Forms.Label label1;
    }
}