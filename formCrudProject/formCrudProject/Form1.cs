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
using System.Configuration;


namespace formCrudProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        String connect = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;

      

        private void btn_showData(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();


          
            cnx.ConnectionString = connect;

            string query = "SELECT * FROM person";

            SqlCommand cmd = new SqlCommand(query, cnx);// la command accept 2 parametre (la requete , la connection)

            cnx.Open();

            SqlDataReader rd = cmd.ExecuteReader();// nous permet de read data from database 

            if (rd.HasRows)
            {

                this.dgvPerson.Rows.Clear();
                while (rd.Read())
                {
                    this.dgvPerson.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4]);
                }

            }
            else
            {
                MessageBox.Show("la table est vide !!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        

        private bool controleBtn()
        {
            if (this.INPUTID.Text.Trim().Equals(string.Empty) || this.INPUTNOM.Text.Trim().Equals(string.Empty) || this.INPUTPRENOM.Text.Trim().Equals(string.Empty) ||
                this.INPUTADRESSE.Text.Trim().Equals(String.Empty) )
                return false;
            return true;

        }
      

        private void btn_Add(object sender, EventArgs e)
        {
            try
            {

                if (check == true)
                    return;

                if (!controleBtn())
                {
                    MessageBox.Show("le champ est vide !!");
                }

                //Insert INTO Redacteur VALUES(, '' , '' ,)
                using (SqlConnection cnx = new SqlConnection(connect))
                {
                    String query = "INSERT INTO person VALUES(" + this.INPUTID.Text.Trim() + ", '" + this.INPUTNOM.Text.Trim().ToUpper() + "' , '" + this.INPUTPRENOM.Text.Trim().ToUpper() + "' ,'" + this.INPUTADRESSE.Text.Trim() + "','" + this.INPUTVILLE.Text.Trim().ToUpper() + "')";
                    SqlCommand cmd = new SqlCommand(query, cnx);

                    if (cnx.State == ConnectionState.Open)
                        cnx.Close();
                    cnx.Open();

                    int m = cmd.ExecuteNonQuery();
                    MessageBox.Show(m + "lign(s) effectué");
                    btn_showData(sender, e);
                }
              

            }
            catch (SqlException ex)
            {

                if (ex.Number == 2627)
                    MessageBox.Show("ID déja exist !!");




            }

        }


        int position, ID;

        private void dgvPerson_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        bool check = false;
        private void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.dgvPerson.CurrentRow.Index;

            ID = int.Parse(this.dgvPerson.Rows[position].Cells[0].Value.ToString());

            this.INPUTID.Text = this.dgvPerson.Rows[position].Cells[0].Value.ToString();
            this.INPUTNOM.Text = this.dgvPerson.Rows[position].Cells[1].Value.ToString();
            this.INPUTPRENOM.Text = this.dgvPerson.Rows[position].Cells[2].Value.ToString();
            this.INPUTADRESSE.Text = this.dgvPerson.Rows[position].Cells[3].Value.ToString();
            this.INPUTVILLE.Text = this.dgvPerson.Rows[position].Cells[3].Value.ToString();
            this.INPUTID.Enabled = false;

            this.check = true;
        }

        private void btn_modifier(object sender, EventArgs e)
        {
            String Query = "UPDATE person SET Nom=@p2 ,  prénom= @p1 , adresse= @p3 , ville = @p4  WHERE id = @p5 ";
            using (SqlConnection cnx = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand(Query, cnx);

                cmd.Parameters.AddWithValue("@p1", this.INPUTNOM.Text.Trim());
                cmd.Parameters.AddWithValue("@p2", this.INPUTPRENOM.Text.Trim());
                cmd.Parameters.AddWithValue("@p3", this.INPUTADRESSE.Text.Trim());
                cmd.Parameters.AddWithValue("@p4", this.INPUTVILLE.Text.Trim());
                cmd.Parameters.AddWithValue("@p5", this.INPUTID.Text.Trim());
                cnx.Open();
                cmd.ExecuteNonQuery();
                btn_showData(sender, e);
                cnx.Close();
                MessageBox.Show("modification validé ");
            }
        }

        private void nebtn_Click(object sender, EventArgs e)
        {
            this.INPUTID.Text = String.Empty;
            this.INPUTNOM.Text = String.Empty;
            this.INPUTPRENOM.Text = String.Empty;
            this.INPUTADRESSE.Text = String.Empty;
            this.INPUTVILLE.Text = String.Empty;

            this.INPUTID.Enabled = true;
        }

        private void btn_supression(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("????", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                return;

            string requet = "DELETE FROM person WHERE ID = " + ID;
            using (SqlConnection cnx = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand(requet, cnx);
                cnx.Open();
                cmd.ExecuteNonQuery();


                this.dgvPerson.Rows.RemoveAt(position);
                MessageBox.Show("sepression success ");
                cnx.Close();

            }
        }
    }
}
