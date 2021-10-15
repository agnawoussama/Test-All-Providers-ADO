
namespace Test_All_Providers_ADO
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlClient = new System.Windows.Forms.Button();
            this.oledb = new System.Windows.Forms.Button();
            this.odbc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // sqlClient
            // 
            this.sqlClient.Location = new System.Drawing.Point(12, 353);
            this.sqlClient.Name = "sqlClient";
            this.sqlClient.Size = new System.Drawing.Size(108, 38);
            this.sqlClient.TabIndex = 1;
            this.sqlClient.Text = "SQLClient";
            this.sqlClient.UseVisualStyleBackColor = true;
            this.sqlClient.Click += new System.EventHandler(this.sqlClient_Click);
            // 
            // oledb
            // 
            this.oledb.Location = new System.Drawing.Point(180, 353);
            this.oledb.Name = "oledb";
            this.oledb.Size = new System.Drawing.Size(108, 38);
            this.oledb.TabIndex = 2;
            this.oledb.Text = "OLEDB";
            this.oledb.UseVisualStyleBackColor = true;
            this.oledb.Click += new System.EventHandler(this.oledb_Click);
            // 
            // odbc
            // 
            this.odbc.Location = new System.Drawing.Point(361, 353);
            this.odbc.Name = "odbc";
            this.odbc.Size = new System.Drawing.Size(108, 38);
            this.odbc.TabIndex = 3;
            this.odbc.Text = "ODBC";
            this.odbc.UseVisualStyleBackColor = true;
            this.odbc.Click += new System.EventHandler(this.odbc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(520, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 403);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.odbc);
            this.Controls.Add(this.oledb);
            this.Controls.Add(this.sqlClient);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sqlClient;
        private System.Windows.Forms.Button oledb;
        private System.Windows.Forms.Button odbc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

