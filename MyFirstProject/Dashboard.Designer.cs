namespace MyFirstProject
{
    partial class frmDashboard
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
            dgvDashboard = new DataGridView();
            btnX = new Button();
            txtSearch = new TextBox();
            btnxSearch = new Button();
            btnxDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDashboard).BeginInit();
            SuspendLayout();
            // 
            // dgvDashboard
            // 
            dgvDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDashboard.Location = new Point(45, 101);
            dgvDashboard.Name = "dgvDashboard";
            dgvDashboard.Size = new Size(715, 332);
            dgvDashboard.TabIndex = 0;
            // 
            // btnX
            // 
            btnX.BackColor = Color.Red;
            btnX.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnX.Location = new Point(756, 12);
            btnX.Name = "btnX";
            btnX.Size = new Size(32, 29);
            btnX.TabIndex = 38;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += btnX_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ScrollBar;
            txtSearch.Location = new Point(134, 454);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(231, 23);
            txtSearch.TabIndex = 40;
            // 
            // btnxSearch
            // 
            btnxSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnxSearch.Location = new Point(44, 453);
            btnxSearch.Name = "btnxSearch";
            btnxSearch.Size = new Size(75, 23);
            btnxSearch.TabIndex = 41;
            btnxSearch.Text = "Search";
            btnxSearch.UseVisualStyleBackColor = true;
            btnxSearch.Click += btnxSearch_Click;
            // 
            // btnxDelete
            // 
            btnxDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnxDelete.Location = new Point(482, 453);
            btnxDelete.Name = "btnxDelete";
            btnxDelete.Size = new Size(75, 23);
            btnxDelete.TabIndex = 42;
            btnxDelete.Text = "Delete";
            btnxDelete.UseVisualStyleBackColor = true;
            btnxDelete.Click += btnxDelete_Click;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(800, 584);
            Controls.Add(btnxDelete);
            Controls.Add(btnxSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnX);
            Controls.Add(dgvDashboard);
            Name = "frmDashboard";
            Text = "Dashboard";
            Load += frmDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDashboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDashboard;
        private Button btnX;
        private TextBox txtSearch;
        private Button btnxSearch;
        private Button btnxDelete;
    }
}