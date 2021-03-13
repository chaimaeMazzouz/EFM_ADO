
namespace EFM_TDI203A_Mazzouz
{
    partial class Recherche_par_Organisme_et_Consultant
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboCIN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboRefOrgan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSetGestion_Consultant = new EFM_TDI203A_Mazzouz.DataSetGestion_Consultant();
            this.missionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.missionTableAdapter = new EFM_TDI203A_Mazzouz.DataSetGestion_ConsultantTableAdapters.MissionTableAdapter();
            this.nummissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateMissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refOrganismeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organismeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.organismeTableAdapter = new EFM_TDI203A_Mazzouz.DataSetGestion_ConsultantTableAdapters.OrganismeTableAdapter();
            this.consultantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultantTableAdapter = new EFM_TDI203A_Mazzouz.DataSetGestion_ConsultantTableAdapters.ConsultantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGestion_Consultant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organismeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nummissionDataGridViewTextBoxColumn,
            this.dateMissionDataGridViewTextBoxColumn,
            this.cINDataGridViewTextBoxColumn,
            this.refOrganismeDataGridViewTextBoxColumn,
            this.descrpDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.missionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(812, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // comboCIN
            // 
            this.comboCIN.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.missionBindingSource, "CIN", true));
            this.comboCIN.DataSource = this.consultantBindingSource;
            this.comboCIN.DisplayMember = "CIN";
            this.comboCIN.FormattingEnabled = true;
            this.comboCIN.Location = new System.Drawing.Point(663, 115);
            this.comboCIN.Name = "comboCIN";
            this.comboCIN.Size = new System.Drawing.Size(121, 28);
            this.comboCIN.TabIndex = 4;
            this.comboCIN.ValueMember = "CIN";
            this.comboCIN.SelectedIndexChanged += new System.EventHandler(this.comboCIN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "CIN Consultant";
            // 
            // comboRefOrgan
            // 
            this.comboRefOrgan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.missionBindingSource, "RefOrganisme", true));
            this.comboRefOrgan.DataSource = this.organismeBindingSource;
            this.comboRefOrgan.DisplayMember = "RefOrganisme";
            this.comboRefOrgan.FormattingEnabled = true;
            this.comboRefOrgan.Location = new System.Drawing.Point(296, 118);
            this.comboRefOrgan.Name = "comboRefOrgan";
            this.comboRefOrgan.Size = new System.Drawing.Size(121, 28);
            this.comboRefOrgan.TabIndex = 7;
            this.comboRefOrgan.ValueMember = "RefOrganisme";
            this.comboRefOrgan.SelectedIndexChanged += new System.EventHandler(this.comboRefOrgan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Référence Organisme";
            // 
            // dataSetGestion_Consultant
            // 
            this.dataSetGestion_Consultant.DataSetName = "DataSetGestion_Consultant";
            this.dataSetGestion_Consultant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // missionBindingSource
            // 
            this.missionBindingSource.DataMember = "Mission";
            this.missionBindingSource.DataSource = this.dataSetGestion_Consultant;
            // 
            // missionTableAdapter
            // 
            this.missionTableAdapter.ClearBeforeFill = true;
            // 
            // nummissionDataGridViewTextBoxColumn
            // 
            this.nummissionDataGridViewTextBoxColumn.DataPropertyName = "Num_mission";
            this.nummissionDataGridViewTextBoxColumn.HeaderText = "Num_mission";
            this.nummissionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nummissionDataGridViewTextBoxColumn.Name = "nummissionDataGridViewTextBoxColumn";
            this.nummissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.nummissionDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateMissionDataGridViewTextBoxColumn
            // 
            this.dateMissionDataGridViewTextBoxColumn.DataPropertyName = "DateMission";
            this.dateMissionDataGridViewTextBoxColumn.HeaderText = "DateMission";
            this.dateMissionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateMissionDataGridViewTextBoxColumn.Name = "dateMissionDataGridViewTextBoxColumn";
            this.dateMissionDataGridViewTextBoxColumn.Width = 150;
            // 
            // cINDataGridViewTextBoxColumn
            // 
            this.cINDataGridViewTextBoxColumn.DataPropertyName = "CIN";
            this.cINDataGridViewTextBoxColumn.HeaderText = "CIN";
            this.cINDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cINDataGridViewTextBoxColumn.Name = "cINDataGridViewTextBoxColumn";
            this.cINDataGridViewTextBoxColumn.Width = 150;
            // 
            // refOrganismeDataGridViewTextBoxColumn
            // 
            this.refOrganismeDataGridViewTextBoxColumn.DataPropertyName = "RefOrganisme";
            this.refOrganismeDataGridViewTextBoxColumn.HeaderText = "RefOrganisme";
            this.refOrganismeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.refOrganismeDataGridViewTextBoxColumn.Name = "refOrganismeDataGridViewTextBoxColumn";
            this.refOrganismeDataGridViewTextBoxColumn.Width = 150;
            // 
            // descrpDataGridViewTextBoxColumn
            // 
            this.descrpDataGridViewTextBoxColumn.DataPropertyName = "Descrp";
            this.descrpDataGridViewTextBoxColumn.HeaderText = "Descrp";
            this.descrpDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descrpDataGridViewTextBoxColumn.Name = "descrpDataGridViewTextBoxColumn";
            this.descrpDataGridViewTextBoxColumn.Width = 150;
            // 
            // organismeBindingSource
            // 
            this.organismeBindingSource.DataMember = "Organisme";
            this.organismeBindingSource.DataSource = this.dataSetGestion_Consultant;
            // 
            // organismeTableAdapter
            // 
            this.organismeTableAdapter.ClearBeforeFill = true;
            // 
            // consultantBindingSource
            // 
            this.consultantBindingSource.DataMember = "Consultant";
            this.consultantBindingSource.DataSource = this.dataSetGestion_Consultant;
            // 
            // consultantTableAdapter
            // 
            this.consultantTableAdapter.ClearBeforeFill = true;
            // 
            // Recherche_par_Organisme_et_Consultant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.comboRefOrgan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboCIN);
            this.Controls.Add(this.label1);
            this.Name = "Recherche_par_Organisme_et_Consultant";
            this.Text = "Recherche_par_Organisme_et_Consultant";
            this.Load += new System.EventHandler(this.Recherche_par_Organisme_et_Consultant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGestion_Consultant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organismeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboCIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRefOrgan;
        private System.Windows.Forms.Label label2;
        private DataSetGestion_Consultant dataSetGestion_Consultant;
        private System.Windows.Forms.BindingSource missionBindingSource;
        private DataSetGestion_ConsultantTableAdapters.MissionTableAdapter missionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateMissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refOrganismeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrpDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource organismeBindingSource;
        private DataSetGestion_ConsultantTableAdapters.OrganismeTableAdapter organismeTableAdapter;
        private System.Windows.Forms.BindingSource consultantBindingSource;
        private DataSetGestion_ConsultantTableAdapters.ConsultantTableAdapter consultantTableAdapter;
    }
}