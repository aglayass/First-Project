namespace TP12
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionEquipeToolStripMenuItem,
            this.gestionJoueurToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.gestionToolStripMenuItem.Text = "Menu de Gestion";
            // 
            // gestionEquipeToolStripMenuItem
            // 
            this.gestionEquipeToolStripMenuItem.Name = "gestionEquipeToolStripMenuItem";
            this.gestionEquipeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gestionEquipeToolStripMenuItem.Text = "Gestion Equipe ";
            this.gestionEquipeToolStripMenuItem.Click += new System.EventHandler(this.gestionEquipeToolStripMenuItem_Click);
            // 
            // gestionJoueurToolStripMenuItem
            // 
            this.gestionJoueurToolStripMenuItem.Name = "gestionJoueurToolStripMenuItem";
            this.gestionJoueurToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gestionJoueurToolStripMenuItem.Text = "Gestion Joueur";
            this.gestionJoueurToolStripMenuItem.Click += new System.EventHandler(this.gestionJoueurToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionEquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionJoueurToolStripMenuItem;
    }
}

