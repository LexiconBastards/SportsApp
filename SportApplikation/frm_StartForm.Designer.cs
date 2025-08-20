namespace SportApplikation
{
    partial class frm_StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StartForm));
            this.cmb_ShooseSport = new System.Windows.Forms.ComboBox();
            this.tblSportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lagsportDBDataSet = new SportApplikation.LagsportDBDataSet();
            this.txtOneShoosedTeams = new System.Windows.Forms.TextBox();
            this.tblLagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTwoShoosedTeams = new System.Windows.Forms.TextBox();
            this.tblLagBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtThreeShoosedTeams = new System.Windows.Forms.TextBox();
            this.tblLagBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtFourShoosedTeams = new System.Windows.Forms.TextBox();
            this.tblLagBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_ShooseTeam = new System.Windows.Forms.DataGridView();
            this.lagIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLagBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_GameSchemeAndResults = new System.Windows.Forms.DataGridView();
            this.lagIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lagDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLagBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_Table = new System.Windows.Forms.DataGridView();
            this.lagIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lagDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLagBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tblSportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox_Hockey = new System.Windows.Forms.PictureBox();
            this.pictureBox_BasketBall = new System.Windows.Forms.PictureBox();
            this.pictureBox_SoccerWomen = new System.Windows.Forms.PictureBox();
            this.btn_CreateSchemeResultTable = new System.Windows.Forms.Button();
            this.btn_AddNewTeam = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.tbl_SportTableAdapter = new SportApplikation.LagsportDBDataSetTableAdapters.tbl_SportTableAdapter();
            this.tbl_LagTableAdapter = new SportApplikation.LagsportDBDataSetTableAdapters.tbl_LagTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblSportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagsportDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShooseTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GameSchemeAndResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hockey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BasketBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SoccerWomen)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_ShooseSport
            // 
            this.cmb_ShooseSport.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblSportBindingSource, "Sport", true));
            this.cmb_ShooseSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ShooseSport.FormattingEnabled = true;
            this.cmb_ShooseSport.Location = new System.Drawing.Point(72, 74);
            this.cmb_ShooseSport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_ShooseSport.Name = "cmb_ShooseSport";
            this.cmb_ShooseSport.Size = new System.Drawing.Size(290, 28);
            this.cmb_ShooseSport.TabIndex = 0;
            this.cmb_ShooseSport.SelectedIndexChanged += new System.EventHandler(this.cmb_ShooseSport_SelectedIndexChanged);
            // 
            // tblSportBindingSource
            // 
            this.tblSportBindingSource.DataMember = "tbl_Sport";
            this.tblSportBindingSource.DataSource = this.lagsportDBDataSet;
            // 
            // lagsportDBDataSet
            // 
            this.lagsportDBDataSet.DataSetName = "LagsportDBDataSet";
            this.lagsportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtOneShoosedTeams
            // 
            this.txtOneShoosedTeams.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblLagBindingSource, "Lag", true));
            this.txtOneShoosedTeams.Location = new System.Drawing.Point(72, 140);
            this.txtOneShoosedTeams.Name = "txtOneShoosedTeams";
            this.txtOneShoosedTeams.Size = new System.Drawing.Size(289, 26);
            this.txtOneShoosedTeams.TabIndex = 1;
            this.txtOneShoosedTeams.TextChanged += new System.EventHandler(this.txtOneShoosedTeams_TextChanged);
            // 
            // tblLagBindingSource
            // 
            this.tblLagBindingSource.DataMember = "tbl_Lag";
            this.tblLagBindingSource.DataSource = this.lagsportDBDataSet;
            // 
            // txtTwoShoosedTeams
            // 
            this.txtTwoShoosedTeams.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblLagBindingSource1, "Lag", true));
            this.txtTwoShoosedTeams.Location = new System.Drawing.Point(72, 189);
            this.txtTwoShoosedTeams.Name = "txtTwoShoosedTeams";
            this.txtTwoShoosedTeams.Size = new System.Drawing.Size(289, 26);
            this.txtTwoShoosedTeams.TabIndex = 2;
            this.txtTwoShoosedTeams.TextChanged += new System.EventHandler(this.txtTwoShoosedTeams_TextChanged);
            // 
            // tblLagBindingSource1
            // 
            this.tblLagBindingSource1.DataMember = "tbl_Lag";
            this.tblLagBindingSource1.DataSource = this.lagsportDBDataSet;
            // 
            // txtThreeShoosedTeams
            // 
            this.txtThreeShoosedTeams.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblLagBindingSource2, "Lag", true));
            this.txtThreeShoosedTeams.Location = new System.Drawing.Point(72, 243);
            this.txtThreeShoosedTeams.Name = "txtThreeShoosedTeams";
            this.txtThreeShoosedTeams.Size = new System.Drawing.Size(289, 26);
            this.txtThreeShoosedTeams.TabIndex = 3;
            this.txtThreeShoosedTeams.TextChanged += new System.EventHandler(this.txtThreeShoosedTeams_TextChanged);
            // 
            // tblLagBindingSource2
            // 
            this.tblLagBindingSource2.DataMember = "tbl_Lag";
            this.tblLagBindingSource2.DataSource = this.lagsportDBDataSet;
            // 
            // txtFourShoosedTeams
            // 
            this.txtFourShoosedTeams.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblLagBindingSource3, "Lag", true));
            this.txtFourShoosedTeams.Location = new System.Drawing.Point(72, 294);
            this.txtFourShoosedTeams.Name = "txtFourShoosedTeams";
            this.txtFourShoosedTeams.Size = new System.Drawing.Size(289, 26);
            this.txtFourShoosedTeams.TabIndex = 4;
            this.txtFourShoosedTeams.TextChanged += new System.EventHandler(this.txtFourShoosedTeams_TextChanged);
            // 
            // tblLagBindingSource3
            // 
            this.tblLagBindingSource3.DataMember = "tbl_Lag";
            this.tblLagBindingSource3.DataSource = this.lagsportDBDataSet;
            // 
            // dataGridView_ShooseTeam
            // 
            this.dataGridView_ShooseTeam.AutoGenerateColumns = false;
            this.dataGridView_ShooseTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ShooseTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lagIDDataGridViewTextBoxColumn,
            this.lagDataGridViewTextBoxColumn,
            this.sportIDDataGridViewTextBoxColumn});
            this.dataGridView_ShooseTeam.DataSource = this.tblLagBindingSource4;
            this.dataGridView_ShooseTeam.Location = new System.Drawing.Point(391, 74);
            this.dataGridView_ShooseTeam.Name = "dataGridView_ShooseTeam";
            this.dataGridView_ShooseTeam.Size = new System.Drawing.Size(171, 512);
            this.dataGridView_ShooseTeam.TabIndex = 5;
            this.dataGridView_ShooseTeam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ShooseTeam_CellContentClick);
            // 
            // lagIDDataGridViewTextBoxColumn
            // 
            this.lagIDDataGridViewTextBoxColumn.DataPropertyName = "LagID";
            this.lagIDDataGridViewTextBoxColumn.HeaderText = "LagID";
            this.lagIDDataGridViewTextBoxColumn.Name = "lagIDDataGridViewTextBoxColumn";
            // 
            // lagDataGridViewTextBoxColumn
            // 
            this.lagDataGridViewTextBoxColumn.DataPropertyName = "Lag";
            this.lagDataGridViewTextBoxColumn.HeaderText = "Lag";
            this.lagDataGridViewTextBoxColumn.Name = "lagDataGridViewTextBoxColumn";
            // 
            // sportIDDataGridViewTextBoxColumn
            // 
            this.sportIDDataGridViewTextBoxColumn.DataPropertyName = "SportID";
            this.sportIDDataGridViewTextBoxColumn.HeaderText = "SportID";
            this.sportIDDataGridViewTextBoxColumn.Name = "sportIDDataGridViewTextBoxColumn";
            this.sportIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblLagBindingSource4
            // 
            this.tblLagBindingSource4.DataMember = "tbl_Lag";
            this.tblLagBindingSource4.DataSource = this.lagsportDBDataSet;
            // 
            // dataGridView_GameSchemeAndResults
            // 
            this.dataGridView_GameSchemeAndResults.AutoGenerateColumns = false;
            this.dataGridView_GameSchemeAndResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GameSchemeAndResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lagIDDataGridViewTextBoxColumn1,
            this.lagDataGridViewTextBoxColumn1,
            this.sportIDDataGridViewTextBoxColumn1});
            this.dataGridView_GameSchemeAndResults.DataSource = this.tblLagBindingSource5;
            this.dataGridView_GameSchemeAndResults.Location = new System.Drawing.Point(592, 74);
            this.dataGridView_GameSchemeAndResults.Name = "dataGridView_GameSchemeAndResults";
            this.dataGridView_GameSchemeAndResults.Size = new System.Drawing.Size(377, 283);
            this.dataGridView_GameSchemeAndResults.TabIndex = 6;
            this.dataGridView_GameSchemeAndResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GameSchemeAndResults_CellContentClick);
            // 
            // lagIDDataGridViewTextBoxColumn1
            // 
            this.lagIDDataGridViewTextBoxColumn1.DataPropertyName = "LagID";
            this.lagIDDataGridViewTextBoxColumn1.HeaderText = "LagID";
            this.lagIDDataGridViewTextBoxColumn1.Name = "lagIDDataGridViewTextBoxColumn1";
            // 
            // lagDataGridViewTextBoxColumn1
            // 
            this.lagDataGridViewTextBoxColumn1.DataPropertyName = "Lag";
            this.lagDataGridViewTextBoxColumn1.HeaderText = "Lag";
            this.lagDataGridViewTextBoxColumn1.Name = "lagDataGridViewTextBoxColumn1";
            // 
            // sportIDDataGridViewTextBoxColumn1
            // 
            this.sportIDDataGridViewTextBoxColumn1.DataPropertyName = "SportID";
            this.sportIDDataGridViewTextBoxColumn1.HeaderText = "SportID";
            this.sportIDDataGridViewTextBoxColumn1.Name = "sportIDDataGridViewTextBoxColumn1";
            this.sportIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tblLagBindingSource5
            // 
            this.tblLagBindingSource5.DataMember = "tbl_Lag";
            this.tblLagBindingSource5.DataSource = this.lagsportDBDataSet;
            // 
            // dataGridView_Table
            // 
            this.dataGridView_Table.AutoGenerateColumns = false;
            this.dataGridView_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lagIDDataGridViewTextBoxColumn2,
            this.lagDataGridViewTextBoxColumn2,
            this.sportIDDataGridViewTextBoxColumn2});
            this.dataGridView_Table.DataSource = this.tblLagBindingSource6;
            this.dataGridView_Table.Location = new System.Drawing.Point(592, 389);
            this.dataGridView_Table.Name = "dataGridView_Table";
            this.dataGridView_Table.Size = new System.Drawing.Size(377, 197);
            this.dataGridView_Table.TabIndex = 7;
            this.dataGridView_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Table_CellContentClick);
            // 
            // lagIDDataGridViewTextBoxColumn2
            // 
            this.lagIDDataGridViewTextBoxColumn2.DataPropertyName = "LagID";
            this.lagIDDataGridViewTextBoxColumn2.HeaderText = "LagID";
            this.lagIDDataGridViewTextBoxColumn2.Name = "lagIDDataGridViewTextBoxColumn2";
            // 
            // lagDataGridViewTextBoxColumn2
            // 
            this.lagDataGridViewTextBoxColumn2.DataPropertyName = "Lag";
            this.lagDataGridViewTextBoxColumn2.HeaderText = "Lag";
            this.lagDataGridViewTextBoxColumn2.Name = "lagDataGridViewTextBoxColumn2";
            // 
            // sportIDDataGridViewTextBoxColumn2
            // 
            this.sportIDDataGridViewTextBoxColumn2.DataPropertyName = "SportID";
            this.sportIDDataGridViewTextBoxColumn2.HeaderText = "SportID";
            this.sportIDDataGridViewTextBoxColumn2.Name = "sportIDDataGridViewTextBoxColumn2";
            this.sportIDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tblLagBindingSource6
            // 
            this.tblLagBindingSource6.DataMember = "tbl_Lag";
            this.tblLagBindingSource6.DataSource = this.lagsportDBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Välj sport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valda lag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Klicka på önskade lag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSportBindingSource1, "Sport", true));
            this.label4.Location = new System.Drawing.Point(588, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Spelschema och resultat";
            // 
            // tblSportBindingSource1
            // 
            this.tblSportBindingSource1.DataMember = "tbl_Sport";
            this.tblSportBindingSource1.DataSource = this.lagsportDBDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tabell";
            // 
            // pictureBox_Hockey
            // 
            this.pictureBox_Hockey.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Hockey.InitialImage")));
            this.pictureBox_Hockey.Location = new System.Drawing.Point(1005, 80);
            this.pictureBox_Hockey.Name = "pictureBox_Hockey";
            this.pictureBox_Hockey.Size = new System.Drawing.Size(159, 156);
            this.pictureBox_Hockey.TabIndex = 13;
            this.pictureBox_Hockey.TabStop = false;
            // 
            // pictureBox_BasketBall
            // 
            this.pictureBox_BasketBall.InitialImage = null;
            this.pictureBox_BasketBall.Location = new System.Drawing.Point(1005, 256);
            this.pictureBox_BasketBall.Name = "pictureBox_BasketBall";
            this.pictureBox_BasketBall.Size = new System.Drawing.Size(159, 156);
            this.pictureBox_BasketBall.TabIndex = 14;
            this.pictureBox_BasketBall.TabStop = false;
            // 
            // pictureBox_SoccerWomen
            // 
            this.pictureBox_SoccerWomen.InitialImage = null;
            this.pictureBox_SoccerWomen.Location = new System.Drawing.Point(1005, 436);
            this.pictureBox_SoccerWomen.Name = "pictureBox_SoccerWomen";
            this.pictureBox_SoccerWomen.Size = new System.Drawing.Size(159, 150);
            this.pictureBox_SoccerWomen.TabIndex = 15;
            this.pictureBox_SoccerWomen.TabStop = false;
            // 
            // btn_CreateSchemeResultTable
            // 
            this.btn_CreateSchemeResultTable.Location = new System.Drawing.Point(80, 349);
            this.btn_CreateSchemeResultTable.Name = "btn_CreateSchemeResultTable";
            this.btn_CreateSchemeResultTable.Size = new System.Drawing.Size(283, 63);
            this.btn_CreateSchemeResultTable.TabIndex = 16;
            this.btn_CreateSchemeResultTable.Text = "Skapa spelschema med resultat och tabell";
            this.btn_CreateSchemeResultTable.UseVisualStyleBackColor = true;
            this.btn_CreateSchemeResultTable.Click += new System.EventHandler(this.btn_CreateSchemeResultTable_Click);
            // 
            // btn_AddNewTeam
            // 
            this.btn_AddNewTeam.Location = new System.Drawing.Point(78, 436);
            this.btn_AddNewTeam.Name = "btn_AddNewTeam";
            this.btn_AddNewTeam.Size = new System.Drawing.Size(283, 63);
            this.btn_AddNewTeam.TabIndex = 17;
            this.btn_AddNewTeam.Text = "Lägg till nya lag";
            this.btn_AddNewTeam.UseVisualStyleBackColor = true;
            this.btn_AddNewTeam.Click += new System.EventHandler(this.btn_AddNewTeam_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(78, 523);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(283, 63);
            this.btn_Quit.TabIndex = 18;
            this.btn_Quit.Text = "Avsluta";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // tbl_SportTableAdapter
            // 
            this.tbl_SportTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_LagTableAdapter
            // 
            this.tbl_LagTableAdapter.ClearBeforeFill = true;
            // 
            // frm_StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 706);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_AddNewTeam);
            this.Controls.Add(this.btn_CreateSchemeResultTable);
            this.Controls.Add(this.pictureBox_SoccerWomen);
            this.Controls.Add(this.pictureBox_BasketBall);
            this.Controls.Add(this.pictureBox_Hockey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Table);
            this.Controls.Add(this.dataGridView_GameSchemeAndResults);
            this.Controls.Add(this.dataGridView_ShooseTeam);
            this.Controls.Add(this.txtFourShoosedTeams);
            this.Controls.Add(this.txtThreeShoosedTeams);
            this.Controls.Add(this.txtTwoShoosedTeams);
            this.Controls.Add(this.txtOneShoosedTeams);
            this.Controls.Add(this.cmb_ShooseSport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_StartForm";
            this.Text = "Lagsport";
            this.Load += new System.EventHandler(this.frm_StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagsportDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShooseTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GameSchemeAndResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLagBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hockey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BasketBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SoccerWomen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_ShooseSport;
        private System.Windows.Forms.TextBox txtOneShoosedTeams;
        private System.Windows.Forms.TextBox txtTwoShoosedTeams;
        private System.Windows.Forms.TextBox txtThreeShoosedTeams;
        private System.Windows.Forms.TextBox txtFourShoosedTeams;
        private System.Windows.Forms.DataGridView dataGridView_ShooseTeam;
        private System.Windows.Forms.DataGridView dataGridView_GameSchemeAndResults;
        private System.Windows.Forms.DataGridView dataGridView_Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox_Hockey;
        private System.Windows.Forms.PictureBox pictureBox_BasketBall;
        private System.Windows.Forms.PictureBox pictureBox_SoccerWomen;
        private System.Windows.Forms.Button btn_CreateSchemeResultTable;
        private System.Windows.Forms.Button btn_AddNewTeam;
        private System.Windows.Forms.Button btn_Quit;
        private LagsportDBDataSet lagsportDBDataSet;
        private System.Windows.Forms.BindingSource tblSportBindingSource;
        private LagsportDBDataSetTableAdapters.tbl_SportTableAdapter tbl_SportTableAdapter;
        private System.Windows.Forms.BindingSource tblLagBindingSource;
        private LagsportDBDataSetTableAdapters.tbl_LagTableAdapter tbl_LagTableAdapter;
        private System.Windows.Forms.BindingSource tblLagBindingSource1;
        private System.Windows.Forms.BindingSource tblLagBindingSource2;
        private System.Windows.Forms.BindingSource tblLagBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblLagBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tblLagBindingSource5;
        private System.Windows.Forms.BindingSource tblSportBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource tblLagBindingSource6;
    }
}

