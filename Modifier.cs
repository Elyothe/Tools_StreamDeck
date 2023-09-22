using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace App_StreamDeck
{
    public partial class Modifier : Form
    {
        picture unepic;
        public Modifier()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // Créez une instance de OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Définissez les filtres de fichiers pour permettre à l'utilisateur de sélectionner des images
            openFileDialog.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tous les fichiers|*.*";

            // Si l'utilisateur sélectionne un fichier image et clique sur OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtenez le chemin du fichier sélectionné
                string cheminImage = openFileDialog.FileName;

                // Chargez l'image dans un objet Image
                Image image = Image.FromFile(cheminImage);
                txtboxhauteur.Text = image.Height.ToString();
                txtboxLargeur.Text = image.Width.ToString();
                pictureBox.Image = image;
                unepic = new picture(image, image.Width, image.Height);

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
        }

        private void btnredimension_Click(object sender, EventArgs e)
        {
            {
                // Convertir le contenu de txtboxLargeur.Text et txtboxhauteur.Text en entiers
                int nouvelleLargeur = Convert.ToInt32(txtboxLargeur.Text);
                int nouvelleHauteur = Convert.ToInt32(txtboxhauteur.Text);


                if (checkBoxSize.Checked)
                {
                    // Si la case à cocher est cochée, ajustez également la largeur en fonction de la hauteur
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



                // Afficher l'image redimensionnée dans le pictureBox
                pictureBox.Image = unepic.image;
            }
        }

    }
}

