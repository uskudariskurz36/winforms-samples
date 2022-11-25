namespace WinFormsApp6_AracKiralama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.markaYönetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBrands = new System.Windows.Forms.ToolStripMenuItem();
            this.modelYönetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModels = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstVehicles = new System.Windows.Forms.ListBox();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picVehicle = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.chkIsRent = new System.Windows.Forms.CheckBox();
            this.nudDailyPrice = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.nudKM = new System.Windows.Forms.NumericUpDown();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnRent = new System.Windows.Forms.Button();
            this.txtCustomerTCNo = new System.Windows.Forms.TextBox();
            this.nudDownPayment = new System.Windows.Forms.NumericUpDown();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstCustomerRents = new System.Windows.Forms.ListBox();
            this.btnDeleteRent = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKM)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownPayment)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.markaYönetToolStripMenuItem,
            this.modelYönetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnRestart,
            this.toolStripMenuItem1,
            this.btnExit});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 22);
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(150, 22);
            this.btnRestart.Text = "Yeniden Başlat";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 22);
            this.btnExit.Text = "Çıkış";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // markaYönetToolStripMenuItem
            // 
            this.markaYönetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBrands});
            this.markaYönetToolStripMenuItem.Name = "markaYönetToolStripMenuItem";
            this.markaYönetToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.markaYönetToolStripMenuItem.Text = "Marka Yönet";
            // 
            // btnBrands
            // 
            this.btnBrands.Name = "btnBrands";
            this.btnBrands.Size = new System.Drawing.Size(120, 22);
            this.btnBrands.Text = "Markalar";
            this.btnBrands.Click += new System.EventHandler(this.btnBrands_Click);
            // 
            // modelYönetToolStripMenuItem
            // 
            this.modelYönetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModels});
            this.modelYönetToolStripMenuItem.Name = "modelYönetToolStripMenuItem";
            this.modelYönetToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.modelYönetToolStripMenuItem.Text = "Model Yönet";
            // 
            // btnModels
            // 
            this.btnModels.Name = "btnModels";
            this.btnModels.Size = new System.Drawing.Size(121, 22);
            this.btnModels.Text = "Modeller";
            this.btnModels.Click += new System.EventHandler(this.btnModels_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstVehicles);
            this.groupBox1.Location = new System.Drawing.Point(13, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(200, 373);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araçlar";
            // 
            // lstVehicles
            // 
            this.lstVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVehicles.FormattingEnabled = true;
            this.lstVehicles.ItemHeight = 15;
            this.lstVehicles.Location = new System.Drawing.Point(8, 24);
            this.lstVehicles.Name = "lstVehicles";
            this.lstVehicles.Size = new System.Drawing.Size(184, 341);
            this.lstVehicles.TabIndex = 0;
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Location = new System.Drawing.Point(130, 415);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteVehicle.TabIndex = 2;
            this.btnDeleteVehicle.Text = "Sil";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picVehicle);
            this.groupBox2.Controls.Add(this.btnSelectImage);
            this.groupBox2.Controls.Add(this.chkIsRent);
            this.groupBox2.Controls.Add(this.nudDailyPrice);
            this.groupBox2.Controls.Add(this.nudYear);
            this.groupBox2.Controls.Add(this.nudKM);
            this.groupBox2.Controls.Add(this.cmbModel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbBrand);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(218, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 373);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // picVehicle
            // 
            this.picVehicle.Location = new System.Drawing.Point(6, 272);
            this.picVehicle.Name = "picVehicle";
            this.picVehicle.Size = new System.Drawing.Size(188, 74);
            this.picVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVehicle.TabIndex = 4;
            this.picVehicle.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectImage.Location = new System.Drawing.Point(119, 348);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(75, 19);
            this.btnSelectImage.TabIndex = 2;
            this.btnSelectImage.Text = "Resim Seç";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // chkIsRent
            // 
            this.chkIsRent.AutoSize = true;
            this.chkIsRent.Location = new System.Drawing.Point(6, 247);
            this.chkIsRent.Name = "chkIsRent";
            this.chkIsRent.Size = new System.Drawing.Size(88, 19);
            this.chkIsRent.TabIndex = 3;
            this.chkIsRent.Text = "Kiralanabilir";
            this.chkIsRent.UseVisualStyleBackColor = true;
            // 
            // nudDailyPrice
            // 
            this.nudDailyPrice.DecimalPlaces = 2;
            this.nudDailyPrice.Location = new System.Drawing.Point(6, 218);
            this.nudDailyPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudDailyPrice.Name = "nudDailyPrice";
            this.nudDailyPrice.Size = new System.Drawing.Size(188, 23);
            this.nudDailyPrice.TabIndex = 2;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(6, 174);
            this.nudYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(188, 23);
            this.nudYear.TabIndex = 2;
            this.nudYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nudKM
            // 
            this.nudKM.Location = new System.Drawing.Point(6, 130);
            this.nudKM.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudKM.Name = "nudKM";
            this.nudKM.Size = new System.Drawing.Size(188, 23);
            this.nudKM.TabIndex = 2;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(6, 86);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(188, 23);
            this.cmbModel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Günlük Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "KM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modeller";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(6, 42);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(188, 23);
            this.cmbBrand.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Markalar";
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(344, 415);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnAddVehicle.TabIndex = 2;
            this.btnAddVehicle.Text = "Ekle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpEndDate);
            this.groupBox3.Controls.Add(this.dtpStartDate);
            this.groupBox3.Controls.Add(this.btnRent);
            this.groupBox3.Controls.Add(this.txtCustomerTCNo);
            this.groupBox3.Controls.Add(this.nudDownPayment);
            this.groupBox3.Controls.Add(this.txtCustomerName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(424, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 373);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kiralayan Bilgileri";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(6, 174);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(188, 23);
            this.dtpEndDate.TabIndex = 2;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(6, 130);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(188, 23);
            this.dtpStartDate.TabIndex = 2;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(119, 247);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 2;
            this.btnRent.Text = "Kirala";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // txtCustomerTCNo
            // 
            this.txtCustomerTCNo.Location = new System.Drawing.Point(6, 86);
            this.txtCustomerTCNo.Name = "txtCustomerTCNo";
            this.txtCustomerTCNo.Size = new System.Drawing.Size(188, 23);
            this.txtCustomerTCNo.TabIndex = 1;
            // 
            // nudDownPayment
            // 
            this.nudDownPayment.DecimalPlaces = 2;
            this.nudDownPayment.Location = new System.Drawing.Point(6, 218);
            this.nudDownPayment.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudDownPayment.Name = "nudDownPayment";
            this.nudDownPayment.Size = new System.Drawing.Size(188, 23);
            this.nudDownPayment.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(6, 42);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(188, 23);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Müşteri TC No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bitiş Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Başlangıç Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kaparo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Müşteri Ad Soyad";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstCustomerRents);
            this.groupBox4.Location = new System.Drawing.Point(630, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox4.Size = new System.Drawing.Size(474, 373);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kiralama Listesi";
            // 
            // lstCustomerRents
            // 
            this.lstCustomerRents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCustomerRents.FormattingEnabled = true;
            this.lstCustomerRents.ItemHeight = 15;
            this.lstCustomerRents.Location = new System.Drawing.Point(8, 24);
            this.lstCustomerRents.Name = "lstCustomerRents";
            this.lstCustomerRents.Size = new System.Drawing.Size(458, 341);
            this.lstCustomerRents.TabIndex = 0;
            // 
            // btnDeleteRent
            // 
            this.btnDeleteRent.Location = new System.Drawing.Point(1021, 417);
            this.btnDeleteRent.Name = "btnDeleteRent";
            this.btnDeleteRent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRent.TabIndex = 2;
            this.btnDeleteRent.Text = "Sil";
            this.btnDeleteRent.UseVisualStyleBackColor = true;
            this.btnDeleteRent.Click += new System.EventHandler(this.btnDeleteRent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.btnDeleteRent);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKM)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownPayment)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem btnExit;
        private ToolStripMenuItem btnSave;
        private ToolStripMenuItem btnRestart;
        private ToolStripMenuItem markaYönetToolStripMenuItem;
        private ToolStripMenuItem modelYönetToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem btnBrands;
        private ToolStripMenuItem btnModels;
        private GroupBox groupBox1;
        private ListBox lstVehicles;
        private Button btnDeleteVehicle;
        private GroupBox groupBox2;
        private PictureBox picVehicle;
        private Button btnSelectImage;
        private CheckBox chkIsRent;
        private NumericUpDown nudDailyPrice;
        private NumericUpDown nudYear;
        private NumericUpDown nudKM;
        private ComboBox cmbModel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbBrand;
        private Label label1;
        private Button btnAddVehicle;
        private GroupBox groupBox3;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Button btnRent;
        private TextBox txtCustomerTCNo;
        private NumericUpDown nudDownPayment;
        private TextBox txtCustomerName;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label10;
        private Label label6;
        private GroupBox groupBox4;
        private ListBox lstCustomerRents;
        private Button btnDeleteRent;
    }
}