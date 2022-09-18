namespace ExerciceSomatif2.Controles
{
    partial class UCformes
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picFormes = new System.Windows.Forms.PictureBox();
            this.lblType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFormes)).BeginInit();
            this.SuspendLayout();
            // 
            // picFormes
            // 
            this.picFormes.Location = new System.Drawing.Point(3, 3);
            this.picFormes.Name = "picFormes";
            this.picFormes.Size = new System.Drawing.Size(165, 195);
            this.picFormes.TabIndex = 0;
            this.picFormes.TabStop = false;
            this.picFormes.Paint += new System.Windows.Forms.PaintEventHandler(this.picFormes_Paint);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 201);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(108, 20);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Affichage Type";
            // 
            // UCformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.picFormes);
            this.Name = "UCformes";
            this.Size = new System.Drawing.Size(171, 229);
            ((System.ComponentModel.ISupportInitialize)(this.picFormes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picFormes;
        private Label lblType;
    }
}
