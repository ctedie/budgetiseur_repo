
namespace Budgetiseur
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.appareil1 = new Budgetiseur.Appareil();
            this.appareil2 = new Budgetiseur.Appareil();
            this.appareil3 = new Budgetiseur.Appareil();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.appareil3);
            this.groupBox1.Controls.Add(this.appareil2);
            this.groupBox1.Controls.Add(this.appareil1);
            this.groupBox1.Location = new System.Drawing.Point(65, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // appareil1
            // 
            this.appareil1.Location = new System.Drawing.Point(6, 19);
            this.appareil1.Name = "appareil1";
            this.appareil1.Size = new System.Drawing.Size(186, 89);
            this.appareil1.TabIndex = 0;
            // 
            // appareil2
            // 
            this.appareil2.Location = new System.Drawing.Point(6, 114);
            this.appareil2.Name = "appareil2";
            this.appareil2.Size = new System.Drawing.Size(186, 89);
            this.appareil2.TabIndex = 1;
            // 
            // appareil3
            // 
            this.appareil3.Location = new System.Drawing.Point(6, 209);
            this.appareil3.Name = "appareil3";
            this.appareil3.Size = new System.Drawing.Size(186, 89);
            this.appareil3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Appareil appareil3;
        private Appareil appareil2;
        private Appareil appareil1;
    }
}

