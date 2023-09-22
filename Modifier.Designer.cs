namespace App_StreamDeck
{
    partial class Modifier
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
            checkbox360 = new CheckBox();
            btnEnregistrer = new Button();
            checkBoxSize = new CheckBox();
            btnredimension = new Button();
            txthauteur = new Label();
            txtlargeur = new Label();
            txtboxLargeur = new TextBox();
            txtboxhauteur = new TextBox();
            debug = new Label();
            pictureBox = new PictureBox();
            btnImport = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // checkbox360
            // 
            checkbox360.AutoSize = true;
            checkbox360.Location = new Point(69, 382);
            checkbox360.Margin = new Padding(3, 2, 3, 2);
            checkbox360.Name = "checkbox360";
            checkbox360.Size = new Size(67, 19);
            checkbox360.TabIndex = 27;
            checkbox360.Text = "360/216";
            checkbox360.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Location = new Point(627, 168);
            btnEnregistrer.Margin = new Padding(3, 2, 3, 2);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(82, 22);
            btnEnregistrer.TabIndex = 24;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // checkBoxSize
            // 
            checkBoxSize.AutoSize = true;
            checkBoxSize.Location = new Point(149, 382);
            checkBoxSize.Margin = new Padding(3, 2, 3, 2);
            checkBoxSize.Name = "checkBoxSize";
            checkBoxSize.Size = new Size(51, 19);
            checkBoxSize.TabIndex = 23;
            checkBoxSize.Text = "Lock";
            checkBoxSize.UseVisualStyleBackColor = true;
            // 
            // btnredimension
            // 
            btnredimension.Location = new Point(214, 336);
            btnredimension.Margin = new Padding(3, 2, 3, 2);
            btnredimension.Name = "btnredimension";
            btnredimension.Size = new Size(117, 22);
            btnredimension.TabIndex = 22;
            btnredimension.Text = "Redimensionner";
            btnredimension.UseVisualStyleBackColor = true;
            btnredimension.Click += btnredimension_Click;
            // 
            // txthauteur
            // 
            txthauteur.AutoSize = true;
            txthauteur.Location = new Point(55, 353);
            txthauteur.Name = "txthauteur";
            txthauteur.Size = new Size(50, 15);
            txthauteur.TabIndex = 21;
            txthauteur.Text = "Hauteur";
            // 
            // txtlargeur
            // 
            txtlargeur.AutoSize = true;
            txtlargeur.Location = new Point(55, 317);
            txtlargeur.Name = "txtlargeur";
            txtlargeur.Size = new Size(47, 15);
            txtlargeur.TabIndex = 20;
            txtlargeur.Text = "Largeur";
            // 
            // txtboxLargeur
            // 
            txtboxLargeur.Location = new Point(127, 315);
            txtboxLargeur.Margin = new Padding(3, 2, 3, 2);
            txtboxLargeur.Name = "txtboxLargeur";
            txtboxLargeur.Size = new Size(61, 23);
            txtboxLargeur.TabIndex = 19;
            // 
            // txtboxhauteur
            // 
            txtboxhauteur.Location = new Point(127, 351);
            txtboxhauteur.Margin = new Padding(3, 2, 3, 2);
            txtboxhauteur.Name = "txtboxhauteur";
            txtboxhauteur.Size = new Size(61, 23);
            txtboxhauteur.TabIndex = 18;
            // 
            // debug
            // 
            debug.AutoSize = true;
            debug.Location = new Point(112, 96);
            debug.Name = "debug";
            debug.Size = new Size(0, 15);
            debug.TabIndex = 17;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(190, 57);
            pictureBox.Margin = new Padding(3, 2, 3, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(360, 216);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 16;
            pictureBox.TabStop = false;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(627, 122);
            btnImport.Margin = new Padding(3, 2, 3, 2);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(82, 22);
            btnImport.TabIndex = 15;
            btnImport.Text = "Importer";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // Modifier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkbox360);
            Controls.Add(btnEnregistrer);
            Controls.Add(checkBoxSize);
            Controls.Add(btnredimension);
            Controls.Add(txthauteur);
            Controls.Add(txtlargeur);
            Controls.Add(txtboxLargeur);
            Controls.Add(txtboxhauteur);
            Controls.Add(debug);
            Controls.Add(pictureBox);
            Controls.Add(btnImport);
            Name = "Modifier";
            Text = "Modifier";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkbox360;
        private Button btnEnregistrer;
        private CheckBox checkBoxSize;
        private Button btnredimension;
        private Label txthauteur;
        private Label txtlargeur;
        private TextBox txtboxLargeur;
        private TextBox txtboxhauteur;
        private Label debug;
        private PictureBox pictureBox;
        private Button btnImport;
    }
}