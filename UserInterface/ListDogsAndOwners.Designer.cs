namespace UserInterface
{
    partial class ListDogsAndOwners
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstboxOwners = new System.Windows.Forms.ListBox();
            this.lstboxDogs = new System.Windows.Forms.ListBox();
            this.lblOwners = new System.Windows.Forms.Label();
            this.lblDogs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(240, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(490, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ver Perros y Dueños";
            // 
            // lstboxOwners
            // 
            this.lstboxOwners.FormattingEnabled = true;
            this.lstboxOwners.ItemHeight = 25;
            this.lstboxOwners.Location = new System.Drawing.Point(209, 220);
            this.lstboxOwners.Name = "lstboxOwners";
            this.lstboxOwners.Size = new System.Drawing.Size(246, 304);
            this.lstboxOwners.TabIndex = 1;
            this.lstboxOwners.SelectedValueChanged += new System.EventHandler(this.lstboxOwners_SelectedValueChanged);
            // 
            // lstboxDogs
            // 
            this.lstboxDogs.FormattingEnabled = true;
            this.lstboxDogs.ItemHeight = 25;
            this.lstboxDogs.Location = new System.Drawing.Point(514, 220);
            this.lstboxDogs.Name = "lstboxDogs";
            this.lstboxDogs.Size = new System.Drawing.Size(422, 304);
            this.lstboxDogs.TabIndex = 2;
            // 
            // lblOwners
            // 
            this.lblOwners.AutoSize = true;
            this.lblOwners.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwners.Location = new System.Drawing.Point(264, 158);
            this.lblOwners.Name = "lblOwners";
            this.lblOwners.Size = new System.Drawing.Size(127, 37);
            this.lblOwners.TabIndex = 3;
            this.lblOwners.Text = "Dueños";
            // 
            // lblDogs
            // 
            this.lblDogs.AutoSize = true;
            this.lblDogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogs.Location = new System.Drawing.Point(653, 158);
            this.lblDogs.Name = "lblDogs";
            this.lblDogs.Size = new System.Drawing.Size(111, 37);
            this.lblDogs.TabIndex = 4;
            this.lblDogs.Text = "Perros";
            this.lblDogs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ListDogsAndOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDogs);
            this.Controls.Add(this.lblOwners);
            this.Controls.Add(this.lstboxDogs);
            this.Controls.Add(this.lstboxOwners);
            this.Controls.Add(this.lblTitle);
            this.Name = "ListDogsAndOwners";
            this.Size = new System.Drawing.Size(1084, 790);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstboxOwners;
        private System.Windows.Forms.ListBox lstboxDogs;
        private System.Windows.Forms.Label lblOwners;
        private System.Windows.Forms.Label lblDogs;
    }
}
