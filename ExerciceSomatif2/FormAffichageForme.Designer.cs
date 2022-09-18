namespace ExerciceSomatif2
{
    partial class FormAffichageForme
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uCformes1 = new ExerciceSomatif2.Controles.UCformes();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uCformes1
            // 
            this.uCformes1.Location = new System.Drawing.Point(12, 11);
            this.uCformes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uCformes1.Name = "uCformes1";
            this.uCformes1.Size = new System.Drawing.Size(150, 172);
            this.uCformes1.TabIndex = 0;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(12, 188);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(150, 23);
            this.btnAfficher.TabIndex = 1;
            this.btnAfficher.Text = "Afficher Forme";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // FormAffichageForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.uCformes1);
            this.Name = "FormAffichageForme";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCformes uCformes1;
        private Button btnAfficher;
    }
}