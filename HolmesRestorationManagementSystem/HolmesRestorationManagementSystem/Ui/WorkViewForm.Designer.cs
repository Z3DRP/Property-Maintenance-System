
namespace HolmesRestorationManagementSystem.Ui
{
    partial class WorkViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkViewForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.BackBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.completionDateDP = new System.Windows.Forms.DateTimePicker();
            this.WorkTxt = new System.Windows.Forms.TextBox();
            this.PriorityLevelTxt = new System.Windows.Forms.TextBox();
            this.PropertyIdTxt = new System.Windows.Forms.TextBox();
            this.WorkIdTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PropertiesCB = new System.Windows.Forms.ComboBox();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.errorPv = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WorkCB = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditItem,
            this.DeleteBtn,
            this.BackBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 526);
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
            // DeleteBtn
            // 
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(113, 24);
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(113, 24);
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.groupBox1.Controls.Add(this.completionDateDP);
            this.groupBox1.Controls.Add(this.WorkTxt);
            this.groupBox1.Controls.Add(this.PriorityLevelTxt);
            this.groupBox1.Controls.Add(this.PropertyIdTxt);
            this.groupBox1.Controls.Add(this.WorkIdTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            this.groupBox1.Location = new System.Drawing.Point(150, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Work Information";
            // 
            // completionDateDP
            // 
            this.completionDateDP.Location = new System.Drawing.Point(209, 107);
            this.completionDateDP.Name = "completionDateDP";
            this.completionDateDP.Size = new System.Drawing.Size(200, 24);
            this.completionDateDP.TabIndex = 16;
            // 
            // WorkTxt
            // 
            this.WorkTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.WorkTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.WorkTxt.Location = new System.Drawing.Point(138, 155);
            this.WorkTxt.Multiline = true;
            this.WorkTxt.Name = "WorkTxt";
            this.WorkTxt.ReadOnly = true;
            this.WorkTxt.Size = new System.Drawing.Size(393, 123);
            this.WorkTxt.TabIndex = 15;
            // 
            // PriorityLevelTxt
            // 
            this.PriorityLevelTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.PriorityLevelTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.PriorityLevelTxt.Location = new System.Drawing.Point(476, 50);
            this.PriorityLevelTxt.Name = "PriorityLevelTxt";
            this.PriorityLevelTxt.ReadOnly = true;
            this.PriorityLevelTxt.Size = new System.Drawing.Size(55, 24);
            this.PriorityLevelTxt.TabIndex = 12;
            // 
            // PropertyIdTxt
            // 
            this.PropertyIdTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.PropertyIdTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.PropertyIdTxt.Location = new System.Drawing.Point(256, 50);
            this.PropertyIdTxt.Name = "PropertyIdTxt";
            this.PropertyIdTxt.ReadOnly = true;
            this.PropertyIdTxt.Size = new System.Drawing.Size(100, 24);
            this.PropertyIdTxt.TabIndex = 11;
            // 
            // WorkIdTxt
            // 
            this.WorkIdTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.WorkIdTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.WorkIdTxt.Location = new System.Drawing.Point(54, 50);
            this.WorkIdTxt.Name = "WorkIdTxt";
            this.WorkIdTxt.ReadOnly = true;
            this.WorkIdTxt.Size = new System.Drawing.Size(100, 24);
            this.WorkIdTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Work Needed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Priority Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Property Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desired Completion Date";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(29, 59);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(19, 18);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.groupBox2.Controls.Add(this.PropertiesCB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            this.groupBox2.Location = new System.Drawing.Point(150, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 63);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Property";
            // 
            // PropertiesCB
            // 
            this.PropertiesCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.PropertiesCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.PropertiesCB.FormattingEnabled = true;
            this.PropertiesCB.Location = new System.Drawing.Point(99, 23);
            this.PropertiesCB.Name = "PropertiesCB";
            this.PropertiesCB.Size = new System.Drawing.Size(278, 26);
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
            this.AcceptBtn.Location = new System.Drawing.Point(359, 485);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(97, 29);
            this.AcceptBtn.TabIndex = 5;
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.groupBox3.Controls.Add(this.WorkCB);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            this.groupBox3.Location = new System.Drawing.Point(150, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 63);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Work";
            // 
            // WorkCB
            // 
            this.WorkCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.WorkCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.WorkCB.FormattingEnabled = true;
            this.WorkCB.Location = new System.Drawing.Point(99, 23);
            this.WorkCB.Name = "WorkCB";
            this.WorkCB.Size = new System.Drawing.Size(278, 26);
            this.WorkCB.TabIndex = 0;
            this.WorkCB.SelectionChangeCommitted += new System.EventHandler(this.WorkCB_SelectionChangeCommitted);
            // 
            // WorkViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorkViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkViewForm";
            this.Load += new System.EventHandler(this.WorkViewForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorPv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteBtn;
        private System.Windows.Forms.ToolStripMenuItem BackBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriorityLevelTxt;
        private System.Windows.Forms.TextBox PropertyIdTxt;
        private System.Windows.Forms.TextBox WorkIdTxt;
        private System.Windows.Forms.TextBox WorkTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox PropertiesCB;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.DateTimePicker completionDateDP;
        private System.Windows.Forms.ErrorProvider errorPv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox WorkCB;
    }
}