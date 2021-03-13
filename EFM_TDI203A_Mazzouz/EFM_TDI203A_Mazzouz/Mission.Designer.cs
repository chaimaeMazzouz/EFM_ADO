
namespace EFM_TDI203A_Mazzouz
{
    partial class Mission
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
            this.textNumMiss = new System.Windows.Forms.TextBox();
            this.missionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGestion_Consultant = new EFM_TDI203A_Mazzouz.DataSetGestion_Consultant();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textDescrp = new System.Windows.Forms.TextBox();
            this.dTPMission = new System.Windows.Forms.DateTimePicker();
            this.comboRefMission = new System.Windows.Forms.ComboBox();
            this.organismeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboCIN = new System.Windows.Forms.ComboBox();
            this.consultantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Enregitrer = new System.Windows.Forms.Button();
            this.missionTableAdapter = new EFM_TDI203A_Mazzouz.DataSetGestion_ConsultantTableAdapters.MissionTableAdapter();
            this.organismeTableAdapter = new EFM_TDI203A_Mazzouz.DataSetGestion_ConsultantTableAdapters.OrganismeTableAdapter();
            this.consultantTableAdapter = new EFM_TDI203A_Mazzouz.DataSetGestion_ConsultantTableAdapters.ConsultantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGestion_Consultant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organismeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textNumMiss
            // 
            this.textNumMiss.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.missionBindingSource, "Num_mission", true));
            this.textNumMiss.Location = new System.Drawing.Point(214, 57);
            this.textNumMiss.Name = "textNumMiss";
            this.textNumMiss.ReadOnly = true;
            this.textNumMiss.Size = new System.Drawing.Size(154, 26);
            this.textNumMiss.TabIndex = 0;
            // 
            // missionBindingSource
            // 
            this.missionBindingSource.DataMember = "Mission";
            this.missionBindingSource.DataSource = this.dataSetGestion_Consultant;
            // 
            // dataSetGestion_Consultant
            // 
            this.dataSetGestion_Consultant.DataSetName = "DataSetGestion_Consultant";
            this.dataSetGestion_Consultant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numéro Mission";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(408, 75);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 39);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "|<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // textDescrp
            // 
            this.textDescrp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.missionBindingSource, "Descrp", true));
            this.textDescrp.Location = new System.Drawing.Point(214, 335);
            this.textDescrp.Name = "textDescrp";
            this.textDescrp.Size = new System.Drawing.Size(154, 26);
            this.textDescrp.TabIndex = 3;
            // 
            // dTPMission
            // 
            this.dTPMission.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.missionBindingSource, "DateMission", true));
            this.dTPMission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPMission.Location = new System.Drawing.Point(214, 128);
            this.dTPMission.Name = "dTPMission";
            this.dTPMission.Size = new System.Drawing.Size(154, 26);
            this.dTPMission.TabIndex = 5;
            // 
            // comboRefMission
            // 
            this.comboRefMission.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.missionBindingSource, "RefOrganisme", true));
            this.comboRefMission.DataSource = this.organismeBindingSource;
            this.comboRefMission.DisplayMember = "RefOrganisme";
            this.comboRefMission.FormattingEnabled = true;
            this.comboRefMission.Location = new System.Drawing.Point(214, 198);
            this.comboRefMission.Name = "comboRefMission";
            this.comboRefMission.Size = new System.Drawing.Size(154, 28);
            this.comboRefMission.TabIndex = 6;
            this.comboRefMission.ValueMember = "RefOrganisme";
            // 
            // organismeBindingSource
            // 
            this.organismeBindingSource.DataMember = "Organisme";
            this.organismeBindingSource.DataSource = this.dataSetGestion_Consultant;
            // 
            // comboCIN
            // 
            this.comboCIN.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.missionBindingSource, "CIN", true));
            this.comboCIN.DataSource = this.consultantBindingSource;
            this.comboCIN.DisplayMember = "CIN";
            this.comboCIN.FormattingEnabled = true;
            this.comboCIN.Location = new System.Drawing.Point(214, 270);
            this.comboCIN.Name = "comboCIN";
            this.comboCIN.Size = new System.Drawing.Size(154, 28);
            this.comboCIN.TabIndex = 7;
            this.comboCIN.ValueMember = "CIN";
            // 
            // consultantBindingSource
            // 
            this.consultantBindingSource.DataMember = "Consultant";
            this.consultantBindingSource.DataSource = this.dataSetGestion_Consultant;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date Mission";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "CIN Consultant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Réference Mission";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(508, 75);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 39);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(705, 75);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 39);
            this.btnLast.TabIndex = 13;
            this.btnLast.Text = ">>|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(605, 75);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 39);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Nouveau
            // 
            this.Nouveau.Location = new System.Drawing.Point(440, 134);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(130, 57);
            this.Nouveau.TabIndex = 14;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(628, 134);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(130, 57);
            this.Ajouter.TabIndex = 15;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(628, 229);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(130, 57);
            this.Supprimer.TabIndex = 17;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(440, 229);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(130, 57);
            this.Modifier.TabIndex = 16;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Enregitrer
            // 
            this.Enregitrer.Location = new System.Drawing.Point(540, 313);
            this.Enregitrer.Name = "Enregitrer";
            this.Enregitrer.Size = new System.Drawing.Size(130, 57);
            this.Enregitrer.TabIndex = 18;
            this.Enregitrer.Text = "Enregistrer";
            this.Enregitrer.UseVisualStyleBackColor = true;
            this.Enregitrer.Click += new System.EventHandler(this.Enregitrer_Click);
            // 
            // missionTableAdapter
            // 
            this.missionTableAdapter.ClearBeforeFill = true;
            // 
            // organismeTableAdapter
            // 
            this.organismeTableAdapter.ClearBeforeFill = true;
            // 
            // consultantTableAdapter
            // 
            this.consultantTableAdapter.ClearBeforeFill = true;
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 493);
            this.Controls.Add(this.Enregitrer);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboCIN);
            this.Controls.Add(this.comboRefMission);
            this.Controls.Add(this.dTPMission);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDescrp);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNumMiss);
            this.Name = "Mission";
            this.Text = "Mission";
            this.Load += new System.EventHandler(this.Mission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGestion_Consultant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organismeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumMiss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDescrp;
        private System.Windows.Forms.DateTimePicker dTPMission;
        private System.Windows.Forms.ComboBox comboRefMission;
        private System.Windows.Forms.ComboBox comboCIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Enregitrer;
        private DataSetGestion_Consultant dataSetGestion_Consultant;
        private System.Windows.Forms.BindingSource missionBindingSource;
        private DataSetGestion_ConsultantTableAdapters.MissionTableAdapter missionTableAdapter;
        private System.Windows.Forms.BindingSource organismeBindingSource;
        private DataSetGestion_ConsultantTableAdapters.OrganismeTableAdapter organismeTableAdapter;
        private System.Windows.Forms.BindingSource consultantBindingSource;
        private DataSetGestion_ConsultantTableAdapters.ConsultantTableAdapter consultantTableAdapter;
    }
}