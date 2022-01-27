
namespace HolmesRestorationManagementSystem.Ui
{
    partial class PropertyViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyViewForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CoolingCB = new System.Windows.Forms.ComboBox();
            this.HeatingCB = new System.Windows.Forms.ComboBox();
            this.ParkingCB = new System.Windows.Forms.ComboBox();
            this.FencedCB = new System.Windows.Forms.ComboBox();
            this.RentalCB = new System.Windows.Forms.ComboBox();
            this.OccupiedCB = new System.Windows.Forms.ComboBox();
            this.RentTxt = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.numBathsTxt = new System.Windows.Forms.TextBox();
            this.numRoomTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.PreopretyNumTxt = new System.Windows.Forms.TextBox();
            this.PropertyIdTxt = new System.Windows.Forms.TextBox();
            this.WorkTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.HousePbx = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PropertiesCB = new System.Windows.Forms.ComboBox();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.errorPv = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HousePbx)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditItem,
            this.DeleteItem,
            this.BackItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(71, 624);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EditItem
            // 
            this.EditItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(58, 24);
            this.EditItem.Text = "Edit";
            this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(58, 24);
            this.DeleteItem.Text = "Delete";
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // BackItem
            // 
            this.BackItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.BackItem.Name = "BackItem";
            this.BackItem.Size = new System.Drawing.Size(58, 24);
            this.BackItem.Text = "Back";
            this.BackItem.Click += new System.EventHandler(this.BackItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.groupBox1.Controls.Add(this.CoolingCB);
            this.groupBox1.Controls.Add(this.HeatingCB);
            this.groupBox1.Controls.Add(this.ParkingCB);
            this.groupBox1.Controls.Add(this.FencedCB);
            this.groupBox1.Controls.Add(this.RentalCB);
            this.groupBox1.Controls.Add(this.OccupiedCB);
            this.groupBox1.Controls.Add(this.RentTxt);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.numBathsTxt);
            this.groupBox1.Controls.Add(this.numRoomTxt);
            this.groupBox1.Controls.Add(this.addressTxt);
            this.groupBox1.Controls.Add(this.PreopretyNumTxt);
            this.groupBox1.Controls.Add(this.PropertyIdTxt);
            this.groupBox1.Controls.Add(this.WorkTxt);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.HousePbx);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            this.groupBox1.Location = new System.Drawing.Point(141, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 475);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Information";
            // 
            // CoolingCB
            // 
            this.CoolingCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.CoolingCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.CoolingCB.FormattingEnabled = true;
            this.CoolingCB.Location = new System.Drawing.Point(105, 426);
            this.CoolingCB.Name = "CoolingCB";
            this.CoolingCB.Size = new System.Drawing.Size(121, 26);
            this.CoolingCB.TabIndex = 34;
            // 
            // HeatingCB
            // 
            this.HeatingCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.HeatingCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.HeatingCB.FormattingEnabled = true;
            this.HeatingCB.Location = new System.Drawing.Point(105, 391);
            this.HeatingCB.Name = "HeatingCB";
            this.HeatingCB.Size = new System.Drawing.Size(121, 26);
            this.HeatingCB.TabIndex = 33;
            // 
            // ParkingCB
            // 
            this.ParkingCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.ParkingCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ParkingCB.FormattingEnabled = true;
            this.ParkingCB.Location = new System.Drawing.Point(105, 356);
            this.ParkingCB.Name = "ParkingCB";
            this.ParkingCB.Size = new System.Drawing.Size(121, 26);
            this.ParkingCB.TabIndex = 32;
            // 
            // FencedCB
            // 
            this.FencedCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.FencedCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.FencedCB.FormattingEnabled = true;
            this.FencedCB.Location = new System.Drawing.Point(105, 321);
            this.FencedCB.Name = "FencedCB";
            this.FencedCB.Size = new System.Drawing.Size(121, 26);
            this.FencedCB.TabIndex = 31;
            // 
            // RentalCB
            // 
            this.RentalCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.RentalCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.RentalCB.FormattingEnabled = true;
            this.RentalCB.Location = new System.Drawing.Point(105, 286);
            this.RentalCB.Name = "RentalCB";
            this.RentalCB.Size = new System.Drawing.Size(121, 26);
            this.RentalCB.TabIndex = 30;
            // 
            // OccupiedCB
            // 
            this.OccupiedCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.OccupiedCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.OccupiedCB.FormattingEnabled = true;
            this.OccupiedCB.Location = new System.Drawing.Point(105, 251);
            this.OccupiedCB.Name = "OccupiedCB";
            this.OccupiedCB.Size = new System.Drawing.Size(121, 26);
            this.OccupiedCB.TabIndex = 29;
            // 
            // RentTxt
            // 
            this.RentTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.RentTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.RentTxt.Location = new System.Drawing.Point(68, 204);
            this.RentTxt.Name = "RentTxt";
            this.RentTxt.ReadOnly = true;
            this.RentTxt.Size = new System.Drawing.Size(108, 24);
            this.RentTxt.TabIndex = 22;
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.Price.Location = new System.Drawing.Point(68, 175);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(108, 24);
            this.Price.TabIndex = 21;
            // 
            // numBathsTxt
            // 
            this.numBathsTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.numBathsTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.numBathsTxt.Location = new System.Drawing.Point(147, 146);
            this.numBathsTxt.Name = "numBathsTxt";
            this.numBathsTxt.ReadOnly = true;
            this.numBathsTxt.Size = new System.Drawing.Size(100, 24);
            this.numBathsTxt.TabIndex = 20;
            // 
            // numRoomTxt
            // 
            this.numRoomTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.numRoomTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.numRoomTxt.Location = new System.Drawing.Point(158, 117);
            this.numRoomTxt.Name = "numRoomTxt";
            this.numRoomTxt.ReadOnly = true;
            this.numRoomTxt.Size = new System.Drawing.Size(100, 24);
            this.numRoomTxt.TabIndex = 19;
            // 
            // addressTxt
            // 
            this.addressTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.addressTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.addressTxt.Location = new System.Drawing.Point(88, 88);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.ReadOnly = true;
            this.addressTxt.Size = new System.Drawing.Size(239, 24);
            this.addressTxt.TabIndex = 18;
            // 
            // PreopretyNumTxt
            // 
            this.PreopretyNumTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.PreopretyNumTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.PreopretyNumTxt.Location = new System.Drawing.Point(147, 59);
            this.PreopretyNumTxt.Name = "PreopretyNumTxt";
            this.PreopretyNumTxt.ReadOnly = true;
            this.PreopretyNumTxt.Size = new System.Drawing.Size(111, 24);
            this.PreopretyNumTxt.TabIndex = 17;
            // 
            // PropertyIdTxt
            // 
            this.PropertyIdTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.PropertyIdTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.PropertyIdTxt.Location = new System.Drawing.Point(105, 30);
            this.PropertyIdTxt.Name = "PropertyIdTxt";
            this.PropertyIdTxt.ReadOnly = true;
            this.PropertyIdTxt.Size = new System.Drawing.Size(78, 24);
            this.PropertyIdTxt.TabIndex = 16;
            // 
            // WorkTxt
            // 
            this.WorkTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.WorkTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.WorkTxt.Location = new System.Drawing.Point(275, 280);
            this.WorkTxt.Multiline = true;
            this.WorkTxt.Name = "WorkTxt";
            this.WorkTxt.ReadOnly = true;
            this.WorkTxt.Size = new System.Drawing.Size(442, 164);
            this.WorkTxt.TabIndex = 15;
            this.toolTip1.SetToolTip(this.WorkTxt, "Double click to edit work ");
            this.WorkTxt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WorkTxt_MouseDoubleClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(272, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 18);
            this.label14.TabIndex = 14;
            this.label14.Text = "Work Needed";
            this.label14.Visible = false;
            // 
            // HousePbx
            // 
            this.HousePbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.HousePbx.Image = ((System.Drawing.Image)(resources.GetObject("HousePbx.Image")));
            this.HousePbx.Location = new System.Drawing.Point(425, 36);
            this.HousePbx.Name = "HousePbx";
            this.HousePbx.Size = new System.Drawing.Size(279, 218);
            this.HousePbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HousePbx.TabIndex = 13;
            this.HousePbx.TabStop = false;
            this.toolTip1.SetToolTip(this.HousePbx, "Double click image to select a differnt image");
            this.HousePbx.Click += new System.EventHandler(this.HousePbx_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 426);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Cooling";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 391);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Heating";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Parking";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Fenced";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Rental";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Occupied";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Baths";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Rooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proeprty Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property Id";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.groupBox2.Controls.Add(this.PropertiesCB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            this.groupBox2.Location = new System.Drawing.Point(141, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 63);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Property";
            // 
            // PropertiesCB
            // 
            this.PropertiesCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.PropertiesCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.PropertiesCB.FormattingEnabled = true;
            this.PropertiesCB.Location = new System.Drawing.Point(105, 23);
            this.PropertiesCB.Name = "PropertiesCB";
            this.PropertiesCB.Size = new System.Drawing.Size(400, 26);
            this.PropertiesCB.TabIndex = 0;
            this.PropertiesCB.SelectionChangeCommitted += new System.EventHandler(this.PropertiesCB_SelectionChangeCommitted);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.AcceptBtn.Enabled = false;
            this.AcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            this.AcceptBtn.Location = new System.Drawing.Point(427, 583);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(97, 29);
            this.AcceptBtn.TabIndex = 6;
            this.AcceptBtn.Text = "Accept";
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Visible = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // errorPv
            // 
            this.errorPv.ContainerControl = this;
            this.errorPv.Icon = ((System.Drawing.Icon)(resources.GetObject("errorPv.Icon")));
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "openFileDialog1";
            // 
            // PropertyViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(944, 624);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PropertyViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Property View";
            this.Load += new System.EventHandler(this.PropertyViewForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HousePbx)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorPv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PropertyIdTxt;
        private System.Windows.Forms.TextBox WorkTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox HousePbx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RentTxt;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox numBathsTxt;
        private System.Windows.Forms.TextBox numRoomTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox PreopretyNumTxt;
        private System.Windows.Forms.ToolStripMenuItem BackItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox PropertiesCB;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.ComboBox OccupiedCB;
        private System.Windows.Forms.ComboBox RentalCB;
        private System.Windows.Forms.ComboBox FencedCB;
        private System.Windows.Forms.ComboBox ParkingCB;
        private System.Windows.Forms.ComboBox HeatingCB;
        private System.Windows.Forms.ComboBox CoolingCB;
        private System.Windows.Forms.ErrorProvider errorPv;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
    }
}