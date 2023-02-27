
namespace EntityFrameworkEx
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl_Hw3 = new System.Windows.Forms.TabControl();
            this.tab1_IncludeDB = new System.Windows.Forms.TabPage();
            this.tab1_sc = new System.Windows.Forms.SplitContainer();
            this.tab1_CSV_dgv = new System.Windows.Forms.DataGridView();
            this.tab1_panel2 = new System.Windows.Forms.Panel();
            this.tab1_dgvLocalDB = new System.Windows.Forms.DataGridView();
            this.tab1_panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_IncludeDB = new System.Windows.Forms.Button();
            this.tab2_Data = new System.Windows.Forms.TabPage();
            this.tab2_sc = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tab2_cbo_Category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tab2_dgvLocalDB = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl_Hw3.SuspendLayout();
            this.tab1_IncludeDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_sc)).BeginInit();
            this.tab1_sc.Panel1.SuspendLayout();
            this.tab1_sc.Panel2.SuspendLayout();
            this.tab1_sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_CSV_dgv)).BeginInit();
            this.tab1_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_dgvLocalDB)).BeginInit();
            this.tab1_panel1.SuspendLayout();
            this.tab2_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_sc)).BeginInit();
            this.tab2_sc.Panel1.SuspendLayout();
            this.tab2_sc.Panel2.SuspendLayout();
            this.tab2_sc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_dgvLocalDB)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Hw3
            // 
            this.tabControl_Hw3.Controls.Add(this.tab1_IncludeDB);
            this.tabControl_Hw3.Controls.Add(this.tab2_Data);
            this.tabControl_Hw3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Hw3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl_Hw3.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Hw3.Name = "tabControl_Hw3";
            this.tabControl_Hw3.SelectedIndex = 0;
            this.tabControl_Hw3.Size = new System.Drawing.Size(1218, 628);
            this.tabControl_Hw3.TabIndex = 0;
            // 
            // tab1_IncludeDB
            // 
            this.tab1_IncludeDB.Controls.Add(this.tab1_sc);
            this.tab1_IncludeDB.Location = new System.Drawing.Point(4, 26);
            this.tab1_IncludeDB.Name = "tab1_IncludeDB";
            this.tab1_IncludeDB.Padding = new System.Windows.Forms.Padding(3);
            this.tab1_IncludeDB.Size = new System.Drawing.Size(1210, 598);
            this.tab1_IncludeDB.TabIndex = 0;
            this.tab1_IncludeDB.Text = "匯入CSV資料";
            this.tab1_IncludeDB.UseVisualStyleBackColor = true;
            // 
            // tab1_sc
            // 
            this.tab1_sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1_sc.Location = new System.Drawing.Point(3, 3);
            this.tab1_sc.Name = "tab1_sc";
            // 
            // tab1_sc.Panel1
            // 
            this.tab1_sc.Panel1.Controls.Add(this.tab1_CSV_dgv);
            // 
            // tab1_sc.Panel2
            // 
            this.tab1_sc.Panel2.Controls.Add(this.tab1_panel2);
            this.tab1_sc.Panel2.Controls.Add(this.tab1_panel1);
            this.tab1_sc.Size = new System.Drawing.Size(1204, 592);
            this.tab1_sc.SplitterDistance = 522;
            this.tab1_sc.TabIndex = 0;
            // 
            // tab1_CSV_dgv
            // 
            this.tab1_CSV_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab1_CSV_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1_CSV_dgv.Location = new System.Drawing.Point(0, 0);
            this.tab1_CSV_dgv.Name = "tab1_CSV_dgv";
            this.tab1_CSV_dgv.RowTemplate.Height = 24;
            this.tab1_CSV_dgv.Size = new System.Drawing.Size(522, 592);
            this.tab1_CSV_dgv.TabIndex = 0;
            // 
            // tab1_panel2
            // 
            this.tab1_panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab1_panel2.Controls.Add(this.tab1_dgvLocalDB);
            this.tab1_panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1_panel2.Location = new System.Drawing.Point(0, 53);
            this.tab1_panel2.Name = "tab1_panel2";
            this.tab1_panel2.Size = new System.Drawing.Size(678, 539);
            this.tab1_panel2.TabIndex = 4;
            // 
            // tab1_dgvLocalDB
            // 
            this.tab1_dgvLocalDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab1_dgvLocalDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1_dgvLocalDB.Location = new System.Drawing.Point(0, 0);
            this.tab1_dgvLocalDB.Name = "tab1_dgvLocalDB";
            this.tab1_dgvLocalDB.RowTemplate.Height = 24;
            this.tab1_dgvLocalDB.Size = new System.Drawing.Size(674, 535);
            this.tab1_dgvLocalDB.TabIndex = 3;
            // 
            // tab1_panel1
            // 
            this.tab1_panel1.Controls.Add(this.label1);
            this.tab1_panel1.Controls.Add(this.btn_IncludeDB);
            this.tab1_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab1_panel1.Location = new System.Drawing.Point(0, 0);
            this.tab1_panel1.Name = "tab1_panel1";
            this.tab1_panel1.Size = new System.Drawing.Size(678, 53);
            this.tab1_panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(150, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "注意：Local DB 原有資料內容，將會被刪除，重新引入基本資料。";
            // 
            // btn_IncludeDB
            // 
            this.btn_IncludeDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_IncludeDB.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_IncludeDB.Location = new System.Drawing.Point(14, 3);
            this.btn_IncludeDB.Name = "btn_IncludeDB";
            this.btn_IncludeDB.Size = new System.Drawing.Size(130, 47);
            this.btn_IncludeDB.TabIndex = 0;
            this.btn_IncludeDB.Text = "重載資料";
            this.btn_IncludeDB.UseVisualStyleBackColor = false;
            this.btn_IncludeDB.Click += new System.EventHandler(this.btn_IncludeDB_Click);
            // 
            // tab2_Data
            // 
            this.tab2_Data.Controls.Add(this.tab2_sc);
            this.tab2_Data.Location = new System.Drawing.Point(4, 26);
            this.tab2_Data.Name = "tab2_Data";
            this.tab2_Data.Padding = new System.Windows.Forms.Padding(3);
            this.tab2_Data.Size = new System.Drawing.Size(1210, 598);
            this.tab2_Data.TabIndex = 1;
            this.tab2_Data.Text = "資料作業";
            this.tab2_Data.UseVisualStyleBackColor = true;
            // 
            // tab2_sc
            // 
            this.tab2_sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab2_sc.Location = new System.Drawing.Point(3, 3);
            this.tab2_sc.Name = "tab2_sc";
            // 
            // tab2_sc.Panel1
            // 
            this.tab2_sc.Panel1.Controls.Add(this.label8);
            this.tab2_sc.Panel1.Controls.Add(this.btn_Delete);
            this.tab2_sc.Panel1.Controls.Add(this.btn_Modify);
            this.tab2_sc.Panel1.Controls.Add(this.btn_Insert);
            this.tab2_sc.Panel1.Controls.Add(this.txt_Category);
            this.tab2_sc.Panel1.Controls.Add(this.txt_Price);
            this.tab2_sc.Panel1.Controls.Add(this.txt_Quantity);
            this.tab2_sc.Panel1.Controls.Add(this.txt_Name);
            this.tab2_sc.Panel1.Controls.Add(this.txt_Number);
            this.tab2_sc.Panel1.Controls.Add(this.label7);
            this.tab2_sc.Panel1.Controls.Add(this.label6);
            this.tab2_sc.Panel1.Controls.Add(this.label5);
            this.tab2_sc.Panel1.Controls.Add(this.label4);
            this.tab2_sc.Panel1.Controls.Add(this.label3);
            this.tab2_sc.Panel1.Controls.Add(this.groupBox1);
            // 
            // tab2_sc.Panel2
            // 
            this.tab2_sc.Panel2.Controls.Add(this.tab2_dgvLocalDB);
            this.tab2_sc.Size = new System.Drawing.Size(1204, 592);
            this.tab2_sc.SplitterDistance = 660;
            this.tab2_sc.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tab2_cbo_Category);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品查詢";
            // 
            // tab2_cbo_Category
            // 
            this.tab2_cbo_Category.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tab2_cbo_Category.FormattingEnabled = true;
            this.tab2_cbo_Category.Location = new System.Drawing.Point(128, 32);
            this.tab2_cbo_Category.Name = "tab2_cbo_Category";
            this.tab2_cbo_Category.Size = new System.Drawing.Size(377, 29);
            this.tab2_cbo_Category.TabIndex = 2;
            this.tab2_cbo_Category.SelectedIndexChanged += new System.EventHandler(this.tab2_cbo_Category_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品類別：";
            // 
            // tab2_dgvLocalDB
            // 
            this.tab2_dgvLocalDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab2_dgvLocalDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab2_dgvLocalDB.Location = new System.Drawing.Point(0, 0);
            this.tab2_dgvLocalDB.Name = "tab2_dgvLocalDB";
            this.tab2_dgvLocalDB.RowTemplate.Height = 24;
            this.tab2_dgvLocalDB.Size = new System.Drawing.Size(540, 592);
            this.tab2_dgvLocalDB.TabIndex = 0;
            this.tab2_dgvLocalDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tab2_dgvLocalDB_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(59, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "商品編號：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(59, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "商品名稱：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(59, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "商品數量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(59, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "商品價格：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(59, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "商品類別：";
            // 
            // txt_Number
            // 
            this.txt_Number.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Number.Location = new System.Drawing.Point(168, 206);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(205, 33);
            this.txt_Number.TabIndex = 1;
            this.txt_Number.TextChanged += new System.EventHandler(this.txt_Number_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Name.Location = new System.Drawing.Point(168, 245);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(205, 33);
            this.txt_Name.TabIndex = 2;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Number_TextChanged);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Quantity.Location = new System.Drawing.Point(168, 283);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(205, 33);
            this.txt_Quantity.TabIndex = 3;
            this.txt_Quantity.TextChanged += new System.EventHandler(this.txt_Number_TextChanged);
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Price.Location = new System.Drawing.Point(168, 322);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(205, 33);
            this.txt_Price.TabIndex = 4;
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Number_TextChanged);
            // 
            // txt_Category
            // 
            this.txt_Category.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Category.Location = new System.Drawing.Point(168, 361);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(205, 33);
            this.txt_Category.TabIndex = 5;
            this.txt_Category.TextChanged += new System.EventHandler(this.txt_Number_TextChanged);
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.Transparent;
            this.btn_Insert.Enabled = false;
            this.btn_Insert.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Insert.Location = new System.Drawing.Point(63, 434);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(98, 44);
            this.btn_Insert.TabIndex = 8;
            this.btn_Insert.Text = "新增";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.BackColor = System.Drawing.Color.Transparent;
            this.btn_Modify.Enabled = false;
            this.btn_Modify.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Modify.Location = new System.Drawing.Point(168, 434);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(98, 44);
            this.btn_Modify.TabIndex = 6;
            this.btn_Modify.Text = "修改";
            this.btn_Modify.UseVisualStyleBackColor = false;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Delete.Location = new System.Drawing.Point(275, 434);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(98, 44);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "刪除";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(59, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(535, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "請點選右列表單後，實作修改或刪除，或新增一筆資料。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 628);
            this.Controls.Add(this.tabControl_Hw3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_Hw3.ResumeLayout(false);
            this.tab1_IncludeDB.ResumeLayout(false);
            this.tab1_sc.Panel1.ResumeLayout(false);
            this.tab1_sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab1_sc)).EndInit();
            this.tab1_sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab1_CSV_dgv)).EndInit();
            this.tab1_panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab1_dgvLocalDB)).EndInit();
            this.tab1_panel1.ResumeLayout(false);
            this.tab1_panel1.PerformLayout();
            this.tab2_Data.ResumeLayout(false);
            this.tab2_sc.Panel1.ResumeLayout(false);
            this.tab2_sc.Panel1.PerformLayout();
            this.tab2_sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab2_sc)).EndInit();
            this.tab2_sc.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_dgvLocalDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Hw3;
        private System.Windows.Forms.TabPage tab1_IncludeDB;
        private System.Windows.Forms.TabPage tab2_Data;
        private System.Windows.Forms.SplitContainer tab1_sc;
        private System.Windows.Forms.DataGridView tab1_CSV_dgv;
        private System.Windows.Forms.Panel tab1_panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_IncludeDB;
        private System.Windows.Forms.Panel tab1_panel2;
        private System.Windows.Forms.DataGridView tab1_dgvLocalDB;
        private System.Windows.Forms.SplitContainer tab2_sc;
        private System.Windows.Forms.DataGridView tab2_dgvLocalDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox tab2_cbo_Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label label8;
    }
}

