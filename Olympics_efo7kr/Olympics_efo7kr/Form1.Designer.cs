
namespace Olympics_efo7kr
{
    partial class Form1
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
            this.cbxEv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxEv
            // 
            this.cbxEv.FormattingEnabled = true;
            this.cbxEv.Location = new System.Drawing.Point(41, 17);
            this.cbxEv.Name = "cbxEv";
            this.cbxEv.Size = new System.Drawing.Size(121, 21);
            this.cbxEv.TabIndex = 0;
            this.cbxEv.SelectedValueChanged += new System.EventHandler(this.cbxEv_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Év:";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(41, 44);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(121, 23);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Excelbe ment";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(387, 287);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 372);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

