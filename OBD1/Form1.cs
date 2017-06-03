using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace OBD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void txtQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string CommandText = txtQuery.Text;
            string myConnectionString = "server=localhost;port=3307;username=root;password=1qa2ws3ed;database=lab";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            MySqlDataReader dataReader;

            try
            {
                myConnection.Open();
                dataReader = myCommand.ExecuteReader();
                MessageBox.Show("Connection done");
            }
            catch(Exception ex)
{
                MessageBox.Show("Error " + ex.Message);
            }
        

            string sql = textSel1.Text;// Строка запроса
             MySqlScript script = new MySqlScript(myConnection, sql);
             int count = script.Execute();
             textSel2.Text += ("Executed " + count + " statement(s).");
             textSel2.Text += ("Delimiter: " + script.Delimiter);
             textSel2.Text += Environment.NewLine;

            MySqlConnection connection = new MySqlConnection(myConnectionString);
             MySqlCommand sqlCom = new MySqlCommand(sql, connection);
             connection.Open();
             sqlCom.ExecuteNonQuery();
             MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
             DataTable dt = new DataTable();
             dataAdapter.Fill(dt);

             var myData = dt.Select();
             for (int i = 0; i < myData.Length; i++)
             {
                 for (int j = 0; j < myData[i].ItemArray.Length; j++)
                     textSel2.Text += myData[i].ItemArray[j] + " ";
                     textSel2.Text += Environment.NewLine;
             }
            myConnection.Close();


        }

        private void textSel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSel2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
