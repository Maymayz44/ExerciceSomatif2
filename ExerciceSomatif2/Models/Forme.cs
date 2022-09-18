using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public abstract class Forme
    {
        private Color couleur;

        public event EventHandler<string> TypeChanged;
        public Forme()
        {

        }

        protected abstract void Dessiner(Graphics graphics);

        public Bitmap Dessiner()
        {
            Bitmap bitmap = new Bitmap(100, 100);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Dessiner(graphics);
            }
            TypeChanged?.Invoke(this, ObtenirType());
            return bitmap;
        }

        public abstract string ObtenirType();

    }
}
