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
            numericnbVerticalButton = new NumericUpDown();
            numericnbHorizontalButton = new NumericUpDown();
            numericSizeBtn = new NumericUpDown();
            numericEcart = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericnbVerticalButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericnbHorizontalButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSizeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericEcart).BeginInit();
            SuspendLayout();
            // 
            // btnImport
            // 
            btnImport.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImport.Location = new Point(623, 523);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(121, 92);
            btnImport.TabIndex = 0;
            btnImport.Text = "Importer";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Location = new Point(162, 52);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(411, 287);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // debug
            // 
            debug.AutoSize = true;
            debug.Location = new Point(367, 128);
            debug.Name = "debug";
            debug.Size = new Size(0, 20);
            debug.TabIndex = 2;
            // 
            // txtboxhauteur
            // 
            txtboxhauteur.Location = new Point(537, 378);
            txtboxhauteur.Name = "txtboxhauteur";
            txtboxhauteur.Size = new Size(69, 27);
            txtboxhauteur.TabIndex = 3;
            txtboxhauteur.KeyPress += txtboxhauteur_KeyPress;
            // 
            // txtboxLargeur
            // 
            txtboxLargeur.Location = new Point(537, 448);
            txtboxLargeur.Name = "txtboxLargeur";
            txtboxLargeur.Size = new Size(69, 27);
            txtboxLargeur.TabIndex = 4;
            txtboxLargeur.KeyPress += txtboxLargeur_KeyPress;
            // 
            // txtlargeur
            // 
            txtlargeur.AutoSize = true;
            txtlargeur.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtlargeur.ForeColor = Color.FromArgb(148, 155, 154);
            txtlargeur.Location = new Point(469, 452);
            txtlargeur.Name = "txtlargeur";
            txtlargeur.Size = new Size(64, 21);
            txtlargeur.TabIndex = 5;
            txtlargeur.Text = "Largeur";
            // 
            // txthauteur
            // 
            txthauteur.AutoSize = true;
            txthauteur.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txthauteur.ForeColor = Color.FromArgb(148, 155, 154);
            txthauteur.Location = new Point(463, 382);
            txthauteur.Name = "txthauteur";
            txthauteur.Size = new Size(68, 21);
            txthauteur.TabIndex = 6;
            txthauteur.Text = "Hauteur";
            // 
            // btnredimension
            // 
            btnredimension.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnredimension.Location = new Point(241, 639);
            btnredimension.Name = "btnredimension";
            btnredimension.Size = new Size(139, 89);
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
            checkBoxSize.Location = new Point(633, 382);
            checkBoxSize.Name = "checkBoxSize";
            checkBoxSize.Size = new Size(64, 25);
            checkBoxSize.TabIndex = 8;
            checkBoxSize.Text = "Lock";
            checkBoxSize.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnregistrer.Location = new Point(407, 639);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(133, 89);
            btnEnregistrer.TabIndex = 9;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // btnFractionner
            // 
            btnFractionner.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFractionner.Location = new Point(37, 656);
            btnFractionner.Name = "btnFractionner";
            btnFractionner.Size = new Size(112, 51);
            btnFractionner.TabIndex = 10;
            btnFractionner.Text = "Fractionner";
            btnFractionner.UseVisualStyleBackColor = true;
            btnFractionner.Click += btndivise_Click_1;
            // 
            // btnenregsitrerdivise
            // 
            btnenregsitrerdivise.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnenregsitrerdivise.Location = new Point(623, 635);
            btnenregsitrerdivise.Name = "btnenregsitrerdivise";
            btnenregsitrerdivise.Size = new Size(121, 93);
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
            checkbox360.Location = new Point(633, 448);
            checkbox360.Name = "checkbox360";
            checkbox360.Size = new Size(94, 25);
            checkbox360.TabIndex = 14;
            checkbox360.Text = "360/216";
            checkbox360.UseVisualStyleBackColor = true;
            checkbox360.CheckedChanged += checkbox360_CheckedChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, modifierToolStripMenuItem, touchesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(758, 30);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(66, 24);
            fichierToolStripMenuItem.Text = "Fichier";
            fichierToolStripMenuItem.Click += fichierToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(138, 26);
            toolStripMenuItem1.Text = "Quitter";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(80, 24);
            modifierToolStripMenuItem.Text = "Modifier";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(149, 26);
            toolStripMenuItem2.Text = "modifier";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // touchesToolStripMenuItem
            // 
            touchesToolStripMenuItem.Name = "touchesToolStripMenuItem";
            touchesToolStripMenuItem.Size = new Size(96, 24);
            touchesToolStripMenuItem.Text = "15 Touches";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(148, 155, 154);
            checkBox1.Location = new Point(37, 505);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 25);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "6 Touches";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.FromArgb(148, 155, 154);
            checkBox2.Location = new Point(37, 556);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(115, 25);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "15 Touches";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.ForeColor = Color.FromArgb(148, 155, 154);
            checkBox3.Location = new Point(37, 607);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(115, 25);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "30 Touches";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // numericnbVerticalButton
            // 
            numericnbVerticalButton.Location = new Point(119, 384);
            numericnbVerticalButton.Name = "numericnbVerticalButton";
            numericnbVerticalButton.Size = new Size(67, 27);
            numericnbVerticalButton.TabIndex = 21;
            numericnbVerticalButton.ValueChanged += numericnbVerticalButton_ValueChanged;
            // 
            // numericnbHorizontalButton
            // 
            numericnbHorizontalButton.Location = new Point(119, 420);
            numericnbHorizontalButton.Name = "numericnbHorizontalButton";
            numericnbHorizontalButton.Size = new Size(67, 27);
            numericnbHorizontalButton.TabIndex = 22;
            numericnbHorizontalButton.ValueChanged += numericnbHorizontalButton_ValueChanged;
            // 
            // numericSizeBtn
            // 
            numericSizeBtn.Location = new Point(336, 420);
            numericSizeBtn.Name = "numericSizeBtn";
            numericSizeBtn.Size = new Size(67, 27);
            numericSizeBtn.TabIndex = 24;
            numericSizeBtn.ValueChanged += numericSizeBtn_ValueChanged;
            // 
            // numericEcart
            // 
            numericEcart.Location = new Point(336, 384);
            numericEcart.Name = "numericEcart";
            numericEcart.Size = new Size(67, 27);
            numericEcart.TabIndex = 23;
            numericEcart.ValueChanged += numericEcart_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(148, 155, 154);
            label1.Location = new Point(281, 390);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 25;
            label1.Text = "Ecart";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(148, 155, 154);
            label2.Location = new Point(269, 426);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 26;
            label2.Text = "sizeBtn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(148, 155, 154);
            label3.Location = new Point(37, 426);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 27;
            label3.Text = "nbBtnH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(148, 155, 154);
            label4.Location = new Point(37, 390);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 28;
            label4.Text = "nbBtnV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 48, 53);
            ClientSize = new Size(758, 755);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericSizeBtn);
            Controls.Add(numericEcart);
            Controls.Add(numericnbHorizontalButton);
            Controls.Add(numericnbVerticalButton);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericnbVerticalButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericnbHorizontalButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSizeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericEcart).EndInit();
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
        private NumericUpDown numericnbVerticalButton;
        private NumericUpDown numericnbHorizontalButton;
        private NumericUpDown numericSizeBtn;
        private NumericUpDown numericEcart;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}