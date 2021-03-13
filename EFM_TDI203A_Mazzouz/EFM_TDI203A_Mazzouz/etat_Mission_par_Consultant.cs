using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFM_TDI203A_Mazzouz
{
    public partial class etat_Mission_par_Consultant : Form
    {
        public etat_Mission_par_Consultant()
        {
            InitializeComponent();
        }
        Global g1 = new Global();
        SqlConnection con;
        private void etat_Mission_par_Consultant_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetGestion_Consultant.Mission'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.missionTableAdapter.Fill(this.dataSetGestion_Consultant.Mission);
            

        }

        private void comboCIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            CrystalReportGestionMission cr = new CrystalReportGestionMission();
            cr.SetDataSource(this.dataSetGestion_Consultant);
            crystalReportViewer1.ReportSource =cr;
            
        }
    }
}
