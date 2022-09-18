using ExerciceSomatif2.Controles;

namespace ExerciceSomatif2
{
    public partial class FormAffichageForme : Form
    {
        private readonly Controller controller;
        public FormAffichageForme()
        {
            InitializeComponent();
            controller = new Controller();
            controller.FormeCouranteChanged += Controller_FormeCouranteChanged;
        }

        private void Controller_FormeCouranteChanged(object? sender, Models.Forme forme)
        {
            uCformes1.Forme = forme;
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            controller.Dessiner();
        }
    }
}