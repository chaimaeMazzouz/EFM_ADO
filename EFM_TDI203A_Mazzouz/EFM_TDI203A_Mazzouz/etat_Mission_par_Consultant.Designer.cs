
namespace EFM_TDI203A_Mazzouz
{
    partial class etat_Mission_par_Consultant
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.comboCIN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSetGestion_Consultant = new EFM_TDI203A_Mazzouz.DataSetGestion_Consultant();
            this.missionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.missionTableAdapter = new EFM_TDI203A_Mazzouz.DataSetGestion_ConsultantTableAdapters.MissionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGestion_Consultant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(1, 71);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(853, 441);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // comboCIN
            // 
            this.comboCIN.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.missionBindingSource, "CIN", true));
            this.comboCIN.DataSource = this.missionBindingSource;
            this.comboCIN.DisplayMember = "CIN";
            this.comboCIN.FormattingEnabled = true;
            this.comboCIN.Location = new System.Drawing.Point(413, 21);
            this.comboCIN.Name = "comboCIN";
            this.comboCIN.Size = new System.Drawing.Size(121, 28);
            this.comboCIN.TabIndex = 3;
            this.comboCIN.ValueMember = "CIN";
            this.comboCIN.SelectedIndexChanged += new System.EventHandler(this.comboCIN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CIN Consultant";
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
            // etat_Mission_par_Consultant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 514);
            this.Controls.Add(this.comboCIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "etat_Mission_par_Consultant";
            this.Text = "etat_Mission_par_Consultant";
            this.Load += new System.EventHandler(this.etat_Mission_par_Consultant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGestion_Consultant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox comboCIN;
        private System.Windows.Forms.Label label1;
        private DataSetGestion_Consultant dataSetGestion_Consultant;
        private System.Windows.Forms.BindingSource missionBindingSource;
        private DataSetGestion_ConsultantTableAdapters.MissionTableAdapter missionTableAdapter;
    }
}