
namespace EFM_TDI203A_Mazzouz
{
    partial class Home
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
            this.missionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parConsultantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parOrganismeEtConsultantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missionsParConsultantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organismeParConsultantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.missionToolStripMenuItem,
            this.rechercheToolStripMenuItem,
            this.impressionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // missionToolStripMenuItem
            // 
            this.missionToolStripMenuItem.Name = "missionToolStripMenuItem";
            this.missionToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.missionToolStripMenuItem.Text = "Mission";
            this.missionToolStripMenuItem.Click += new System.EventHandler(this.missionToolStripMenuItem_Click);
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parConsultantToolStripMenuItem,
            this.parOrganismeEtConsultantToolStripMenuItem});
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.rechercheToolStripMenuItem.Text = "Recherche";
            // 
            // impressionToolStripMenuItem
            // 
            this.impressionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.missionsParConsultantToolStripMenuItem,
            this.organismeParConsultantToolStripMenuItem});
            this.impressionToolStripMenuItem.Name = "impressionToolStripMenuItem";
            this.impressionToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.impressionToolStripMenuItem.Text = "Impression";
            // 
            // parConsultantToolStripMenuItem
            // 
            this.parConsultantToolStripMenuItem.Name = "parConsultantToolStripMenuItem";
            this.parConsultantToolStripMenuItem.Size = new System.Drawing.Size(337, 34);
            this.parConsultantToolStripMenuItem.Text = "Par Consultant";
            this.parConsultantToolStripMenuItem.Click += new System.EventHandler(this.parConsultantToolStripMenuItem_Click);
            // 
            // parOrganismeEtConsultantToolStripMenuItem
            // 
            this.parOrganismeEtConsultantToolStripMenuItem.Name = "parOrganismeEtConsultantToolStripMenuItem";
            this.parOrganismeEtConsultantToolStripMenuItem.Size = new System.Drawing.Size(337, 34);
            this.parOrganismeEtConsultantToolStripMenuItem.Text = "Par organisme et Consultant";
            this.parOrganismeEtConsultantToolStripMenuItem.Click += new System.EventHandler(this.parOrganismeEtConsultantToolStripMenuItem_Click);
            // 
            // missionsParConsultantToolStripMenuItem
            // 
            this.missionsParConsultantToolStripMenuItem.Name = "missionsParConsultantToolStripMenuItem";
            this.missionsParConsultantToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.missionsParConsultantToolStripMenuItem.Text = "Missions par Consultant";
            this.missionsParConsultantToolStripMenuItem.Click += new System.EventHandler(this.missionsParConsultantToolStripMenuItem_Click);
            // 
            // organismeParConsultantToolStripMenuItem
            // 
            this.organismeParConsultantToolStripMenuItem.Name = "organismeParConsultantToolStripMenuItem";
            this.organismeParConsultantToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.organismeParConsultantToolStripMenuItem.Text = "Organisme par Consultant";
            this.organismeParConsultantToolStripMenuItem.Click += new System.EventHandler(this.organismeParConsultantToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 464);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem missionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parConsultantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parOrganismeEtConsultantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missionsParConsultantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organismeParConsultantToolStripMenuItem;
    }
}

