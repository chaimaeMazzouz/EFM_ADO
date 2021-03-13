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
    public partial class Mission : Form
    {
        public Mission()
        {
            InitializeComponent();
        }

        private void Mission_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetGestion_Consultant.Consultant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.consultantTableAdapter.Fill(this.dataSetGestion_Consultant.Consultant);
            // TODO: cette ligne de code charge les données dans la table 'dataSetGestion_Consultant.Organisme'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.organismeTableAdapter.Fill(this.dataSetGestion_Consultant.Organisme);
            // TODO: cette ligne de code charge les données dans la table 'dataSetGestion_Consultant.Mission'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.missionTableAdapter.Fill(this.dataSetGestion_Consultant.Mission);
            // TODO: cette ligne de code charge les données dans la table 'dataSetGestion_Consultant.Mission'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.missionTableAdapter.Fill(this.dataSetGestion_Consultant.Mission);

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.missionBindingSource.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.missionBindingSource.MovePrevious();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.missionBindingSource.MoveNext();

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.missionBindingSource.MoveLast();

        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            this.missionBindingSource.AddNew();

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (textNumMiss.Text != "" && textDescrp.Text != "")
            {
                try
                {
                    this.missionBindingSource.RemoveCurrent();
                    MessageBox.Show("Supprission effectuée", "terminer");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
                MessageBox.Show("Remplir les champs");
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (textNumMiss.Text != "" && textDescrp.Text != "" )
            {
                try
                {
                    this.missionBindingSource.EndEdit();
                    MessageBox.Show("Modification effectuée", "terminer");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
                MessageBox.Show("Remplir les champs");
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (textNumMiss.Text != "" && textDescrp.Text != "" )
            {
                try
                {
                    this.missionBindingSource.EndEdit();
                    MessageBox.Show("Ajout effectuée", "terminer");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               

            }
            else
                MessageBox.Show("Remplir les champs");

        }

        private void Enregitrer_Click(object sender, EventArgs e)
        {
            try
            {
                this.missionTableAdapter.Update(dataSetGestion_Consultant.Mission);
                MessageBox.Show("Enregistrer","terminer") ;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
