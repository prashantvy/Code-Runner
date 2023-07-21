namespace Code_Runner
{
    partial class Code_Runner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Code_Runner));
            this.btnSetPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.RichTextBox();
            this.chkFile = new System.Windows.Forms.CheckBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSetPath
            // 
            this.btnSetPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetPath.Location = new System.Drawing.Point(668, 29);
            this.btnSetPath.Name = "btnSetPath";
            this.btnSetPath.Size = new System.Drawing.Size(104, 39);
            this.btnSetPath.TabIndex = 41;
            this.btnSetPath.Text = "Set Path";
            this.btnSetPath.UseVisualStyleBackColor = true;
            this.btnSetPath.Click += new System.EventHandler(this.btnSetPath_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Enter File Path:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilePath.Location = new System.Drawing.Point(340, 27);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(301, 39);
            this.txtFilePath.TabIndex = 39;
            this.txtFilePath.Text = "";
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(564, 318);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(48, 16);
            this.lblOutput.TabIndex = 38;
            this.lblOutput.Text = "Output:";
            // 
            // lblInput
            // 
            this.lblInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(272, 318);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(114, 16);
            this.lblInput.TabIndex = 37;
            this.lblInput.Text = "Enter Input (if any):";
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(244, 180);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 16);
            this.lblError.TabIndex = 36;
            this.lblError.Text = "Error:";
            // 
            // lblFile
            // 
            this.lblFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(202, 92);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(106, 16);
            this.lblFile.TabIndex = 35;
            this.lblFile.Text = "Enter File Name:";
            // 
            // txtFile
            // 
            this.txtFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFile.Location = new System.Drawing.Point(205, 116);
            this.txtFile.Margin = new System.Windows.Forms.Padding(20, 20, 11, 10);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(241, 39);
            this.txtFile.TabIndex = 29;
            this.txtFile.Text = "";
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            // 
            // chkFile
            // 
            this.chkFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkFile.AutoSize = true;
            this.chkFile.Location = new System.Drawing.Point(517, 126);
            this.chkFile.Margin = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.chkFile.Name = "chkFile";
            this.chkFile.Size = new System.Drawing.Size(165, 20);
            this.chkFile.TabIndex = 30;
            this.chkFile.Text = "Get Last Modified File?";
            this.chkFile.UseVisualStyleBackColor = true;
            this.chkFile.CheckedChanged += new System.EventHandler(this.chkFile_CheckedChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExecute.Location = new System.Drawing.Point(712, 116);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(11, 20, 11, 10);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(104, 39);
            this.btnExecute.TabIndex = 31;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtError
            // 
            this.txtError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtError.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtError.Location = new System.Drawing.Point(248, 207);
            this.txtError.Margin = new System.Windows.Forms.Padding(29, 20, 20, 20);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(537, 78);
            this.txtError.TabIndex = 34;
            this.txtError.Text = "";
            this.txtError.TextChanged += new System.EventHandler(this.txtError_TextChanged);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInput.Location = new System.Drawing.Point(274, 353);
            this.txtInput.Margin = new System.Windows.Forms.Padding(51, 20, 20, 20);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(172, 205);
            this.txtInput.TabIndex = 32;
            this.txtInput.Text = "";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtOutput.Location = new System.Drawing.Point(568, 353);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(100, 20, 20, 20);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(172, 205);
            this.txtOutput.TabIndex = 33;
            this.txtOutput.Text = "";
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // Code_Runner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1018, 584);
            this.Controls.Add(this.btnSetPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.chkFile);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Code_Runner";
            this.Text = "Code_Runner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtFilePath;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.RichTextBox txtFile;
        private System.Windows.Forms.CheckBox chkFile;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.RichTextBox txtError;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.RichTextBox txtOutput;
    }
}