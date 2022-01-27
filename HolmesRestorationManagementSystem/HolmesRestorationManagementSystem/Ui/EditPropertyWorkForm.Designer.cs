
namespace HolmesRestorationManagementSystem.Ui
{
    partial class EditPropertyWorkForm
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.WorkDG = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.addressLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WorkDG)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            // 
            // WorkDG
            // 
            this.WorkDG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(154)))), ((int)(((byte)(104)))));
            this.WorkDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.WorkDG.Location = new System.Drawing.Point(12, 107);
            this.WorkDG.Name = "WorkDG";
            this.WorkDG.Size = new System.Drawing.Size(720, 188);
            this.WorkDG.TabIndex = 9;
            this.toolTip1.SetToolTip(this.WorkDG, "Double click cell to edit value");
            this.WorkDG.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkDG_CellValueChanged);
            this.WorkDG.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkDG_RowLeave);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            this.lbl.Location = new System.Drawing.Point(265, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(214, 25);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "All Work for Address:";
            // 
            // addressLBL
            // 
            this.addressLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(109)))));
            this.addressLBL.Location = new System.Drawing.Point(175, 48);
            this.addressLBL.Name = "addressLBL";
            this.addressLBL.Size = new System.Drawing.Size(394, 24);
            this.addressLBL.TabIndex = 11;
            this.addressLBL.Text = "selected address";
            this.addressLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditPropertyWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(744, 307);
            this.Controls.Add(this.addressLBL);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.WorkDG);
            this.Name = "EditPropertyWorkForm";
            this.Text = "EditPropertyWorkForm";
            this.Load += new System.EventHandler(this.EditPropertyWorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView WorkDG;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label addressLBL;
    }
}