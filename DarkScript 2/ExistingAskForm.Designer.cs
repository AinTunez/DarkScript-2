namespace DarkScript_2
{
    partial class ExistingAskForm
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
            this.loadBtn = new System.Windows.Forms.RadioButton();
            this.backupBtn = new System.Windows.Forms.RadioButton();
            this.overwriteBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.AutoSize = true;
            this.loadBtn.Checked = true;
            this.loadBtn.Location = new System.Drawing.Point(16, 51);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(159, 21);
            this.loadBtn.TabIndex = 8;
            this.loadBtn.TabStop = true;
            this.loadBtn.Text = "Load existing project";
            this.loadBtn.UseVisualStyleBackColor = true;
            // 
            // backupBtn
            // 
            this.backupBtn.AutoSize = true;
            this.backupBtn.Location = new System.Drawing.Point(16, 101);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(275, 21);
            this.backupBtn.TabIndex = 7;
            this.backupBtn.Text = "Backup existing and create new project";
            this.backupBtn.UseVisualStyleBackColor = true;
            // 
            // overwriteBtn
            // 
            this.overwriteBtn.AutoSize = true;
            this.overwriteBtn.Location = new System.Drawing.Point(16, 76);
            this.overwriteBtn.Name = "overwriteBtn";
            this.overwriteBtn.Size = new System.Drawing.Size(244, 21);
            this.overwriteBtn.TabIndex = 6;
            this.overwriteBtn.Text = "Overwrite existing with new project";
            this.overwriteBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "An event project already exists for this file.";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(211, 145);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(76, 37);
            this.OkBtn.TabIndex = 11;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(129, 145);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(76, 37);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ExistingAskForm
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(315, 229);
            this.ControlBox = false;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.backupBtn);
            this.Controls.Add(this.overwriteBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExistingAskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Existing Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        public System.Windows.Forms.RadioButton loadBtn;
        public System.Windows.Forms.RadioButton backupBtn;
        public System.Windows.Forms.RadioButton overwriteBtn;
    }
}