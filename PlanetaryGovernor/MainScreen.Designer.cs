namespace PlanetaryGovernor
{
    partial class MainScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPlanet = new System.Windows.Forms.TabPage();
            this.tabProvinces = new System.Windows.Forms.TabPage();
            this.tabPopulation = new System.Windows.Forms.TabPage();
            this.panelPopulationInfo = new System.Windows.Forms.Panel();
            this.labelPopulationName = new System.Windows.Forms.Label();
            this.labelPopulationGrowth = new System.Windows.Forms.Label();
            this.labelPopulationIndustry = new System.Windows.Forms.Label();
            this.labelPopulationSize = new System.Windows.Forms.Label();
            this.listViewIndustryBreakdown = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeViewPopulationBreakdown = new System.Windows.Forms.TreeView();
            this.labelPlanetName = new System.Windows.Forms.Label();
            this.listViewPlanetInformation = new System.Windows.Forms.ListView();
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPlanetInformation = new System.Windows.Forms.Label();
            this.buttonTime1D = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonTurn30D = new System.Windows.Forms.Button();
            this.buttonTurn1Y = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPopulation.SuspendLayout();
            this.panelPopulationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1063, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPlanet);
            this.tabControlMain.Controls.Add(this.tabProvinces);
            this.tabControlMain.Controls.Add(this.tabPopulation);
            this.tabControlMain.Location = new System.Drawing.Point(12, 41);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1045, 644);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPlanet
            // 
            this.tabPlanet.BackColor = System.Drawing.Color.LightGray;
            this.tabPlanet.Location = new System.Drawing.Point(4, 22);
            this.tabPlanet.Name = "tabPlanet";
            this.tabPlanet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlanet.Size = new System.Drawing.Size(1037, 618);
            this.tabPlanet.TabIndex = 0;
            this.tabPlanet.Text = "Planet";
            // 
            // tabProvinces
            // 
            this.tabProvinces.BackColor = System.Drawing.Color.LightGray;
            this.tabProvinces.Location = new System.Drawing.Point(4, 22);
            this.tabProvinces.Name = "tabProvinces";
            this.tabProvinces.Padding = new System.Windows.Forms.Padding(3);
            this.tabProvinces.Size = new System.Drawing.Size(1037, 618);
            this.tabProvinces.TabIndex = 1;
            this.tabProvinces.Text = "Provinces";
            // 
            // tabPopulation
            // 
            this.tabPopulation.BackColor = System.Drawing.Color.LightGray;
            this.tabPopulation.Controls.Add(this.panelPopulationInfo);
            this.tabPopulation.Controls.Add(this.treeViewPopulationBreakdown);
            this.tabPopulation.Location = new System.Drawing.Point(4, 22);
            this.tabPopulation.Name = "tabPopulation";
            this.tabPopulation.Size = new System.Drawing.Size(1037, 618);
            this.tabPopulation.TabIndex = 2;
            this.tabPopulation.Text = "Population";
            // 
            // panelPopulationInfo
            // 
            this.panelPopulationInfo.BackColor = System.Drawing.Color.LightGray;
            this.panelPopulationInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPopulationInfo.Controls.Add(this.labelPopulationName);
            this.panelPopulationInfo.Controls.Add(this.labelPopulationGrowth);
            this.panelPopulationInfo.Controls.Add(this.labelPopulationIndustry);
            this.panelPopulationInfo.Controls.Add(this.labelPopulationSize);
            this.panelPopulationInfo.Controls.Add(this.listViewIndustryBreakdown);
            this.panelPopulationInfo.Location = new System.Drawing.Point(169, 3);
            this.panelPopulationInfo.Name = "panelPopulationInfo";
            this.panelPopulationInfo.Size = new System.Drawing.Size(865, 612);
            this.panelPopulationInfo.TabIndex = 10;
            // 
            // labelPopulationName
            // 
            this.labelPopulationName.AutoSize = true;
            this.labelPopulationName.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPopulationName.Location = new System.Drawing.Point(0, 0);
            this.labelPopulationName.Name = "labelPopulationName";
            this.labelPopulationName.Size = new System.Drawing.Size(156, 17);
            this.labelPopulationName.TabIndex = 5;
            this.labelPopulationName.Text = "labelPopulationName";
            // 
            // labelPopulationGrowth
            // 
            this.labelPopulationGrowth.AutoSize = true;
            this.labelPopulationGrowth.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPopulationGrowth.Location = new System.Drawing.Point(0, 55);
            this.labelPopulationGrowth.Name = "labelPopulationGrowth";
            this.labelPopulationGrowth.Size = new System.Drawing.Size(168, 17);
            this.labelPopulationGrowth.TabIndex = 9;
            this.labelPopulationGrowth.Text = "labelPopulationGrowth";
            // 
            // labelPopulationIndustry
            // 
            this.labelPopulationIndustry.AutoSize = true;
            this.labelPopulationIndustry.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPopulationIndustry.Location = new System.Drawing.Point(3, 242);
            this.labelPopulationIndustry.Name = "labelPopulationIndustry";
            this.labelPopulationIndustry.Size = new System.Drawing.Size(67, 17);
            this.labelPopulationIndustry.TabIndex = 7;
            this.labelPopulationIndustry.Text = "Industry";
            // 
            // labelPopulationSize
            // 
            this.labelPopulationSize.AutoSize = true;
            this.labelPopulationSize.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPopulationSize.Location = new System.Drawing.Point(0, 38);
            this.labelPopulationSize.Name = "labelPopulationSize";
            this.labelPopulationSize.Size = new System.Drawing.Size(145, 17);
            this.labelPopulationSize.TabIndex = 8;
            this.labelPopulationSize.Text = "labelPopulationSize";
            // 
            // listViewIndustryBreakdown
            // 
            this.listViewIndustryBreakdown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listViewIndustryBreakdown.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewIndustryBreakdown.GridLines = true;
            this.listViewIndustryBreakdown.Location = new System.Drawing.Point(6, 262);
            this.listViewIndustryBreakdown.Name = "listViewIndustryBreakdown";
            this.listViewIndustryBreakdown.Size = new System.Drawing.Size(255, 343);
            this.listViewIndustryBreakdown.TabIndex = 5;
            this.listViewIndustryBreakdown.UseCompatibleStateImageBehavior = false;
            this.listViewIndustryBreakdown.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Workers";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 125;
            // 
            // treeViewPopulationBreakdown
            // 
            this.treeViewPopulationBreakdown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.treeViewPopulationBreakdown.HideSelection = false;
            this.treeViewPopulationBreakdown.Location = new System.Drawing.Point(3, 3);
            this.treeViewPopulationBreakdown.Name = "treeViewPopulationBreakdown";
            this.treeViewPopulationBreakdown.Size = new System.Drawing.Size(160, 612);
            this.treeViewPopulationBreakdown.TabIndex = 0;
            this.treeViewPopulationBreakdown.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPopulationBreakdown_AfterSelect);
            // 
            // labelPlanetName
            // 
            this.labelPlanetName.AutoSize = true;
            this.labelPlanetName.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlanetName.Location = new System.Drawing.Point(1063, 41);
            this.labelPlanetName.Name = "labelPlanetName";
            this.labelPlanetName.Size = new System.Drawing.Size(124, 17);
            this.labelPlanetName.TabIndex = 0;
            this.labelPlanetName.Text = "labelPlanetName";
            // 
            // listViewPlanetInformation
            // 
            this.listViewPlanetInformation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listViewPlanetInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnType,
            this.columnValue});
            this.listViewPlanetInformation.GridLines = true;
            this.listViewPlanetInformation.Location = new System.Drawing.Point(1064, 342);
            this.listViewPlanetInformation.Name = "listViewPlanetInformation";
            this.listViewPlanetInformation.Size = new System.Drawing.Size(255, 343);
            this.listViewPlanetInformation.TabIndex = 3;
            this.listViewPlanetInformation.UseCompatibleStateImageBehavior = false;
            this.listViewPlanetInformation.View = System.Windows.Forms.View.Details;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 122;
            // 
            // columnValue
            // 
            this.columnValue.Text = "Value";
            this.columnValue.Width = 125;
            // 
            // labelPlanetInformation
            // 
            this.labelPlanetInformation.AutoSize = true;
            this.labelPlanetInformation.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlanetInformation.Location = new System.Drawing.Point(1063, 322);
            this.labelPlanetInformation.Name = "labelPlanetInformation";
            this.labelPlanetInformation.Size = new System.Drawing.Size(168, 17);
            this.labelPlanetInformation.TabIndex = 4;
            this.labelPlanetInformation.Text = "labelPlanetInformation";
            // 
            // buttonTime1D
            // 
            this.buttonTime1D.Location = new System.Drawing.Point(975, 8);
            this.buttonTime1D.Name = "buttonTime1D";
            this.buttonTime1D.Size = new System.Drawing.Size(75, 23);
            this.buttonTime1D.TabIndex = 11;
            this.buttonTime1D.Text = "1 Day";
            this.buttonTime1D.UseVisualStyleBackColor = true;
            this.buttonTime1D.Click += new System.EventHandler(this.buttonTime_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(1063, 10);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(74, 17);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "labelTime";
            // 
            // buttonTurn30D
            // 
            this.buttonTurn30D.Location = new System.Drawing.Point(894, 8);
            this.buttonTurn30D.Name = "buttonTurn30D";
            this.buttonTurn30D.Size = new System.Drawing.Size(75, 23);
            this.buttonTurn30D.TabIndex = 13;
            this.buttonTurn30D.Text = "30 Days";
            this.buttonTurn30D.UseVisualStyleBackColor = true;
            this.buttonTurn30D.Click += new System.EventHandler(this.buttonTurn30D_Click);
            // 
            // buttonTurn1Y
            // 
            this.buttonTurn1Y.Location = new System.Drawing.Point(813, 8);
            this.buttonTurn1Y.Name = "buttonTurn1Y";
            this.buttonTurn1Y.Size = new System.Drawing.Size(75, 23);
            this.buttonTurn1Y.TabIndex = 14;
            this.buttonTurn1Y.Text = "1 Year";
            this.buttonTurn1Y.UseVisualStyleBackColor = true;
            this.buttonTurn1Y.Click += new System.EventHandler(this.buttonTurn1Y_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1336, 698);
            this.Controls.Add(this.buttonTurn1Y);
            this.Controls.Add(this.buttonTurn30D);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonTime1D);
            this.Controls.Add(this.labelPlanetInformation);
            this.Controls.Add(this.listViewPlanetInformation);
            this.Controls.Add(this.labelPlanetName);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainScreen";
            this.Text = "Planetary Governor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPopulation.ResumeLayout(false);
            this.panelPopulationInfo.ResumeLayout(false);
            this.panelPopulationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPlanet;
        private System.Windows.Forms.TabPage tabProvinces;
        private System.Windows.Forms.TabPage tabPopulation;
        private System.Windows.Forms.Label labelPlanetName;
        private System.Windows.Forms.ListView listViewPlanetInformation;
        private System.Windows.Forms.Label labelPlanetInformation;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnValue;
        private System.Windows.Forms.TreeView treeViewPopulationBreakdown;
        private System.Windows.Forms.Label labelPopulationName;
        private System.Windows.Forms.Label labelPopulationIndustry;
        private System.Windows.Forms.ListView listViewIndustryBreakdown;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelPopulationGrowth;
        private System.Windows.Forms.Label labelPopulationSize;
        private System.Windows.Forms.Panel panelPopulationInfo;
        private System.Windows.Forms.Button buttonTime1D;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonTurn30D;
        private System.Windows.Forms.Button buttonTurn1Y;
    }
}

