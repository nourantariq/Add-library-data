using System.Data; // Add this using directive
using System.Data.SqlClient; // Use the Microsoft.Data.SqlClient package


namespace Add_library_data
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection conn;// Use Microsoft.Data.SqlClient.SqlDataAdapter

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strconnection = " ";// enter path here between the highcotachion 
            conn = new SqlConnection(strconnection);
            conn.Open();
            try
            {
                SqlCommand com1 = new SqlCommand("Create database met", conn);
                com1.ExecuteNonQuery();
                com1.Connection.ChangeDatabase("met");
                SqlCommand com2 = new SqlCommand("Create table library (id int  primary key, name varchar(50), category varchar(50) , location varchar(50) )", conn);
                com2.ExecuteNonQuery();
            }
            catch (Exception e1)
            {
                conn.ChangeDatabase("met");
            }
            da = new SqlDataAdapter("select * from library", conn);
            SqlCommandBuilder x = new SqlCommandBuilder(da);
            da.Fill(ds, "library");
            dataGridView.DataSource = ds.Tables["library"];
        }

        void clear()
        {
            idtextBox.Clear();
            nametextBox.Clear();
            categorytextBox.Clear();
            locationtextBox.Clear();
        }


        private void insertButton_Click_1(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["library"].NewRow();
            r["id"] = int.Parse(idtextBox.Text);
            r["name"] = nametextBox.Text;
            r["category"] = categorytextBox.Text;
            r["location"] = locationtextBox.Text;

            ds.Tables["library"].Rows.Add(r);
            da.Update(ds, "library");
            clear();
        }

        private void searchbutton_Click_1(object sender, EventArgs e)
        {
            foreach (DataRow r in ds.Tables["library"].Rows)
            {
                if (Convert.ToInt32(r["id"]) == int.Parse(idtextBox.Text))
                {
                    nametextBox.Text = Convert.ToString(r["name"]);
                    categorytextBox.Text = Convert.ToString(r["category"]);
                    locationtextBox.Text = Convert.ToString(r["location"]);

                }
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            foreach (DataRow r in ds.Tables["library"].Rows)
            {
                if (Convert.ToInt32(r["id"]) == int.Parse(idtextBox.Text))
                {
                    r.Delete();
                    da.Update(ds, "library");
                    clear();
                    break;
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            foreach (DataRow r in ds.Tables["library"].Rows)
            {
                if (Convert.ToInt32(r["id"]) == int.Parse(idtextBox.Text))
                {
                    r["name"] = nametextBox.Text;
                    r["category"] = categorytextBox.Text;
                    r["location"] = locationtextBox.Text;
                    da.Update(ds, "library");
                    clear();
                    break;
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
        }
    }
}
