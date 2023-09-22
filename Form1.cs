using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Diagnostics;
using System.Linq;

namespace App_StreamDeck
{
    public partial class Form1 : Form
    {
        picture unepic;
        List<picture> imgdivise = new List<picture>();

        int sizeButtonDeck;
        int nbVerticalButton;
        int nbHorizontalButton;
        int ecartButton;

        int nouvelleLargeur;
        int nouvelleHauteur;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtboxhauteur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtboxLargeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tous les fichiers|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string cheminImage = openFileDialog.FileName;


                Image image = Image.FromFile(cheminImage);


                txtboxhauteur.Text = image.Height.ToString();
                txtboxLargeur.Text = image.Width.ToString();
                pictureBox.Image = image;
                unepic = new picture(image, image.Width, image.Height);



                MessageBox.Show("L'image est trop grande");

            }
        }

        private void btnredimension_Click(object sender, EventArgs e)
        {
            {

                nouvelleLargeur = nbHorizontalButton * sizeButtonDeck + (nbHorizontalButton - 1) * ecartButton;
                nouvelleHauteur = nbVerticalButton * sizeButtonDeck + (nbVerticalButton - 1) * ecartButton;
                unepic.Resize(nouvelleLargeur, nouvelleHauteur);

                //if (checkBoxSize.Checked)
                //{

                //    int nouvelleLargeurCalculee = (int)((double)nouvelleHauteur / unepic.Hauteur * unepic.Largeur);
                //    unepic.Resize(nouvelleLargeurCalculee, nouvelleHauteur);
                //    txtboxLargeur.Text = nouvelleLargeurCalculee.ToString();

                //    int nouvelleHauteurCalculee = (int)((double)nouvelleLargeur / unepic.Largeur * unepic.Hauteur);
                //    unepic.Resize(nouvelleLargeur, nouvelleHauteurCalculee);
                //    txtboxhauteur.Text = nouvelleHauteurCalculee.ToString();
                //}
                //if (checkbox360.Checked)
                //{

                //    unepic.Resize(nouvelleLargeur, nouvelleHauteur);
                //}

                pictureBox.Image = unepic.image;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            // Vérifiez si une image est chargée
            if (unepic != null && unepic.image != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                // Configurez le SaveFileDialog
                saveFileDialog1.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                saveFileDialog1.Title = "Enregistrer l'image";
                saveFileDialog1.FileName = "image"; // Nom de fichier par défaut

                // Affichez la boîte de dialogue pour sélectionner l'emplacement de sauvegarde
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Obtenez le chemin du fichier de sauvegarde à partir du SaveFileDialog
                    string cheminSauvegarde = saveFileDialog1.FileName;

                    // Enregistrez l'image dans le chemin spécifié
                    unepic.image.Save(cheminSauvegarde);

                    // Affichez un message de confirmation
                    MessageBox.Show("L'image a été enregistrée avec succès !");
                }
            }
            else
            {
                MessageBox.Show("Aucune image chargée pour enregistrement.");
            }
        }

        private void btndivise_Click_1(object sender, EventArgs e)
        {

            imgdivise.Clear();
            if (unepic != null && unepic.image != null)
            {
                Bitmap imageOriginale = new Bitmap(unepic.image);

                for (int y = 0; y + sizeButtonDeck < imageOriginale.Height; y += sizeButtonDeck)
                {
                    for (int x = 0; x + sizeButtonDeck < imageOriginale.Width; x += sizeButtonDeck)
                    {
                        Rectangle rect = new Rectangle(x + ecartButton, y + ecartButton, sizeButtonDeck, sizeButtonDeck);
                        Bitmap segment = new Bitmap(imageOriginale.Clone(rect, imageOriginale.PixelFormat));
                        picture segmentPicture = new picture(segment, sizeButtonDeck, sizeButtonDeck);
                        imgdivise.Add(segmentPicture);
                    }
                }

                MessageBox.Show("L'image a été divisée en " + imgdivise.Count + " segments de 72x72 pixels.");
            }
        }

        private void btnafficher_Click(object sender, EventArgs e)
        {

        }

        private void btnenregsitrerdivise_Click(object sender, EventArgs e)
        {
            int sizeButtonDeck = 72;
            // Créez une instance du dialogue de sélection de dossier
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Définissez le titre du dialogue
            folderBrowserDialog.Description = "Sélectionnez un dossier";

            // Affichez la boîte de dialogue et vérifiez si l'utilisateur a appuyé sur OK
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtenez le chemin du dossier sélectionné par l'utilisateur
                string selectedFolderPath = folderBrowserDialog.SelectedPath;

                // Parcourez la boucle for en utilisant la variable i pour nommer les fichiers
                for (int i = 0; i < imgdivise.Count; i++)
                {

                    // Construisez le chemin complet du fichier de destination dans le dossier sélectionné
                    string destinationFilePath = Path.Combine(selectedFolderPath, i + 1 + ".png");

                    Bitmap imageRedimensionnee = new Bitmap(imgdivise[i].image, sizeButtonDeck, sizeButtonDeck);
                    imageRedimensionnee.Save(destinationFilePath);
                }
            }


            //foreach (var item in imgdivise)
            //{
            //    if (item != null && item.image != null)
            //    {
            //        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //        saveFileDialog1.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            //        saveFileDialog1.Title = "Enregistrer l'image";
            //        saveFileDialog1.FileName = "image";
            //        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //        {
            //            string cheminSauvegarde = saveFileDialog1.FileName;
            //            Bitmap imageRedimensionnee = new Bitmap(item.image, 72, 72);
            //            imageRedimensionnee.Save(cheminSauvegarde);

            //        }
            //    }
            //}

        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void checkbox360_CheckedChanged(object sender, EventArgs e)
        {
            if (unepic is not null)
            {
                if (checkbox360.Checked)
                {
                    txtboxLargeur.Text = 360.ToString();
                    txtboxhauteur.Text = 216.ToString();
                }
                else
                {
                    txtboxhauteur.Text = unepic.Hauteur.ToString();
                    txtboxLargeur.Text = unepic.Largeur.ToString();
                }
            }
        }

        private void numericnbVerticalButton_ValueChanged(object sender, EventArgs e)
        {
            nbVerticalButton = (int)numericnbVerticalButton.Value;
        }

        private void numericnbHorizontalButton_ValueChanged(object sender, EventArgs e)
        {
            nbHorizontalButton = (int)numericnbHorizontalButton.Value;
        }

        private void numericEcart_ValueChanged(object sender, EventArgs e)
        {
            ecartButton = (int)numericEcart.Value;
        }

        private void numericSizeBtn_ValueChanged(object sender, EventArgs e)
        {
            sizeButtonDeck = (int)numericSizeBtn.Value;
        }
    }
}




