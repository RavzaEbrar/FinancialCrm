namespace FinancialCrm
{
    partial class FrmSpending
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnUpdateBill = new System.Windows.Forms.Button();
            this.BtnRemoveBill = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCreateBill = new System.Windows.Forms.Button();
            this.BtnBillList = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFinancialCRMDataSet = new FinancialCrm.dBFinancialCRMDataSet();
            this.categoriesTableAdapter = new FinancialCrm.dBFinancialCRMDataSetTableAdapters.CategoriesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancialCRMDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(30, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 39);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giderler Formu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(951, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(15)))), ((int)(((byte)(179)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(-1, -11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1356, 75);
            this.panel4.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(297, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 345);
            this.panel3.TabIndex = 14;
            // 
            // BtnUpdateBill
            // 
            this.BtnUpdateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateBill.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdateBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUpdateBill.Location = new System.Drawing.Point(755, 263);
            this.BtnUpdateBill.Name = "BtnUpdateBill";
            this.BtnUpdateBill.Size = new System.Drawing.Size(172, 45);
            this.BtnUpdateBill.TabIndex = 10;
            this.BtnUpdateBill.Text = " Güncelle";
            this.BtnUpdateBill.UseVisualStyleBackColor = true;
            this.BtnUpdateBill.Click += new System.EventHandler(this.BtnUpdateBill_Click);
            // 
            // BtnRemoveBill
            // 
            this.BtnRemoveBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveBill.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRemoveBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRemoveBill.Location = new System.Drawing.Point(547, 263);
            this.BtnRemoveBill.Name = "BtnRemoveBill";
            this.BtnRemoveBill.Size = new System.Drawing.Size(172, 45);
            this.BtnRemoveBill.TabIndex = 10;
            this.BtnRemoveBill.Text = " Sil";
            this.BtnRemoveBill.UseVisualStyleBackColor = true;
            this.BtnRemoveBill.Click += new System.EventHandler(this.BtnRemoveBill_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BtnUpdateBill);
            this.panel2.Controls.Add(this.BtnRemoveBill);
            this.panel2.Controls.Add(this.BtnCreateBill);
            this.panel2.Controls.Add(this.BtnBillList);
            this.panel2.Controls.Add(this.txt4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(297, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 314);
            this.panel2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 229);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(774, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kategori:";
            // 
            // BtnCreateBill
            // 
            this.BtnCreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateBill.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCreateBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCreateBill.Location = new System.Drawing.Point(343, 263);
            this.BtnCreateBill.Name = "BtnCreateBill";
            this.BtnCreateBill.Size = new System.Drawing.Size(172, 45);
            this.BtnCreateBill.TabIndex = 9;
            this.BtnCreateBill.Text = "Yeni Harcama";
            this.BtnCreateBill.UseVisualStyleBackColor = true;
            this.BtnCreateBill.Click += new System.EventHandler(this.BtnCreateBill_Click);
            // 
            // BtnBillList
            // 
            this.BtnBillList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBillList.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBillList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBillList.Location = new System.Drawing.Point(136, 263);
            this.BtnBillList.Name = "BtnBillList";
            this.BtnBillList.Size = new System.Drawing.Size(172, 45);
            this.BtnBillList.TabIndex = 8;
            this.BtnBillList.Text = "Harcama Listesi";
            this.BtnBillList.UseVisualStyleBackColor = true;
            this.BtnBillList.Click += new System.EventHandler(this.BtnBillList_Click);
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.Color.DimGray;
            this.txt4.Location = new System.Drawing.Point(136, 183);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(791, 26);
            this.txt4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarih:";
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.Color.DimGray;
            this.txt3.Location = new System.Drawing.Point(136, 133);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(791, 26);
            this.txt3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar:";
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.DimGray;
            this.txt2.Location = new System.Drawing.Point(136, 80);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(791, 26);
            this.txt2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlık:";
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.DimGray;
            this.txt1.Location = new System.Drawing.Point(136, 24);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(791, 26);
            this.txt1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.dBFinancialCRMDataSet;
            // 
            // dBFinancialCRMDataSet
            // 
            this.dBFinancialCRMDataSet.DataSetName = "DBFinancialCRMDataSet";
            this.dBFinancialCRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(50, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 665);
            this.panel1.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(50, 564);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(206, 42);
            this.button8.TabIndex = 7;
            this.button8.Text = "Çıkış Yap";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(50, 490);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(206, 42);
            this.button7.TabIndex = 6;
            this.button7.Text = " Ayarlar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(50, 412);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 42);
            this.button6.TabIndex = 5;
            this.button6.Text = "DashBoard";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(50, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "Banka Hareketleri";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(50, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Giderler";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBanksForm.Location = new System.Drawing.Point(50, 120);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(206, 42);
            this.btnBanksForm.TabIndex = 2;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = true;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(50, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Faturalar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmSpending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 665);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmSpending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSpending";
            this.Load += new System.EventHandler(this.FrmSpending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancialCRMDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnUpdateBill;
        private System.Windows.Forms.Button BtnRemoveBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCreateBill;
        private System.Windows.Forms.Button BtnBillList;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private dBFinancialCRMDataSet dBFinancialCRMDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private dBFinancialCRMDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
    }
}