using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    internal class CerclePlein : Forme
    {
        private Color couleur;
        public CerclePlein() : base()
        {
            this.couleur = Color.Orange;
        }

        public override string ObtenirType()
        {
            return "Cercle Plein";
        }

        protected override void Dessiner(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.couleur);
            System.Drawing.Rectangle rect = new(0, 0, 99, 99);
            graphics.FillEllipse(brush, rect);
        }
    }
}
