
namespace HolmesRestorationManagementSystem.Ui
{
    partial class TenantViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TenantViewForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisabledCB = new System.Windows.Forms.ComboBox();
            this.EmpLengthTxt = new System.Windows.Forms.TextBox();
            this.OccupationTxt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.LnameTxt = new System.Windows.Forms.TextBox();
            this.FnameTxt = new System.Windows.Forms.TextBox();
            this.IdTxt = new System.Windows.Forms.TextBox();
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
            this.TenantCB = new System.Windows.Forms.ComboBox();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.AssistanceCB = new System.Windows.Forms.ComboBox();
            this.errorPv = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(126, 532);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EditItem
            // 
            this.EditItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(113, 24);
            this.EditItem.Text = "Edit";
            this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(113, 24);
            this.DeleteItem.Text = "Delete";
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // BackItem
            // 
            this.BackItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.BackItem.Name = "BackItem";
            this.BackItem.Size = new System.Drawing.Size(113, 24);
            this.BackItem.Text = "Back";
            this.BackItem.Click += new System.EventHandler(this.BackItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.groupBox1.Controls.Add(this.AssistanceCB);
            this.groupBox1.Controls.Add(this.DisabledCB);
            this.groupBox1.Controls.Add(this.EmpLengthTxt);
            this.groupBox1.Controls.Add(this.OccupationTxt);
            this.groupBox1.Controls.Add(this.AddressTxt);
            this.groupBox1.Controls.Add(this.PhoneTxt);
            this.groupBox1.Controls.Add(this.LnameTxt);
            this.groupBox1.Controls.Add(this.FnameTxt);
            this.groupBox1.Controls.Add(this.IdTxt);
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
            this.groupBox1.Location = new System.Drawing.Point(138, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tenant Information";
            // 
            // DisabledCB
            // 
            this.DisabledCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.DisabledCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.DisabledCB.FormattingEnabled = true;
            this.DisabledCB.Location = new System.Drawing.Point(149, 287);
            this.DisabledCB.Name = "DisabledCB";
            this.DisabledCB.Size = new System.Drawing.Size(121, 26);
            this.DisabledCB.TabIndex = 30;
            // 
            // EmpLengthTxt
            // 
            this.EmpLengthTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.EmpLengthTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.EmpLengthTxt.Location = new System.Drawing.Point(236, 254);
            this.EmpLengthTxt.Name = "EmpLengthTxt";
            this.EmpLengthTxt.ReadOnly = true;
            this.EmpLengthTxt.Size = new System.Drawing.Size(113, 24);
            this.EmpLengthTxt.TabIndex = 16;
            // 
            // OccupationTxt
            // 
            this.OccupationTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.OccupationTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.OccupationTxt.Location = new System.Drawing.Point(164, 219);
            this.OccupationTxt.Name = "OccupationTxt";
            this.OccupationTxt.ReadOnly = true;
            this.OccupationTxt.Size = new System.Drawing.Size(185, 24);
            this.OccupationTxt.TabIndex = 15;
            // 
            // AddressTxt
            // 
            this.AddressTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.AddressTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.AddressTxt.Location = new System.Drawing.Point(142, 184);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.ReadOnly = true;
            this.AddressTxt.Size = new System.Drawing.Size(294, 24);
            this.AddressTxt.TabIndex = 14;
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.PhoneTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.PhoneTxt.Location = new System.Drawing.Point(188, 149);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.ReadOnly = true;
            this.PhoneTxt.Size = new System.Drawing.Size(161, 24);
            this.PhoneTxt.TabIndex = 13;
            // 
            // LnameTxt
            // 
            this.LnameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.LnameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.LnameTxt.Location = new System.Drawing.Point(161, 114);
            this.LnameTxt.Name = "LnameTxt";
            this.LnameTxt.ReadOnly = true;
            this.LnameTxt.Size = new System.Drawing.Size(226, 24);
            this.LnameTxt.TabIndex = 12;
            // 
            // FnameTxt
            // 
            this.FnameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.FnameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.FnameTxt.Location = new System.Drawing.Point(161, 79);
            this.FnameTxt.Name = "FnameTxt";
            this.FnameTxt.ReadOnly = true;
            this.FnameTxt.Size = new System.Drawing.Size(188, 24);
            this.FnameTxt.TabIndex = 11;
            // 
            // IdTxt
            // 
            this.IdTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.IdTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.IdTxt.Location = new System.Drawing.Point(99, 44);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.ReadOnly = true;
            this.IdTxt.Size = new System.Drawing.Size(100, 24);
            this.IdTxt.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Government Assistance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Disabled";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Length of Employment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Occupation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.groupBox2.Controls.Add(this.TenantCB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            this.groupBox2.Location = new System.Drawing.Point(138, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Tenant";
            // 
            // TenantCB
            // 
            this.TenantCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.TenantCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.TenantCB.FormattingEnabled = true;
            this.TenantCB.Location = new System.Drawing.Point(99, 23);
            this.TenantCB.Name = "TenantCB";
            this.TenantCB.Size = new System.Drawing.Size(278, 26);
            this.TenantCB.TabIndex = 0;
            this.TenantCB.SelectedIndexChanged += new System.EventHandler(this.TenantCB_SelectedIndexChanged);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.AcceptBtn.Enabled = false;
            this.AcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            this.AcceptBtn.Location = new System.Drawing.Point(311, 491);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(97, 29);
            this.AcceptBtn.TabIndex = 6;
            this.AcceptBtn.Text = "Accept";
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Visible = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // AssistanceCB
            // 
            this.AssistanceCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.AssistanceCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.AssistanceCB.FormattingEnabled = true;
            this.AssistanceCB.Location = new System.Drawing.Point(246, 322);
            this.AssistanceCB.Name = "AssistanceCB";
            this.AssistanceCB.Size = new System.Drawing.Size(141, 26);
            this.AssistanceCB.TabIndex = 31;
            // 
            // errorPv
            // 
            this.errorPv.ContainerControl = this;
            this.errorPv.Icon = ((System.Drawing.Icon)(resources.GetObject("errorPv.Icon")));
            // 
            // TenantViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(718, 532);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TenantViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TenantViewForm";
            this.Load += new System.EventHandler(this.TenantViewForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem BackItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpLengthTxt;
        private System.Windows.Forms.TextBox OccupationTxt;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.TextBox LnameTxt;
        private System.Windows.Forms.TextBox FnameTxt;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox TenantCB;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.ComboBox DisabledCB;
        private System.Windows.Forms.ComboBox AssistanceCB;
        private System.Windows.Forms.ErrorProvider errorPv;
    }
}