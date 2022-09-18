using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2
{
    internal class Controller
    {
        private List<Models.Forme> listeFormes = new List<Models.Forme>();
        private int index;
        private Forme formeCourante;

        public Forme FormeCourante { get => formeCourante; }
        
        public event EventHandler<Forme> FormeCouranteChanged;

        public Controller()
        {
            Models.Rectangle rectangle = new Models.Rectangle();
            Models.RectanglePlein rectanglePlein = new Models.RectanglePlein();
            Models.Cercle cercle = new Models.Cercle();
            Models.CerclePlein cerclePlein = new Models.CerclePlein();
            listeFormes.Add(rectangle);
            listeFormes.Add(rectanglePlein);
            listeFormes.Add(cercle);
            listeFormes.Add(cerclePlein);
            index = 0;
        }

        public void Dessiner()
        {
            if (index > listeFormes.Count - 1)
            {
                index = 0;
            }
            listeFormes[index].Dessiner();
            this.formeCourante = listeFormes[index];
            index++;
            FormeCouranteChanged?.Invoke(this, FormeCourante);
        }
    }
}
