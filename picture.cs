using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace App_StreamDeck
{

    internal class picture
    {
        public Image image;
        public int Largeur;
        public int Hauteur;
        List<picture> imgdivise = new List<picture>();


        public picture(Image uneimage, int unelargeur, int unehauteur)
        {
            image = uneimage;
            Largeur = unelargeur;
            Hauteur = unehauteur;
        }

        public int getLargeur()
        {
            return Largeur;
        }

        public int getHauteur()
        {
            return Hauteur;
        }
        

        // Ajouter une méthode pour redimensionner l'image
        public void Resize(int nouvelleLargeur, int nouvelleHauteur)
        {
            try
            {
                image = new Bitmap(image, nouvelleLargeur, nouvelleHauteur);
                Largeur = nouvelleLargeur;
                Hauteur = nouvelleHauteur;
            }catch(Exception e)
            {
                Console.WriteLine("Erreur lors du redimensionnement de l'image : " + e.Message);
            }
            
        }
    }

}

