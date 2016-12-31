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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPlanet = new System.Windows.Forms.TabPage();
            this.tabProvinces = new System.Windows.Forms.TabPage();
            this.tabPopulation = new System.Windows.Forms.TabPage();
            this.labelPlanetName = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listViewPlanetInformation = new System.Windows.Forms.ListView();
            this.labelPlanetInformation = new System.Windows.Forms.Label();
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPopulation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1063, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPlanet);
            this.tabControl1.Controls.Add(this.tabProvinces);
            this.tabControl1.Controls.Add(this.tabPopulation);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 644);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPlanet
            // 
            this.tabPlanet.Location = new System.Drawing.Point(4, 22);
            this.tabPlanet.Name = "tabPlanet";
            this.tabPlanet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlanet.Size = new System.Drawing.Size(1037, 618);
            this.tabPlanet.TabIndex = 0;
            this.tabPlanet.Text = "Planet";
            this.tabPlanet.UseVisualStyleBackColor = true;
            // 
            // tabProvinces
            // 
            this.tabProvinces.Location = new System.Drawing.Point(4, 22);
            this.tabProvinces.Name = "tabProvinces";
            this.tabProvinces.Padding = new System.Windows.Forms.Padding(3);
            this.tabProvinces.Size = new System.Drawing.Size(1037, 618);
            this.tabProvinces.TabIndex = 1;
            this.tabProvinces.Text = "Provinces";
            this.tabProvinces.UseVisualStyleBackColor = true;
            // 
            // tabPopulation
            // 
            this.tabPopulation.Controls.Add(this.listView1);
            this.tabPopulation.Location = new System.Drawing.Point(4, 22);
            this.tabPopulation.Name = "tabPopulation";
            this.tabPopulation.Size = new System.Drawing.Size(1037, 618);
            this.tabPopulation.TabIndex = 2;
            this.tabPopulation.Text = "Population";
            this.tabPopulation.UseVisualStyleBackColor = true;
            // 
            // labelPlanetName
            // 
            this.labelPlanetName.AutoSize = true;
            this.labelPlanetName.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlanetName.Location = new System.Drawing.Point(1063, 12);
            this.labelPlanetName.Name = "labelPlanetName";
            this.labelPlanetName.Size = new System.Drawing.Size(124, 17);
            this.labelPlanetName.TabIndex = 0;
            this.labelPlanetName.Text = "labelPlanetName";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(788, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(246, 612);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listViewPlanetInformation
            // 
            this.listViewPlanetInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnType,
            this.columnValue});
            this.listViewPlanetInformation.GridLines = true;
            this.listViewPlanetInformation.Location = new System.Drawing.Point(1064, 313);
            this.listViewPlanetInformation.Name = "listViewPlanetInformation";
            this.listViewPlanetInformation.Size = new System.Drawing.Size(255, 343);
            this.listViewPlanetInformation.TabIndex = 3;
            this.listViewPlanetInformation.UseCompatibleStateImageBehavior = false;
            this.listViewPlanetInformation.View = System.Windows.Forms.View.Details;
            // 
            // labelPlanetInformation
            // 
            this.labelPlanetInformation.AutoSize = true;
            this.labelPlanetInformation.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlanetInformation.Location = new System.Drawing.Point(1063, 293);
            this.labelPlanetInformation.Name = "labelPlanetInformation";
            this.labelPlanetInformation.Size = new System.Drawing.Size(168, 17);
            this.labelPlanetInformation.TabIndex = 4;
            this.labelPlanetInformation.Text = "labelPlanetInformation";
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
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 668);
            this.Controls.Add(this.labelPlanetInformation);
            this.Controls.Add(this.listViewPlanetInformation);
            this.Controls.Add(this.labelPlanetName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainScreen";
            this.Text = "Planetary Governor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPopulation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPlanet;
        private System.Windows.Forms.TabPage tabProvinces;
        private System.Windows.Forms.TabPage tabPopulation;
        private System.Windows.Forms.Label labelPlanetName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listViewPlanetInformation;
        private System.Windows.Forms.Label labelPlanetInformation;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnValue;
    }
}

