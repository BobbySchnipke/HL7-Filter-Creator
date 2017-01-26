namespace Results_Filter_Creator
{
    partial class FilterText
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
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Location = new System.Drawing.Point(113, 81);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(403, 13);
            this.InstructionsLabel.TabIndex = 0;
            this.InstructionsLabel.Text = "Copy the text in the box below and paste it into the \"Edit Rule\" section of Verin" +
    "ovum";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(116, 131);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(400, 263);
            this.filterTextBox.TabIndex = 1;
            this.filterTextBox.Text = "";
            // 
            // FilterText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 478);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.InstructionsLabel);
            this.Name = "FilterText";
            this.Text = "FilterText";
            this.Load += new System.EventHandler(this.FilterText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.RichTextBox filterTextBox;
    }
}