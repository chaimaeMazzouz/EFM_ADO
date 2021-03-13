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
    public partial class Recherche_par_Consultant : Form
    {
        public Recherche_par_Consultant()
        {
            InitializeComponent();
        }

        private void Recherche_par_Consultant_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetGestion_Consultant.Consultant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.consultantTableAdapter.Fill(this.dataSetGestion_Consultant.Consultant);
            // TODO: cette ligne de code charge les données dans la table 'dataSetGestion_Consultant.Mission'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.missionTableAdapter.Fill(this.dataSetGestion_Consultant.Mission);
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.missionBindingSource.Filter = $"CIN = '{comboCIN.Text}'";
        }
    }
}
