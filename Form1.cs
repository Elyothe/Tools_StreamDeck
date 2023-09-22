using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Diagnostics;

namespace App_StreamDeck
{
    public partial class Form1 : Form
    {
        picture unepic;
        List<picture> imgdivise = new List<picture>();
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
                
                int nouvelleLargeur = Convert.ToInt32(txtboxLargeur.Text);
                int nouvelleHauteur = Convert.ToInt32(txtboxhauteur.Text);


                if (checkBoxSize.Checked)
                {
                    
                    int nouvelleLargeurCalculee = (int)((double)nouvelleHauteur / unepic.Hauteur * unepic.Largeur);
                    unepic.Resize(nouvelleLargeurCalculee, nouvelleHauteur);
                    txtboxLargeur.Text = nouvelleLargeurCalculee.ToString();

                    int nouvelleHauteurCalculee = (int)((double)nouvelleLargeur / unepic.Largeur * unepic.Hauteur);
                    unepic.Resize(nouvelleLargeur, nouvelleHauteurCalculee);
                    txtboxhauteur.Text = nouvelleHauteurCalculee.ToString();
                }
                if (checkbox360.Checked)
                {

                    unepic.Resize(nouvelleLargeur, nouvelleHauteur);
                }

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
                int largeurSegment = 72;
                int hauteurSegment = 72;
                Bitmap imageOriginale = new Bitmap(unepic.image);

                for (int y = 0; y < imageOriginale.Height; y += hauteurSegment)
                {
                    for (int x = 0; x < imageOriginale.Width; x += largeurSegment)
                    {
                        Rectangle rect = new Rectangle(x, y, largeurSegment, hauteurSegment);
                        Bitmap segment = new Bitmap(imageOriginale.Clone(rect, imageOriginale.PixelFormat));
                        picture segmentPicture = new picture(segment, largeurSegment, hauteurSegment);
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
            foreach (var item in imgdivise)
            {
                if (item != null && item.image != null)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    saveFileDialog1.Title = "Enregistrer l'image";
                    saveFileDialog1.FileName = "image";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string cheminSauvegarde = saveFileDialog1.FileName;
                        Bitmap imageRedimensionnee = new Bitmap(item.image, 72, 72);
                        imageRedimensionnee.Save(cheminSauvegarde);
                        
                    }
                }
            }

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
    }
}




