using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_1
{
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }



        public void gercustomer()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True");

            string proid;
            string quary = "select ID from Staff order by ID Desc ";
            con.Open();
            SqlCommand cmd = new SqlCommand(quary, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                int id = int.Parse(dr[0].ToString()) + 1;
                proid = id.ToString("00000");





            }

            else if (Convert.IsDBNull(dr))
            {


                proid = ("00001");



            }

            else
            {
                proid = ("00001");



            }
            con.Close();
            txtid.Text = proid.ToString();

        }























        private void staff_Load(object sender, EventArgs e)
        {
            gercustomer();

        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(txtid.Text);
                string Name = txtname.Text;
                string sex = txtsex.Text;
                string position = txtposition.Text;
                string phone = txtphone.Text;
                string salary = txtsalary.Text;
                string address = txtad.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Staff values ('" + id + "','" + Name + "','" + sex + "','"+position+"','" + phone + "','" + salary + "','" + address + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
















            }
            catch (Exception) {


                MessageBox.Show("saved");
            
            
            
            
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [hospitalmanagment].[dbo].[Staff]
      WHERE [ID]='"+txtid.Text+"'",con);



            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete");
            con.Close();




        }

        private void button28_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }
    }
}
