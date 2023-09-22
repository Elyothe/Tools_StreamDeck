namespace App_StreamDeck
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnImport = new Button();
            pictureBox = new PictureBox();
            debug = new Label();
            txtboxhauteur = new TextBox();
            txtboxLargeur = new TextBox();
            txtlargeur = new Label();
            txthauteur = new Label();
            btnredimension = new Button();
            checkBoxSize = new CheckBox();
            btnEnregistrer = new Button();
            btnFractionner = new Button();
            btnenregsitrerdivise = new Button();
            checkbox360 = new CheckBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            touchesToolStripMenuItem = new ToolStripMenuItem();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnImport
            // 
            btnImport.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImport.Location = new Point(545, 392);
            btnImport.Margin = new Padding(3, 2, 3, 2);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(106, 69);
            btnImport.TabIndex = 0;
            btnImport.Text = "Importer";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Location = new Point(142, 39);
            pictureBox.Margin = new Padding(3, 2, 3, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(360, 216);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // debug
            // 
            debug.AutoSize = true;
            debug.Location = new Point(321, 96);
            debug.Name = "debug";
            debug.Size = new Size(0, 15);
            debug.TabIndex = 2;
            // 
            // txtboxhauteur
            // 
            txtboxhauteur.Location = new Point(272, 313);
            txtboxhauteur.Margin = new Padding(3, 2, 3, 2);
            txtboxhauteur.Name = "txtboxhauteur";
            txtboxhauteur.Size = new Size(61, 23);
            txtboxhauteur.TabIndex = 3;
            txtboxhauteur.KeyPress += txtboxhauteur_KeyPress;
            // 
            // txtboxLargeur
            // 
            txtboxLargeur.Location = new Point(272, 365);
            txtboxLargeur.Margin = new Padding(3, 2, 3, 2);
            txtboxLargeur.Name = "txtboxLargeur";
            txtboxLargeur.Size = new Size(61, 23);
            txtboxLargeur.TabIndex = 4;
            txtboxLargeur.KeyPress += txtboxLargeur_KeyPress;
            // 
            // txtlargeur
            // 
            txtlargeur.AutoSize = true;
            txtlargeur.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtlargeur.ForeColor = Color.FromArgb(148, 155, 154);
            txtlargeur.Location = new Point(213, 368);
            txtlargeur.Name = "txtlargeur";
            txtlargeur.Size = new Size(52, 16);
            txtlargeur.TabIndex = 5;
            txtlargeur.Text = "Largeur";
            // 
            // txthauteur
            // 
            txthauteur.AutoSize = true;
            txthauteur.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txthauteur.ForeColor = Color.FromArgb(148, 155, 154);
            txthauteur.Location = new Point(216, 316);
            txthauteur.Name = "txthauteur";
            txthauteur.Size = new Size(54, 16);
            txthauteur.TabIndex = 6;
            txthauteur.Text = "Hauteur";
            // 
            // btnredimension
            // 
            btnredimension.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnredimension.Location = new Point(211, 479);
            btnredimension.Margin = new Padding(3, 2, 3, 2);
            btnredimension.Name = "btnredimension";
            btnredimension.Size = new Size(122, 67);
            btnredimension.TabIndex = 7;
            btnredimension.Text = "Redimensionner";
            btnredimension.UseVisualStyleBackColor = true;
            btnredimension.Click += btnredimension_Click;
            // 
            // checkBoxSize
            // 
            checkBoxSize.AutoSize = true;
            checkBoxSize.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxSize.ForeColor = Color.FromArgb(148, 155, 154);
            checkBoxSize.Location = new Point(356, 316);
            checkBoxSize.Margin = new Padding(3, 2, 3, 2);
            checkBoxSize.Name = "checkBoxSize";
            checkBoxSize.Size = new Size(51, 20);
            checkBoxSize.TabIndex = 8;
            checkBoxSize.Text = "Lock";
            checkBoxSize.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnregistrer.Location = new Point(356, 479);
            btnEnregistrer.Margin = new Padding(3, 2, 3, 2);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(116, 67);
            btnEnregistrer.TabIndex = 9;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // btnFractionner
            // 
            btnFractionner.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFractionner.Location = new Point(32, 492);
            btnFractionner.Margin = new Padding(3, 2, 3, 2);
            btnFractionner.Name = "btnFractionner";
            btnFractionner.Size = new Size(98, 38);
            btnFractionner.TabIndex = 10;
            btnFractionner.Text = "Fractionner";
            btnFractionner.UseVisualStyleBackColor = true;
            btnFractionner.Click += btndivise_Click_1;
            // 
            // btnenregsitrerdivise
            // 
            btnenregsitrerdivise.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnenregsitrerdivise.Location = new Point(545, 476);
            btnenregsitrerdivise.Margin = new Padding(3, 2, 3, 2);
            btnenregsitrerdivise.Name = "btnenregsitrerdivise";
            btnenregsitrerdivise.Size = new Size(106, 70);
            btnenregsitrerdivise.TabIndex = 13;
            btnenregsitrerdivise.Text = "Exporter";
            btnenregsitrerdivise.UseVisualStyleBackColor = true;
            btnenregsitrerdivise.Click += btnenregsitrerdivise_Click;
            // 
            // checkbox360
            // 
            checkbox360.AutoSize = true;
            checkbox360.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkbox360.ForeColor = Color.FromArgb(148, 155, 154);
            checkbox360.Location = new Point(428, 316);
            checkbox360.Margin = new Padding(3, 2, 3, 2);
            checkbox360.Name = "checkbox360";
            checkbox360.Size = new Size(74, 20);
            checkbox360.TabIndex = 14;
            checkbox360.Text = "360/216";
            checkbox360.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, modifierToolStripMenuItem, touchesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(663, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            fichierToolStripMenuItem.Click += fichierToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(111, 22);
            toolStripMenuItem1.Text = "Quitter";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(64, 20);
            modifierToolStripMenuItem.Text = "Modifier";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(119, 22);
            toolStripMenuItem2.Text = "modifier";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // touchesToolStripMenuItem
            // 
            touchesToolStripMenuItem.Name = "touchesToolStripMenuItem";
            touchesToolStripMenuItem.Size = new Size(77, 20);
            touchesToolStripMenuItem.Text = "15 Touches";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(148, 155, 154);
            checkBox1.Location = new Point(32, 379);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 20);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "6 Touches";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.FromArgb(148, 155, 154);
            checkBox2.Location = new Point(32, 417);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(91, 20);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "15 Touches";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.ForeColor = Color.FromArgb(148, 155, 154);
            checkBox3.Location = new Point(32, 455);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(91, 20);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "30 Touches";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 48, 53);
            ClientSize = new Size(663, 566);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(menuStrip1);
            Controls.Add(checkbox360);
            Controls.Add(btnenregsitrerdivise);
            Controls.Add(btnFractionner);
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
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImport;
        private PictureBox pictureBox;
        private Label debug;
        private TextBox txtboxhauteur;
        private TextBox txtboxLargeur;
        private Label txtlargeur;
        private Label txthauteur;
        private Button btnredimension;
        private CheckBox checkBoxSize;
        private Button btnEnregistrer;
        private Button btnFractionner;
        private Button btnenregsitrerdivise;
        private CheckBox checkbox360;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem touchesToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}