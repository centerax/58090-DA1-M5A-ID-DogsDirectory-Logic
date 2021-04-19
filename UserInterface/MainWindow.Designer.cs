namespace UserInterface
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddDogOwner = new System.Windows.Forms.Button();
            this.btnAddDog = new System.Windows.Forms.Button();
            this.btnListDirectory = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(28, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1109, 77);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bienvenidos al Directorio de Perros";
            // 
            // btnAddDogOwner
            // 
            this.btnAddDogOwner.Location = new System.Drawing.Point(41, 373);
            this.btnAddDogOwner.Name = "btnAddDogOwner";
            this.btnAddDogOwner.Size = new System.Drawing.Size(247, 75);
            this.btnAddDogOwner.TabIndex = 1;
            this.btnAddDogOwner.Text = "Agregar Dueño";
            this.btnAddDogOwner.UseVisualStyleBackColor = true;
            this.btnAddDogOwner.Click += new System.EventHandler(this.btnAddDogOwner_Click);
            // 
            // btnAddDog
            // 
            this.btnAddDog.Location = new System.Drawing.Point(41, 498);
            this.btnAddDog.Name = "btnAddDog";
            this.btnAddDog.Size = new System.Drawing.Size(247, 75);
            this.btnAddDog.TabIndex = 2;
            this.btnAddDog.Text = "Agregar Perro";
            this.btnAddDog.UseVisualStyleBackColor = true;
            this.btnAddDog.Click += new System.EventHandler(this.btnAddDog_Click);
            // 
            // btnListDirectory
            // 
            this.btnListDirectory.Location = new System.Drawing.Point(41, 620);
            this.btnListDirectory.Name = "btnListDirectory";
            this.btnListDirectory.Size = new System.Drawing.Size(247, 75);
            this.btnListDirectory.TabIndex = 3;
            this.btnListDirectory.Text = "Ver perros y dueños";
            this.btnListDirectory.UseVisualStyleBackColor = true;
            this.btnListDirectory.Click += new System.EventHandler(this.btnListDirectory_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(339, 168);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1084, 790);
            this.pnlMain.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 999);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnListDirectory);
            this.Controls.Add(this.btnAddDog);
            this.Controls.Add(this.btnAddDogOwner);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directorio de perros - Ventana principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddDogOwner;
        private System.Windows.Forms.Button btnAddDog;
        private System.Windows.Forms.Button btnListDirectory;
        private System.Windows.Forms.Panel pnlMain;
    }
}

