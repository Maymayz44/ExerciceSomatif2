using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceSomatif2.Controles
{
    public partial class UCformes : UserControl
    {
        private Forme forme;

        public Forme Forme
        {
            get => forme;
            set { SetForme(value); }
        }
        public UCformes()
        {
            InitializeComponent();
        }        

        private void SetForme(Forme? forme)
        {
            if (forme == null)
            {
                lblType.Text = "";
            }
            else if (forme is not null)
            {
                forme.TypeChanged -= Forme_TypeChanged;
            }
            this.forme = forme;
            if (forme is not null)
            {
                Afficher();
                forme.TypeChanged += Forme_TypeChanged;
            }
        }

        private void Forme_TypeChanged(object? sender, string type)
        {
            lblType.Text = type;
        }

        private void Afficher()
        {
            lblType.Text = forme.ObtenirType();
            picFormes.Invalidate();
        }

        private void picFormes_Paint(object sender, PaintEventArgs e)
        {
            picFormes.Image = forme?.Dessiner();
        }
    }
}
