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

namespace foxbank
{
    public partial class MainForm : Form
    {
        string connectionString = @"Data Source=Home-PC;Initial Catalog=foxbank;Integrated Security=True;TrustServerCertificate=True";
        public MainForm()
        {
            InitializeComponent();
           
        }

  

        private void InfoBtn_Click(object sender, EventArgs e)
        {

            try
            {
                MainDGV.Visible = true;
                using (SqlConnection SqlCon = new SqlConnection(connectionString))
                {
                    SqlCon.Open();
                    int id = Convert.ToInt32(idtb.Text);
                    var select = $"select * from users where id_user = {id}";
                    var c = new SqlConnection(connectionString);
                    var dataAdapter = new SqlDataAdapter(select, c);
                    var commandbuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                }
           }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void balancebtn_Click(object sender, EventArgs e)
        {
            try
            {
                saldoDGV.Visible = true;
                using (SqlConnection SqlCon = new SqlConnection(connectionString))
                {
                    SqlCon.Open();
                    long bn = Convert.ToInt64(banknumtb.Text);
                    var select = $"select * from balanceviewer where number = {bn}";
                    var c = new SqlConnection(connectionString);
                    var dataAdapter = new SqlDataAdapter(select, c);
                    var commandbuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "foxbankDataFOX.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.foxbankDataFOX.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "foxbankDataFOX.balanceviewer". При необходимости она может быть перемещена или удалена.
            this.balanceviewerTableAdapter.Fill(this.foxbankDataFOX.balanceviewer);

        }

        private void gToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.balanceviewerTableAdapter.g(this.foxbankDataFOX.balanceviewer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
