namespace Results_Filter_Creator
{
    partial class InputForm
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
            this.AllowBlockComboBox = new System.Windows.Forms.ComboBox();
            this.ResultTypeComboBox = new System.Windows.Forms.ComboBox();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.PV1ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateFilterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllowBlockComboBox
            // 
            this.AllowBlockComboBox.FormattingEnabled = true;
            this.AllowBlockComboBox.Items.AddRange(new object[] {
            "Allow",
            "Block"});
            this.AllowBlockComboBox.Location = new System.Drawing.Point(17, 118);
            this.AllowBlockComboBox.Name = "AllowBlockComboBox";
            this.AllowBlockComboBox.Size = new System.Drawing.Size(121, 21);
            this.AllowBlockComboBox.TabIndex = 0;
            // 
            // ResultTypeComboBox
            // 
            this.ResultTypeComboBox.FormattingEnabled = true;
            this.ResultTypeComboBox.Items.AddRange(new object[] {
            "ADTs",
            "LABs",
            "RADs"});
            this.ResultTypeComboBox.Location = new System.Drawing.Point(302, 118);
            this.ResultTypeComboBox.Name = "ResultTypeComboBox";
            this.ResultTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ResultTypeComboBox.TabIndex = 1;
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "All Locations",
            "Quest Diagnostics Labaratory",
            "Mercy",
            "Trihealth",
            "Labcorps",
            "Children\'s Hospital"});
            this.LocationComboBox.Location = new System.Drawing.Point(496, 118);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(121, 21);
            this.LocationComboBox.TabIndex = 2;
            // 
            // PV1ComboBox
            // 
            this.PV1ComboBox.FormattingEnabled = true;
            this.PV1ComboBox.Items.AddRange(new object[] {
            "Inpatient",
            "Outpatient",
            "Preadmit",
            "Recurring patient",
            "Obstetrics",
            "Unknown"});
            this.PV1ComboBox.Location = new System.Drawing.Point(158, 118);
            this.PV1ComboBox.Name = "PV1ComboBox";
            this.PV1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.PV1ComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // CreateFilterButton
            // 
            this.CreateFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateFilterButton.Location = new System.Drawing.Point(246, 504);
            this.CreateFilterButton.Name = "CreateFilterButton";
            this.CreateFilterButton.Size = new System.Drawing.Size(142, 52);
            this.CreateFilterButton.TabIndex = 6;
            this.CreateFilterButton.Text = "Create Filter";
            this.CreateFilterButton.UseVisualStyleBackColor = true;
            this.CreateFilterButton.Click += new System.EventHandler(this.CreateFilterButton_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.CreateFilterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PV1ComboBox);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.ResultTypeComboBox);
            this.Controls.Add(this.AllowBlockComboBox);
            this.Name = "InputForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AllowBlockComboBox;
        private System.Windows.Forms.ComboBox ResultTypeComboBox;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.ComboBox PV1ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateFilterButton;
    }
}

