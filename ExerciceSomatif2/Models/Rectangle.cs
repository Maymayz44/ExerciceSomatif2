using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class Rectangle : Forme
    {
        private Color couleur;
        public Rectangle() : base()
        {
            this.couleur = Color.Green;
        }

        public override string ObtenirType()
        {
            return "Rectangle";
        }

        protected override void Dessiner(Graphics graphics)
        {
            Pen pen = new Pen(this.couleur);
            System.Drawing.Rectangle rect = new(0, 0, 99, 99);
            graphics.DrawRectangle(pen, rect);
        }
    }
}
