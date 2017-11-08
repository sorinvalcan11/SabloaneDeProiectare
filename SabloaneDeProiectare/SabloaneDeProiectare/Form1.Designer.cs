namespace SabloaneDeProiectare
{
    partial class Form1
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
            this.documentStatVisitorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // documentStatVisitorButton
            // 
            this.documentStatVisitorButton.Location = new System.Drawing.Point(11, 37);
            this.documentStatVisitorButton.Name = "documentStatVisitorButton";
            this.documentStatVisitorButton.Size = new System.Drawing.Size(192, 35);
            this.documentStatVisitorButton.TabIndex = 0;
            this.documentStatVisitorButton.Text = "Document Stat Visitor";
            this.documentStatVisitorButton.UseVisualStyleBackColor = true;
            this.documentStatVisitorButton.Click += new System.EventHandler(this.documentStatVisitorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 355);
            this.Controls.Add(this.documentStatVisitorButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button documentStatVisitorButton;
    }
}

