namespace Tietokannat_vaihe1
{
    partial class Datagrid
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
            this.nimetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.forms_tietokantaDataSet = new Tietokannat_vaihe1.forms_tietokantaDataSet();
            this.nimetTableAdapter = new Tietokannat_vaihe1.forms_tietokantaDataSetTableAdapters.NimetTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nimetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forms_tietokantaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nimetBindingSource
            // 
            this.nimetBindingSource.DataMember = "Nimet";
            this.nimetBindingSource.DataSource = this.forms_tietokantaDataSet;
            // 
            // forms_tietokantaDataSet
            // 
            this.forms_tietokantaDataSet.DataSetName = "forms_tietokantaDataSet";
            this.forms_tietokantaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nimetTableAdapter
            // 
            this.nimetTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Poista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(388, 222);
            this.dataGridView1.TabIndex = 2;
            // 
            // Datagrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Datagrid";
            this.Text = "Datagrid";
            this.Load += new System.EventHandler(this.Datagrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nimetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forms_tietokantaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private forms_tietokantaDataSet forms_tietokantaDataSet;
        private System.Windows.Forms.BindingSource nimetBindingSource;
        private forms_tietokantaDataSetTableAdapters.NimetTableAdapter nimetTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}