using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Assignment8.Models;

namespace Assignment8
{
    public partial class Form1 : Form
    {
        PlayerDataProvider p = new PlayerDataProvider();
        List<Player> newPlayerList = new List<Player>();
        string _conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Documents\PlayerDB.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
            refresh(); //call refresh when the form loads for the first time to populate table and textboxes
        }
   

        private void button2_Click(object sender, EventArgs e)
        {
            //check that textboxes are not empty
            if (newID.Text.Equals("") || newName.Text.Equals("") ||
              newAge.Text.Equals("") || newHeight.Text.Equals("") ||
              newDist.Text.Equals("") || newSpd.Text.Equals(""))
            {
                //if not all boxes are filled in, show an error 
                errorProvider.SetError(newSpd, "Please fill in all fields");
            }

            else{
                
                int idIn = int.Parse(newID.Text);
                int distIn = int.Parse(newDist.Text);
                int ageIn = int.Parse(newAge.Text);
                int heightIn = int.Parse(newHeight.Text);
                decimal spdIn = Math.Round(decimal.Parse(newSpd.Text), 2);
                p.InsertData(idIn, newName.Text, ageIn, heightIn, distIn, spdIn);
                //call InsertData method to create new Player

                //clear textboxes after submit
                newID.Text = "";
                newName.Text = "";
                newAge.Text = "";
                newHeight.Text = "";
                newDist.Text = "";
                newSpd.Text = "";
                //clear error message
                errorProvider.SetError(newSpd, "");
                refresh();
            }
        }

        private void refresh()
        {
            p.DataRead(newPlayerList); //call DataRead on list
            dataGridView1.DataSource = newPlayerList; //set datasource of the datagridview
            SqlDataAdapter playerTableAdapter =
            new SqlDataAdapter("Select * from Players", _conString); //create a new data adapter 
            DataTable playerTable = new DataTable(); //create new data table
            playerTableAdapter.Fill(playerTable); //fill the data table with contents of adapter
            BindingSource bindingSrc = new BindingSource(); 
            bindingSrc.DataSource = playerTable;
            dataGridView1.DataSource = bindingSrc; 

            //set the DataGridView to read only so that user can only edit it using the controls provided
            foreach (DataGridViewBand row in dataGridView1.Columns) //iterate through rows
            {
                row.ReadOnly = true; //set to read only
            }

            //set value of text boxes
            avgDist.Text = p.avgDistance().ToString(); 
            avgSpd.Text = p.averageSpeed().ToString();

            minDist.Text = p.minDist().ToString();
            minSpd.Text = p.minSpeed().ToString();

            maxDist.Text = p.maxDist().ToString();
            maxSpd.Text = p.maxSpeed().ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //check that textboxes are not empty
            if (idUpdate.Text.Equals("") || nameNew.Text.Equals("") ||
              updateAge.Text.Equals("") || updateHeight.Text.Equals("") ||
              updateDist.Text.Equals("") || updateSpd.Text.Equals(""))
            {
                //display an error
                errorProvider.SetError(updateSpd, "Please fill in all fields");
            }
            else
            {
                //if values have been entered into all the textboxes
                int idIn = int.Parse(idUpdate.Text); //parse to int
                int ageIn = int.Parse(updateAge.Text);
                int heightIn = int.Parse(updateHeight.Text);
                int distIn = int.Parse(updateDist.Text);
                double spdIn = double.Parse(updateSpd.Text);
                p.DataUpdate(idIn, nameNew.Text, ageIn, heightIn, spdIn, distIn);
                //call DataUpdate() method on data entered
                refresh();
                //call refresh() to reload the contents of the gridview and the calculated textboxes

                errorProvider.SetError(updateSpd, "");
                //clear error message
                idUpdate.Text = "";
                nameNew.Text = "";
                updateAge.Text = "";
                updateHeight.Text = "";
                updateDist.Text = "";
                updateSpd.Text = "";
                //clear text boxes
            }
        }
        
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delID.Text.Equals("") || delConfirm.Text.Equals("")) //if one of the conditions failed
            {
                //display an error
                errorProvider.SetError(delConfirm, "Please fill in all fields");
            }
            else 
            {
                //if an Id has been entered and confirmed
                int delIn = int.Parse(delID.Text);
                p.DataDelete(delIn);
                //call DataDelete() method
                refresh();  //reload 
                errorProvider.SetError(delConfirm, "");
                //clear error message
                //clear text boxes
                delID.Text = "";
                delConfirm.Text = "";
            }
        }


        //The following code can be ignored; it was generated by Visual Studio 
        //and can't be deleted without causing build errors.

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void updateAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
