using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EntityFrameworkEx
{
    /// <summary>
    /// Entity Framework練習
    ///     專案類型：Windows Form(.NET Framework)
    ///     資料庫使用 localDB
    ///     跟LINQ練習一樣，請根據那個CSV檔來建置資料庫(建置方法在下一頁)
    ///     須達成以下需求：
    ///         新增一個商品
    ///         修改一個商品
    ///         刪除一個商品
    ///         查詢一個特定的商品
    ///         列出所有的商品
    ///     UI請自行設計
    /// 將資料匯入localDB
    ///     先根據CSV檔的欄位定義來產生資料表(記得翻成英文)
    ///     產生完資料表按右鍵➔顯示資料表資料(應該要看到空的資料表)
    ///     打開CSV檔，除了第一欄以外，全選所有資料並複製
    ///     在剛剛在 Visual Studio 開的資料表頁面，將一行選取起來之後按下 Ctrl+V 貼上複製的資料
    /// </summary>
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ProgramVS\Hw\1120227_Hw3\EntityFrameworkEx\MyProduct.mdf;Integrated Security=True");
        private SqlCommand cmd;
        public string sql { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; //視窗最大化
            tab1_sc.SplitterDistance = this.Size.Width / 2; //SplitContainer垂直平分
            //tab2_sc.SplitterDistance = this.Size.Width / 2;

            getCSV();
            //includeDB();
            dgvLocalDB();
            DisplayTab2_DGV();
        }


        private List<Product> csvlist { get; set; } = new List<Product>(); //商品資料
        private void getCSV(string sql = "ALL")
        {
            csvlist.Clear(); //清除
            string fileCSV = Environment.CurrentDirectory + @"\product.csv"; //資料路徑
            string[] arrCSV = System.IO.File.ReadAllLines(fileCSV); //開啟文字檔，將檔案的所有行讀入字串陣列，然後關閉檔案。
            int Num = 1;
            for (int i = 1; i < arrCSV.Length; i++)
            {
                string[] rowData = arrCSV[i].Split(','); //解析資料
                csvlist.Add(new Product() { Id = Num, Number = rowData[0], Name = rowData[1], Quantity = int.Parse(rowData[2]), Price = decimal.Parse(rowData[3]), Category = rowData[4] });
                Num = Num + 1;
            }
            tab1_CSV_dgv.DataSource = csvlist;
            tab2_dgvLocalDB.DataSource = csvlist;
        }

        private List<Category> category = new List<Category>(); //商品類別[名稱]-> ComboBox
        private void getCategory()
        { //查詢商品-> 過濾重覆[商品種類] -> ComboBox
            category.Clear();
            //tab2_cbo_Category.DataSource = null;
            category.Add(new Category() { ID = "ALL", Name = "全部" });
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * from ProductTable", conn))
            {
                string value;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        value = dr.GetString(5);
                        if (!category.Any((x) => x.ID == value))
                        {
                            category.Add(new Category() { ID = value, Name = value });
                        }
                    }
                }
                dr.Close();
            }
            conn.Close();
            tab2_cbo_Category.DataSource = category; tab2_cbo_Category.ValueMember = "ID"; tab2_cbo_Category.DisplayMember = "Name";
        }
        private int categoryIndex { get; set; } = 0;
        private void tab2_cbo_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (categoryIndex != tab2_cbo_Category.SelectedIndex)
                {
                    categoryIndex = tab2_cbo_Category.SelectedIndex;
                    switch (categoryIndex)
                    {
                        //case -1:
                            //tab2_cbo_Category.SelectedIndex = 0;
                            //categoryIndex = 0;
                            //dgvLocalDB(0); //顯示商品
                            //break;
                        case 0:
                            //tab2_cbo_Category.SelectedIndex = 0;
                            dgvLocalDB(0); //顯示商品
                            break;
                        default:
                            sql = "SELECT * from ProductTable WHERE Category= N'" + tab2_cbo_Category.SelectedValue.ToString() + "'";
                            dgvLocalDB(1, sql); //顯示商品
                            break;
                    }

                    //label3.Text = sql;
                }
            }
            catch (Exception ex)
            {
                tab2_cbo_Category.SelectedIndex = 0;
                //dgvLocalDB(0); //顯示商品
            }
            
        }



        private void btn_IncludeDB_Click(object sender, EventArgs e)
        { //重載 LocalDB 資料

            try
            {
                conn.Open();
                sql = "TRUNCATE Table ProductTable"; cmd = new SqlCommand(sql, conn); cmd.ExecuteNonQuery(); //清除全部資料庫
                for (int i = 0; i < csvlist.Count; i++)
                {
                    sql = "INSERT INTO ProductTable(Number, Name, Quantity, Price, Category) VALUES(N'" + csvlist[i].Number + "', N'" + csvlist[i].Name + "', " + csvlist[i].Quantity + ", " + csvlist[i].Price + ", N'" + csvlist[i].Category + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    //label1.Text += sql + Environment.NewLine;
                }
                cmd.Dispose();
                
            }
            catch (Exception ex)
            {

                //throw;
            }
            conn.Close();
            dgvLocalDB(0); 
        }

        private void dgvLocalDB(int index= 0, string sql= "SELECT * from ProductTable")
        {
            if(index == 0)
            {
                sql = "SELECT * from ProductTable";
            }
            DataTable dt = new DataTable();
            //using (SqlCommand cmd = new SqlCommand("SELECT * from ProductTable", conn))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                    da.Dispose();
                }
            }
            if (index == 0)
            {
                tab1_dgvLocalDB.DataSource = null;
                tab2_dgvLocalDB.DataSource = null;
                tab1_dgvLocalDB.DataSource = dt;
                tab2_dgvLocalDB.DataSource = dt; DisplayTab2_DGV();
            }
            else
            {
                tab2_dgvLocalDB.DataSource = null;
                tab2_dgvLocalDB.DataSource = dt; DisplayTab2_DGV();
            }
            getCategory(); //查詢商品-> 過濾重覆[商品種類] -> ComboBox
        }






        private void DisplayTab2_DGV()
        {
            tab2_dgvLocalDB.ReadOnly = true; //使用者禁止輸入
            tab2_dgvLocalDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //欄位填充整個顯示區
            tab2_dgvLocalDB.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12); //首行字型
            tab2_dgvLocalDB.RowHeadersVisible = false; //隱藏狀態提示列
            tab2_dgvLocalDB.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //儲存格採整列模式
            tab2_dgvLocalDB.MultiSelect = false; //禁用多行選取
            tab2_dgvLocalDB.AllowUserToAddRows = false; //不顯示最後一行空白
            if (tab2_dgvLocalDB.Rows.Count >=1)
            {
                tab2_dgvLocalDB.FirstDisplayedScrollingRowIndex = tab2_dgvLocalDB.Rows.Count - 1; //自動下接到最後一行

            }
            //標題設置
            tab2_dgvLocalDB.Columns[0].HeaderText = "序號"; tab2_dgvLocalDB.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; tab2_dgvLocalDB.Columns[0].Width = 80; tab2_dgvLocalDB.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tab2_dgvLocalDB.Columns[1].HeaderText = "商品編號"; tab2_dgvLocalDB.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; tab2_dgvLocalDB.Columns[1].Width = 100; tab2_dgvLocalDB.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tab2_dgvLocalDB.Columns[2].HeaderText = "商品名稱"; tab2_dgvLocalDB.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; tab2_dgvLocalDB.Columns[2].Width = 200; tab2_dgvLocalDB.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tab2_dgvLocalDB.Columns[3].HeaderText = "商品數量"; tab2_dgvLocalDB.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; tab2_dgvLocalDB.Columns[3].Width = 100; tab2_dgvLocalDB.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; tab2_dgvLocalDB.Columns[3].DefaultCellStyle.Format = "###,###,##0";
            tab2_dgvLocalDB.Columns[4].HeaderText = "商品價格"; tab2_dgvLocalDB.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; tab2_dgvLocalDB.Columns[4].Width = 120; tab2_dgvLocalDB.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; tab2_dgvLocalDB.Columns[4].DefaultCellStyle.Format = "###,###,##0.00";
            tab2_dgvLocalDB.Columns[5].HeaderText = "商品類別";
        }


        public int pid { get; set; }
        public string pNumber { get; set; }
        private void tab2_dgvLocalDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            pid= Convert.ToInt32(tab2_dgvLocalDB.CurrentRow.Cells[0].Value);
            pNumber = txt_Number.Text= tab2_dgvLocalDB.CurrentRow.Cells[1].Value.ToString();
            txt_Name.Text= tab2_dgvLocalDB.CurrentRow.Cells[2].Value.ToString();
            txt_Quantity.Text = tab2_dgvLocalDB.CurrentRow.Cells[3].Value.ToString();
            txt_Price.Text= tab2_dgvLocalDB.CurrentRow.Cells[4].Value.ToString();
            txt_Category.Text= tab2_dgvLocalDB.CurrentRow.Cells[5].Value.ToString();
            //label3.Text = tab2_dgvLocalDB.CurrentRow.Cells[2].Value.ToString();

            btn_Insert.Enabled = false; btn_Insert.BackColor = Color.Transparent;
            btn_Modify.Enabled = true; btn_Modify.BackColor = Color.Lime;
            btn_Delete.Enabled = true; btn_Delete.BackColor = Color.Red;

        }

        private void txt_Number_TextChanged(object sender, EventArgs e)
        {
            if (pNumber == txt_Number.Text)
            {
                btn_Insert.Enabled = false;
                btn_Insert.BackColor = Color.Transparent;
            }
            else
            {
                if (txt_Name.Text.Length >=1 && txt_Quantity.Text.Length >= 1 && txt_Price.Text.Length >=1 && txt_Category.Text.Length >=1)
                {
                    btn_Insert.Enabled = true;
                    btn_Insert.BackColor = Color.Yellow;
                }
                
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "INSERT INTO ProductTable(Number, Name, Quantity, Price, Category) VALUES(N'" + txt_Number.Text + "', N'" + txt_Name.Text + "', " + Convert.ToInt32(txt_Quantity.Text) + ", " + Convert.ToDecimal(txt_Price.Text) + ", N'" + txt_Category.Text + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (Exception ex)
            {

                //throw;
            }
            conn.Close();
            reset(); // 重新輸入
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        { //修改
            try
            {
                conn.Open();
                for (int i = 0; i < csvlist.Count; i++)
                {
                    sql = "UPDATE ProductTable SET Number=N'" + txt_Number.Text + "', Name=N'" + txt_Name.Text + "', Quantity=" + Convert.ToInt32(txt_Quantity.Text) + ", Price=" + Convert.ToDecimal(txt_Price.Text) + ", Category=N'" + txt_Category.Text + "' WHERE Id=" + pid + ";";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                }
                cmd.Dispose();

            }
            catch (Exception ex)
            {

                //throw;
            }
            conn.Close();
            reset(); // 重新輸入
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        { //刪除資料
            try
            {
                conn.Open();
                for (int i = 0; i < csvlist.Count; i++)
                {
                    sql = "DELETE FROM ProductTable WHERE Id=" + pid + ";";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                }
                cmd.Dispose();

            }
            catch (Exception ex)
            {

                //throw;
            }
            conn.Close();
            reset(); // 重新輸入
        }

        private void reset()
        { // 重新輸入
            categoryIndex = 0;
            dgvLocalDB(0); //顯示商品
            txt_Number.Text = txt_Name.Text = txt_Quantity.Text = txt_Price.Text = txt_Category.Text = "";
            btn_Insert.Enabled = false; btn_Insert.BackColor = Color.Transparent;
            btn_Modify.Enabled = false; btn_Modify.BackColor = Color.Transparent;
            btn_Delete.Enabled = false; btn_Delete.BackColor = Color.Transparent;
            tab2_cbo_Category.SelectedIndex = 0;
            
        }

        
    }

    public class Product
    {
        public int Id { get; set; } //編號
        public string Number { get; set; } //商品編號
        public string Name { get; set; } //商品名稱
        public int Quantity { get; set; } //商品數量
        public decimal Price { get; set; } //價格
        public string Category { get; set; } //商品類別

    }


    public class Category
    {
        public string ID { get; set; } //商品類別[ID]
        public string Name { get; set; } //商品類別[名稱]
    }

}
