using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    internal class Cercle : Forme
    {
        private Color couleur;
        public Cercle() : base()
        {
            this.couleur = Color.Orange;
        }

        public override string ObtenirType()
        {
            return "Cercle";
        }

        protected override void Dessiner(Graphics graphics)
        {
            Pen pen = new Pen(this.couleur);
            System.Drawing.Rectangle rect = new(0, 0, 99, 99);
            graphics.DrawEllipse(pen, rect);
        }
    }
}
