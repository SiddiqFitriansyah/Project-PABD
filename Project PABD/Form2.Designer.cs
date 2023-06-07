namespace Project_PABD
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jualHandphoneDataSet = new Project_PABD.JualHandphoneDataSet();
            this.handphoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.handphoneTableAdapter = new Project_PABD.JualHandphoneDataSetTableAdapters.HandphoneTableAdapter();
            this.kdbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrgjualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrgbeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jualHandphoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handphoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kdbarangDataGridViewTextBoxColumn,
            this.nmbarangDataGridViewTextBoxColumn,
            this.hrgjualDataGridViewTextBoxColumn,
            this.hrgbeliDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.handphoneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(808, 416);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // jualHandphoneDataSet
            // 
            this.jualHandphoneDataSet.DataSetName = "JualHandphoneDataSet";
            this.jualHandphoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // handphoneBindingSource
            // 
            this.handphoneBindingSource.DataMember = "Handphone";
            this.handphoneBindingSource.DataSource = this.jualHandphoneDataSet;
            // 
            // handphoneTableAdapter
            // 
            this.handphoneTableAdapter.ClearBeforeFill = true;
            // 
            // kdbarangDataGridViewTextBoxColumn
            // 
            this.kdbarangDataGridViewTextBoxColumn.DataPropertyName = "kd_barang";
            this.kdbarangDataGridViewTextBoxColumn.HeaderText = "kd_barang";
            this.kdbarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kdbarangDataGridViewTextBoxColumn.Name = "kdbarangDataGridViewTextBoxColumn";
            this.kdbarangDataGridViewTextBoxColumn.Width = 150;
            // 
            // nmbarangDataGridViewTextBoxColumn
            // 
            this.nmbarangDataGridViewTextBoxColumn.DataPropertyName = "nm_barang";
            this.nmbarangDataGridViewTextBoxColumn.HeaderText = "nm_barang";
            this.nmbarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nmbarangDataGridViewTextBoxColumn.Name = "nmbarangDataGridViewTextBoxColumn";
            this.nmbarangDataGridViewTextBoxColumn.Width = 150;
            // 
            // hrgjualDataGridViewTextBoxColumn
            // 
            this.hrgjualDataGridViewTextBoxColumn.DataPropertyName = "hrg_jual";
            this.hrgjualDataGridViewTextBoxColumn.HeaderText = "hrg_jual";
            this.hrgjualDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hrgjualDataGridViewTextBoxColumn.Name = "hrgjualDataGridViewTextBoxColumn";
            this.hrgjualDataGridViewTextBoxColumn.Width = 150;
            // 
            // hrgbeliDataGridViewTextBoxColumn
            // 
            this.hrgbeliDataGridViewTextBoxColumn.DataPropertyName = "hrg_beli";
            this.hrgbeliDataGridViewTextBoxColumn.HeaderText = "hrg_beli";
            this.hrgbeliDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hrgbeliDataGridViewTextBoxColumn.Name = "hrgbeliDataGridViewTextBoxColumn";
            this.hrgbeliDataGridViewTextBoxColumn.Width = 150;
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewTextBoxColumn.HeaderText = "active";
            this.activeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            this.activeDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jualHandphoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handphoneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private JualHandphoneDataSet jualHandphoneDataSet;
        private System.Windows.Forms.BindingSource handphoneBindingSource;
        private JualHandphoneDataSetTableAdapters.HandphoneTableAdapter handphoneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrgjualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrgbeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
    }
}