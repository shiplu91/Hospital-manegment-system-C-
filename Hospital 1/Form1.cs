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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            //shipon();
            shiplu();

            st();
            
        }














        private void shiplu()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("select ID from ADDWard ", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(string));

            dt.Load(rdr);
            Como_iteams.ValueMember = "ID";

            Como_iteams.DataSource = dt;


            con.Close();






        }










        public void gercustomer()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True");

            string proid;
            string quary = "select No from Registraction  order by  No Desc  ";
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


                proid = ("00011");



            }

            else
            {
                proid = ("00011");



            }
            con.Close();
            txtno.Text = proid.ToString();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
            textBox2.Text = DateTime.Now.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
            gercustomer();
            customer();
        }







        public void customer()
        {

            SqlConnection con = new SqlConnection("  Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True");

            string pid;
            string quary = "select Pid from Registraction order by  Pid Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(quary, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                int id = int.Parse(dr[0].ToString()) + 1;
                pid = id.ToString("00000");





            }

            else if (Convert.IsDBNull(dr))
            {


                pid = ("00001");



            }

            else
            {
                pid = ("00001");



            }
            con.Close();
            txtPid.Text = pid.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel6.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void txthigh_CheckedChanged(object sender, EventArgs e)
        {


            if (txthigh.Checked == true)
            {
                cmb_iteams.Enabled = true;

                txtBuild.Enabled = true;





            }


            else
            {
                cmb_iteams.Enabled = false;
                txtBuild.Enabled = false;

                //txttype.Text = "";
                //txtprice.Text = "";




            }
















            txthigh.ForeColor = System.Drawing.Color.Green;
            txtmedium.ForeColor = System.Drawing.Color.Red;
            txtvip.ForeColor = System.Drawing.Color.Red;

            cmb_iteams.Items.Clear();
            cmb_iteams.Items.Add("101");
            cmb_iteams.Items.Add("102");
            cmb_iteams.Items.Add("103");
            cmb_iteams.Items.Add("104");



















        }

        private void txtmedium_CheckedChanged(object sender, EventArgs e)
        {

            if (txtmedium.Checked == true)
            {
                cmb_iteams.Enabled = true;


                txtBuild.Enabled = true;




            }
            else
            {
                cmb_iteams.Enabled = false;
                txtBuild.Enabled = false;

                //txttype.Text = "";
                //txtprice.Text = "";




            }













            txthigh.ForeColor = System.Drawing.Color.Red;
            txtmedium.ForeColor = System.Drawing.Color.Blue;
            txtvip.ForeColor = System.Drawing.Color.Red;

            cmb_iteams.Items.Clear();
            cmb_iteams.Items.Add("105");
            cmb_iteams.Items.Add("106");
            cmb_iteams.Items.Add("107");
            cmb_iteams.Items.Add("108");
        }

        private void txtvip_CheckedChanged(object sender, EventArgs e)
        {

            if (txtvip.Checked == true)
            {
                cmb_iteams.Enabled = true;

                txtBuild.Enabled = true;





            }
            else
            {
                cmb_iteams.Enabled = false;

                txtBuild.Enabled = false;
                //txttype.Text = "";
                //txtprice.Text = "";




            }














            txthigh.ForeColor = System.Drawing.Color.Red;
            txtmedium.ForeColor = System.Drawing.Color.Red;
            txtvip.ForeColor = System.Drawing.Color.Green;

            cmb_iteams.Items.Clear();
            cmb_iteams.Items.Add("109");
            cmb_iteams.Items.Add("110");
            cmb_iteams.Items.Add("111");
            cmb_iteams.Items.Add("112");
        }

        private void cmb_iteams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_iteams.SelectedItem.ToString() == "101")
            {

                txttype.Text = "Normal";

                txtprice.Text = "1800";

            }


            else if (cmb_iteams.SelectedItem.ToString() == "102")
            {

                txttype.Text = "Normal";
                txtprice.Text = "1900";

            }


            else if (cmb_iteams.SelectedItem.ToString() == "103")
            {

                txttype.Text = "Normal";
                txtprice.Text = "2000";

            }

            else if (cmb_iteams.SelectedItem.ToString() == "104")
            {

                txttype.Text = "Normal";
                txtprice.Text = "3000";

            }
            else if (cmb_iteams.SelectedItem.ToString() == "105")
            {

                txttype.Text = "Medium";
                txtprice.Text = "4000";

            }
            else if (cmb_iteams.SelectedItem.ToString() == "106")
            {

                txttype.Text = "Medium";
                txtprice.Text = "4400";

            }
            else if (cmb_iteams.SelectedItem.ToString() == "107")
            {

                txttype.Text = "Medium";
                txtprice.Text = "4500";

            }

            else if (cmb_iteams.SelectedItem.ToString() == "108")
            {

                txttype.Text = "Medium";
                txtprice.Text = "4600";

            }
            else if (cmb_iteams.SelectedItem.ToString() == "109")
            {

                txttype.Text = "VIP";
                txtprice.Text = "4700";

            }
            else if (cmb_iteams.SelectedItem.ToString() == "110")
            {

                txttype.Text = "VIP";
                txtprice.Text = "4800";

            }
            else if (cmb_iteams.SelectedItem.ToString() == "111")
            {

                txttype.Text = "VIP";
                txtprice.Text = "4900";

            }
            else if (cmb_iteams.SelectedItem.ToString() == "112")
            {

                txttype.Text = "VIP";
                txtprice.Text = "5000";

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            inTime.Text = DateTime.Now.ToLongTimeString();
            CheckTime.Text = DateTime.Now.ToLongTimeString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                int No = Convert.ToInt32(txtno.Text);
                string Date = textBox2.Text;
                int Pid = Convert.ToInt32(txtPid.Text);
                string Name = txtname.Text;
                string Gender = txtgender.Text;
                string Age = txtage.Text;
                string Phone = txtphone.Text;
                string Address = txtAddress.Text;
                string Disease = txtdisease.Text;
                string Status = txtstatus.Text;
                string Building = txtBuild.Text;
                string Room = cmb_iteams.Text;
                string Type = txttype.Text;
                string Price = txtprice.Text;




                SqlConnection con = new SqlConnection();

                con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into  Registraction values ('" + No + "','" + Date + "','" + Pid + "','" + Name + "','" + Gender + "','" + Age + "','" + Phone + "','" + Address + "','" + Disease + "','" + Status + "','" + Building + "','" + Room + "','" + Type + "','" + Price + "')";


                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);




                //customer();
                //gercustomer();



            }
            catch (Exception)
            {


                //MessageBox.Show("Saved !!!!!!!!!");


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtphone.Clear();
            txtAddress.Clear();
            txtdisease.Clear();
            txtstatus.Clear();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            inTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

            populatesh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel6.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;

            panel5.Visible = false;
        }



































        private void populatesh()
        {


            SqlConnection con = new SqlConnection();



            con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True";
            con.Open();
            string query = "select No,Name,Gender,Age,Phone,Disease,[status of Disease],Date,[Room No],[Room Type],Building from   Registraction";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            txtbox.DataSource = ds.Tables[0];
            con.Close();




        }

        private void txtbox_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (txtbox.SelectedRows.Count >= 0)
            {

                inp.Text = txtbox.SelectedRows[0].Cells[0].Value.ToString();
                inName.Text = txtbox.SelectedRows[0].Cells[1].Value.ToString();
                inGender.Text = txtbox.SelectedRows[0].Cells[2].Value.ToString();
                inage.Text = txtbox.SelectedRows[0].Cells[3].Value.ToString();
                inPhone.Text = txtbox.SelectedRows[0].Cells[4].Value.ToString();
                indisease.Text = txtbox.SelectedRows[0].Cells[5].Value.ToString();
                instatus.Text = txtbox.SelectedRows[0].Cells[6].Value.ToString();
                incheck.Text = txtbox.SelectedRows[0].Cells[7].Value.ToString();
                inRoomNo.Text = txtbox.SelectedRows[0].Cells[8].Value.ToString();
                inType.Text = txtbox.SelectedRows[0].Cells[9].Value.ToString();
                inBuilding.Text = txtbox.SelectedRows[0].Cells[10].Value.ToString();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(@"UPDATE [hospitalmanagment].[dbo].[Registraction] SET [No] ='" + inp.Text + "' ,[Date] = '" + incheck.Text + "',[Name] = '" + inName.Text + "' ,[Gender] = '" + inGender.Text + "',[Age] = '" + inage.Text + "',[Phone] = '" + inPhone.Text + "',[Disease] = '" + indisease.Text + "',[status of Disease] = '" + instatus.Text + "',[Building] = '" + inBuilding.Text + "',[Room No] = '" + inRoomNo.Text + "',[Room Type] = '" + inType.Text + "' WHERE [No] ='" + inp.Text + "' ", con);


            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update");
            con.Close();

            


        }

        private void button6_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {



                int Pid = Convert.ToInt32(checkpid.Text);
                string Name = checkName.Text;
                string Gender = CheckGender.Text;
                string Age = CheckAge.Text;
                string Phone = CheckPhone.Text;
                String Address = CheckAddress.Text;
                String Disease = checkdisease.Text;
                string Datein = CheckDatein.Text;
                String dateout = CheckDateOut.Text;
                string Room = CheckRoomNo.Text;
                string Type = CheckType.Text;
                string priceunit = CheckUnitPrice.Text;
                string building = CheckBuilding.Text;
                string status = CheckStatus.Text;
                String Quality = CheckQuality.Text;
                string Price = CheckPrice.Text;
                string Time = CheckTime.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into CheckOut values ('" + Pid + "','" + Name + "','" + Gender + "','" + Age + "','" + Phone + "','" + Address + "','" + Disease + "','" + Datein + "','" + dateout + "','" + Room + "','" + Type + "','" + priceunit + "','" + building + "','" + status + "','" + Quality + "','" + Price + "','" + Time + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


















            }

            catch (Exception)
            {



                MessageBox.Show("Saved!!!!!!");







            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(@"DELETE FROM [hospitalmanagment].[dbo].[Registraction]
      WHERE [No] ='" +checkpid.Text + "'", con);


            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete!!!!!!");
            con.Close();

            
        }
















        private void button15_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            tpi();
            CheckTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

            CheckDateOut.Text = DateTime.Now.ToLongDateString();








        }




        private void tpi()
        {


            SqlConnection con = new SqlConnection();



            con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True";
            con.Open();
            string query = "select No,Name,Gender,Age,Phone,Address,Disease,Date,[Room No],[Room Type],Price,Building,[status of Disease] from   Registraction";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();




        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {

                checkpid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                checkName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                CheckGender.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                CheckAge.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                CheckPhone.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                CheckAddress.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                checkdisease.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                CheckDatein.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                CheckRoomNo.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                CheckType.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();

                CheckUnitPrice.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();

                CheckBuilding.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

                CheckStatus.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void CheckQuality_TextChanged(object sender, EventArgs e)
        {
            if (CheckUnitPrice.Text.Length > 0)
            {
                CheckPrice.Text = (Convert.ToInt16(CheckUnitPrice.Text) * Convert.ToInt16(CheckQuality.Text)).ToString();
            }
        }

        private void CheckDateOut_TextChanged(object sender, EventArgs e)
        {

        }










        private void shipon()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True");
            con.Open();

            string mysql = "select * from ADDWard where ID=" + Como_iteams.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {


                textBox1.Text = "" + dr["Building"].ToString();

                textBox3.Text = "" + dr["Room No"].ToString();
                textBox4.Text = "" + dr["Number Of Bed"].ToString();
                textBox6.Text = "" + dr["unit Price"].ToString();

            }


        }

















        private void button14_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Como_iteams_SelectionChangeCommitted(object sender, EventArgs e)
        {
            shipon();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txtidward.Text);
                string Building = comboBox1.Text;
                string Floor = Floor_iteams.Text;
                string Roomward = txtwardno.Text;
                string Wardtype = comboBox3.Text;
                string Bed = txtbed.Text;
                string WardPrice = txtwardprice.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into ADDWard values ('" + ID + "','" + Building + "','" + Floor + "','" + Roomward + "','" + Wardtype + "','" + Bed + "','" + WardPrice + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);







            }
            catch (Exception)
            {


                MessageBox.Show("Add Ward");




            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel6.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True");
          
            SqlCommand cmd = new SqlCommand(@"UPDATE [hospitalmanagment].[dbo].[ADDWard]SET [ID] ='" + Como_iteams.Text + "',[Building] = '" + textBox1.Text + "',[Room No] = '" + textBox3.Text + "',[Number Of Bed] = '" + textBox4.Text + "',[unit Price] = '" + textBox6.Text + "' WHERE [ID] ='" + Como_iteams.Text + "' ", con);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update ");
            con.Close();





        }

        private void button19_Click(object sender, EventArgs e)



















        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True");




            SqlCommand cmd = new SqlCommand(@"DELETE FROM [hospitalmanagment].[dbo].[ADDWard]
      WHERE [ID] ='" + Como_iteams.Text + "'", con);

















            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("delete ");
            con.Close();







        }










        //private void py()
        //{


        //    SqlConnection con = new SqlConnection();



        //    con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True";
        //    con.Open();
        //    string query = "select Name from Staff";
        //    SqlDataAdapter sda = new SqlDataAdapter(query, con);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
        //    var ds = new DataSet();
        //    sda.Fill(ds);
        //    txtlist.DataSource = ds.Tables[0];
          
        //    con.Close();




        //}










        public void st()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True");

            txtlist.Items.Clear();


            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType.ToString();
            cmd.CommandText = "select Name from    Staff";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(dt);
            foreach (DataRow dr in dt.Rows) 
            {


                txtlist.Items.Add(dr["Name"].ToString());
            
            
            
            
            
            }

            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType.ToString();
            //cmd.CommandText = "select Name from    Staff";
            //cmd.ExecuteNonQuery();

            //SqlCommand cmd = new SqlCommand("select Name from    Staff", con);
            //SqlDataReader rdr;
            //rdr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();

            //dt.Columns.Add("Name", typeof(string));

            //dt.Load(rdr);
            //txtlist.Items.Add = "Name";
            //txtli.ValueMember = "Customerid";
            //CustomerTB.DataSource = dt;
            //txtlist.Items.Add(rdr[0].ToString());

            con.Close();






        }























        public void sk()
        {



            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=hospitalmanagment;Integrated Security=True");

            string did;
            string quary = "select ID from ADDWard order by ID Desc";


            con.Open();
            SqlCommand cmd = new SqlCommand(quary, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                int id = int.Parse(dr[0].ToString()) + 1;
               did = id.ToString("00000");





            }

            else if (Convert.IsDBNull(dr))
            {


                did = ("00011");



            }

            else
            {
                did = ("00011");



            }
            con.Close();
            txtidward.Text = did.ToString();



        }

        private void button20_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            sk();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            new staff().Show();
            this.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
           
        }




    }
}
