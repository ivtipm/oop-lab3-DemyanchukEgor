namespace ChatBot
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.OKButton = new System.Windows.Forms.Button();
            this.HelpText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.Info;
            this.OKButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OKButton.Location = new System.Drawing.Point(174, 230);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            this.OKButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OKButton_KeyDown);
            // 
            // HelpText
            // 
            this.HelpText.BackColor = System.Drawing.SystemColors.Info;
            this.HelpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HelpText.Location = new System.Drawing.Point(12, 9);
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(406, 218);
            this.HelpText.TabIndex = 1;
            this.HelpText.Text = resources.GetString("HelpText.Text");
            this.HelpText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HelpText.Click += new System.EventHandler(this.HelpText_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 274);
            this.Controls.Add(this.HelpText);
            this.Controls.Add(this.OKButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.Text = "Справка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HelpForm_FormClosed);
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label HelpText;
    }
}