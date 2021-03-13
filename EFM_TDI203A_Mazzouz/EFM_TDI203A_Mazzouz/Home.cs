using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFM_TDI203A_Mazzouz
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Changer_Form(Form form)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void missionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Mission());
        }

        private void parConsultantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Recherche_par_Consultant());

        }

        private void parOrganismeEtConsultantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Recherche_par_Organisme_et_Consultant());

        }

        private void missionsParConsultantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new etat_Mission_par_Consultant());

        }

        private void organismeParConsultantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new organismes_consultant());

        }
    }
}
