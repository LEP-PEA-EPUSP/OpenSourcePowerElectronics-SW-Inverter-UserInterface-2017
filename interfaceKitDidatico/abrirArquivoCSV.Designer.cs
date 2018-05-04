namespace interfaceKitDidatico
{
    partial class abrirArquivoCSV
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
            this.button_path = new System.Windows.Forms.Button();
            this.button_sheet = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.textBox_sheet = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_path
            // 
            this.button_path.AutoSize = true;
            this.button_path.Location = new System.Drawing.Point(285, 256);
            this.button_path.Name = "button_path";
            this.button_path.Size = new System.Drawing.Size(97, 23);
            this.button_path.TabIndex = 0;
            this.button_path.Text = "Escolher Arquivo";
            this.button_path.UseVisualStyleBackColor = true;
            this.button_path.Click += new System.EventHandler(this.button_path_Click);
            // 
            // button_sheet
            // 
            this.button_sheet.AutoSize = true;
            this.button_sheet.Location = new System.Drawing.Point(285, 285);
            this.button_sheet.Name = "button_sheet";
            this.button_sheet.Size = new System.Drawing.Size(75, 23);
            this.button_sheet.TabIndex = 1;
            this.button_sheet.Text = "Planilha";
            this.button_sheet.UseVisualStyleBackColor = true;
            this.button_sheet.Click += new System.EventHandler(this.button_sheet_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(5, 256);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(266, 20);
            this.textBox_path.TabIndex = 2;
            // 
            // textBox_sheet
            // 
            this.textBox_sheet.Location = new System.Drawing.Point(5, 285);
            this.textBox_sheet.Name = "textBox_sheet";
            this.textBox_sheet.Size = new System.Drawing.Size(266, 20);
            this.textBox_sheet.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 236);
            this.dataGridView1.TabIndex = 4;
            // 
            // abrirArquivoCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 337);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_sheet);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.button_sheet);
            this.Controls.Add(this.button_path);
            this.Name = "abrirArquivoCSV";
            this.Text = "abrirArquivoCSV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_path;
        private System.Windows.Forms.Button button_sheet;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.TextBox textBox_sheet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}