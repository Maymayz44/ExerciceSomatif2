using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    internal class RectanglePlein : Forme
    {
        private Color couleur;
        public RectanglePlein() : base()
        {
            this.couleur = Color.Green;
        }

        public override string ObtenirType()
        {
            return "Rectangle Plein";
        }

        protected override void Dessiner(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.couleur);
            System.Drawing.Rectangle rect = new(0, 0, 99, 99);
            graphics.FillRectangle(brush, rect);
        }
    }
}
