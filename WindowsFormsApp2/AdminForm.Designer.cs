using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class AdminForm
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
            dgvTrains = new DataGridView();
            txtSearch = new TextBox();
            btnLoad = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTrains).BeginInit();
            SuspendLayout();
            // 
            // dgvTrains
            // 
            dgvTrains.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrains.Location = new Point(99, 56);
            dgvTrains.Name = "dgvTrains";
            dgvTrains.RowHeadersWidth = 51;
            dgvTrains.Size = new Size(592, 328);
            dgvTrains.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(126, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(633, 16);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load Trains";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(633, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(txtSearch);
            Controls.Add(dgvTrains);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dgvTrains).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTrains;
        private TextBox txtSearch;
        private Button btnLoad;
        private Button btnSave;
    }
}