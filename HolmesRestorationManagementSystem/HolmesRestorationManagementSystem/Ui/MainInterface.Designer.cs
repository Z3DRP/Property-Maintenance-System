
namespace HolmesRestorationManagementSystem.Ui
{
    partial class MainInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ReportsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertyReportItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TenantReportItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkReportItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagementMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagePropertyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageTenantItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageWorkItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertyViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TenantViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateLeaseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendMessageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RequestInspectionItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usrLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportsMenu,
            this.ManagementMenu,
            this.ViewMenu,
            this.ToolsMenu,
            this.Admin,
            this.HelpItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 338);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ReportsMenu
            // 
            this.ReportsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PropertyReportItem,
            this.TenantReportItem,
            this.WorkReportItem});
            this.ReportsMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ReportsMenu.Name = "ReportsMenu";
            this.ReportsMenu.Size = new System.Drawing.Size(113, 25);
            this.ReportsMenu.Text = "Reports";
            this.ReportsMenu.ToolTipText = "View Reports For Different Items";
            // 
            // PropertyReportItem
            // 
            this.PropertyReportItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.PropertyReportItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.PropertyReportItem.Name = "PropertyReportItem";
            this.PropertyReportItem.Size = new System.Drawing.Size(191, 26);
            this.PropertyReportItem.Text = "Property Report";
            this.PropertyReportItem.ToolTipText = "Report of Current Properties";
            this.PropertyReportItem.Click += new System.EventHandler(this.PropertyReportItem_Click);
            // 
            // TenantReportItem
            // 
            this.TenantReportItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.TenantReportItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.TenantReportItem.Name = "TenantReportItem";
            this.TenantReportItem.Size = new System.Drawing.Size(191, 26);
            this.TenantReportItem.Text = "Tenant Report";
            this.TenantReportItem.ToolTipText = "Report of Current Tenants";
            this.TenantReportItem.Click += new System.EventHandler(this.TenantReportItem_Click);
            // 
            // WorkReportItem
            // 
            this.WorkReportItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.WorkReportItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.WorkReportItem.Name = "WorkReportItem";
            this.WorkReportItem.Size = new System.Drawing.Size(191, 26);
            this.WorkReportItem.Text = "Work Report";
            this.WorkReportItem.ToolTipText = "Report of Work Needed on Properties";
            this.WorkReportItem.Click += new System.EventHandler(this.WorkReportItem_Click);
            // 
            // ManagementMenu
            // 
            this.ManagementMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManagePropertyItem,
            this.ManageTenantItem,
            this.ManageWorkItem});
            this.ManagementMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ManagementMenu.Name = "ManagementMenu";
            this.ManagementMenu.Size = new System.Drawing.Size(113, 25);
            this.ManagementMenu.Text = "Manage";
            this.ManagementMenu.ToolTipText = "Manage Properties and Tenants";
            // 
            // ManagePropertyItem
            // 
            this.ManagePropertyItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.ManagePropertyItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ManagePropertyItem.Name = "ManagePropertyItem";
            this.ManagePropertyItem.Size = new System.Drawing.Size(151, 26);
            this.ManagePropertyItem.Text = "Properties";
            this.ManagePropertyItem.ToolTipText = "Add, Delete, Update, View Properties";
            this.ManagePropertyItem.Click += new System.EventHandler(this.PropertyItem_Click);
            // 
            // ManageTenantItem
            // 
            this.ManageTenantItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.ManageTenantItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ManageTenantItem.Name = "ManageTenantItem";
            this.ManageTenantItem.Size = new System.Drawing.Size(151, 26);
            this.ManageTenantItem.Text = "Tenants";
            this.ManageTenantItem.ToolTipText = "Add, Delete, Update, View Tenants";
            this.ManageTenantItem.Click += new System.EventHandler(this.TenantItem_Click);
            // 
            // ManageWorkItem
            // 
            this.ManageWorkItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.ManageWorkItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ManageWorkItem.Name = "ManageWorkItem";
            this.ManageWorkItem.Size = new System.Drawing.Size(151, 26);
            this.ManageWorkItem.Text = "Work";
            this.ManageWorkItem.Click += new System.EventHandler(this.WorkItem_Click);
            // 
            // ViewMenu
            // 
            this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PropertyViewItem,
            this.TenantViewItem,
            this.WorkViewItem});
            this.ViewMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(113, 25);
            this.ViewMenu.Text = "View";
            // 
            // PropertyViewItem
            // 
            this.PropertyViewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.PropertyViewItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.PropertyViewItem.Name = "PropertyViewItem";
            this.PropertyViewItem.Size = new System.Drawing.Size(140, 26);
            this.PropertyViewItem.Text = "Property";
            this.PropertyViewItem.Click += new System.EventHandler(this.PropertyViewItem_Click);
            // 
            // TenantViewItem
            // 
            this.TenantViewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.TenantViewItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.TenantViewItem.Name = "TenantViewItem";
            this.TenantViewItem.Size = new System.Drawing.Size(140, 26);
            this.TenantViewItem.Text = "Tenant";
            this.TenantViewItem.Click += new System.EventHandler(this.TenantViewItem_Click);
            // 
            // WorkViewItem
            // 
            this.WorkViewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.WorkViewItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.WorkViewItem.Name = "WorkViewItem";
            this.WorkViewItem.Size = new System.Drawing.Size(140, 26);
            this.WorkViewItem.Text = "Work";
            this.WorkViewItem.Click += new System.EventHandler(this.WorkViewItem_Click);
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateLeaseItem,
            this.SendMessageItem,
            this.RequestInspectionItem});
            this.ToolsMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(113, 25);
            this.ToolsMenu.Text = "Tools";
            this.ToolsMenu.ToolTipText = "Tools to Create Lease, Send Tenant Messages, and Request Inspections";
            // 
            // CreateLeaseItem
            // 
            this.CreateLeaseItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.CreateLeaseItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.CreateLeaseItem.Name = "CreateLeaseItem";
            this.CreateLeaseItem.Size = new System.Drawing.Size(211, 26);
            this.CreateLeaseItem.Text = "Create Lease";
            this.CreateLeaseItem.ToolTipText = "Create a Lease for Specific Tenant";
            // 
            // SendMessageItem
            // 
            this.SendMessageItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.SendMessageItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.SendMessageItem.Name = "SendMessageItem";
            this.SendMessageItem.Size = new System.Drawing.Size(211, 26);
            this.SendMessageItem.Text = "Send Message";
            this.SendMessageItem.ToolTipText = "Send Tenant a Text Message";
            this.SendMessageItem.Click += new System.EventHandler(this.SendMessageItem_Click);
            // 
            // RequestInspectionItem
            // 
            this.RequestInspectionItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.RequestInspectionItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.RequestInspectionItem.Name = "RequestInspectionItem";
            this.RequestInspectionItem.Size = new System.Drawing.Size(211, 26);
            this.RequestInspectionItem.Text = "Request Inspection";
            this.RequestInspectionItem.ToolTipText = "Request Property Inspection";
            // 
            // Admin
            // 
            this.Admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(113, 25);
            this.Admin.Text = "Admin";
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // HelpItem
            // 
            this.HelpItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.HelpItem.Name = "HelpItem";
            this.HelpItem.Size = new System.Drawing.Size(113, 25);
            this.HelpItem.Text = "Help";
            this.HelpItem.Click += new System.EventHandler(this.HelpItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.groupBox1.Controls.Add(this.usrLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            this.groupBox1.Location = new System.Drawing.Point(132, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 271);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // usrLbl
            // 
            this.usrLbl.AutoSize = true;
            this.usrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrLbl.Location = new System.Drawing.Point(172, 145);
            this.usrLbl.Name = "usrLbl";
            this.usrLbl.Size = new System.Drawing.Size(155, 33);
            this.usrLbl.TabIndex = 1;
            this.usrLbl.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Back";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(680, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Center";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ReportsMenu;
        private System.Windows.Forms.ToolStripMenuItem PropertyReportItem;
        private System.Windows.Forms.ToolStripMenuItem TenantReportItem;
        private System.Windows.Forms.ToolStripMenuItem WorkReportItem;
        private System.Windows.Forms.ToolStripMenuItem ManagementMenu;
        private System.Windows.Forms.ToolStripMenuItem ManagePropertyItem;
        private System.Windows.Forms.ToolStripMenuItem ManageTenantItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem CreateLeaseItem;
        private System.Windows.Forms.ToolStripMenuItem SendMessageItem;
        private System.Windows.Forms.ToolStripMenuItem RequestInspectionItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem ManageWorkItem;
        private System.Windows.Forms.ToolStripMenuItem HelpItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label usrLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ViewMenu;
        private System.Windows.Forms.ToolStripMenuItem PropertyViewItem;
        private System.Windows.Forms.ToolStripMenuItem TenantViewItem;
        private System.Windows.Forms.ToolStripMenuItem WorkViewItem;
        private System.Windows.Forms.ToolStripMenuItem Admin;
    }
}