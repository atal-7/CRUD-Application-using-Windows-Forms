using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;


namespace DemoProject
{
    public partial class DataPage : Form
    {
        SQLiteConnection myConnection = new SQLiteConnection(@"Data Source= D:\BCDB\BCDB.db");

        public DataPage()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataPage_Load(object sender, EventArgs e)
        {
           ReadData();
            List_grid.Visible = false;
            InitButtonState();
            textBoxState(false);
        }
        public void ReadData()
        {
            myConnection.Open();
            var datable = new DataTable();
            string commandText = "SELECT * FROM bcDB";
            SQLiteDataAdapter myAdapter = new SQLiteDataAdapter(commandText, myConnection);
            myAdapter.Fill(datable);
            List_grid.DataSource = datable;
            myConnection.Close();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        private void ClearTextBoxes()
        {
            Company_txt.Text = "";
            Fname_txt.Text = "";
            Lname_txt.Text = "";
            Title_txt.Text = "";
        }
       
        private void InsertData()
        {
            myConnection.Open();
            SQLiteCommand myCommand= new SQLiteCommand(myConnection);
            myCommand.CommandText = "INSERT INTO bcDB (Company,Fname, Lname,Title) values('"+Company_txt.Text+"', '"+Fname_txt.Text+"', '"+Lname_txt.Text+ "', '"+Title_txt.Text+"')";
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            MessageBox.Show("Data Saved");
            ReadData();
            ClearTextBoxes() ;
        }
        private void UpdateData(int x)
        {
            myConnection.Open();
            SQLiteCommand myCommand=new SQLiteCommand(myConnection);
            myCommand.CommandText = "UPDATE bcDB SET Company= '" + Company_txt.Text + "', Fname='" + Fname_txt.Text + "', Lname='" + Lname_txt.Text + "', Title= '" + Title_txt.Text + "' WHERE ID=" + x;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            ReadData() ;
            ClearTextBoxes();
        }
        
        private void DeleteData(int x)
        {
            myConnection.Open();
            SQLiteCommand myCommand = new SQLiteCommand(myConnection);
            myCommand.CommandText = " DELETE FROM bcDB WHERE ID=" + x;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        

        private void textBoxState(bool state)
        {
            if (state)
            {
                Company_txt.Enabled = true;
                Fname_txt.Enabled = true;
                Lname_txt.Enabled = true;
                Title_txt.Enabled = true;
            }
            else
            {
                Company_txt.Enabled = false;
                Fname_txt.Enabled = false;
                Lname_txt.Enabled = false;
                Title_txt.Enabled = false;
            }
        }
        private void InitButtonState()
        {
            New_btn.Enabled = true;
            Save_btn.Enabled = false;
            Edit_btn.Enabled = false;
            Delete_btn.Enabled = false;
            Cancel_btn.Enabled = false;
        }


        private void List_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBoxState(false);
            Delete_btn.Enabled = true;
            Edit_btn.Enabled = true;
            Cancel_btn.Enabled = true;
            New_btn.Enabled = false;
            Clear_btn.Enabled = true;  
        }

        // Buttons

        private void New_btn_Click(object sender, EventArgs e)
        {
            New_btn.Enabled = true;
            Save_btn.Enabled = true;
            Cancel_btn.Enabled = true;
            textBoxState(true);
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            InsertData();
            textBoxState(false);
            InitButtonState();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            textBoxState(true);
            Company_txt.Text= List_grid.CurrentRow.Cells["Company"].Value.ToString();
            Fname_txt.Text = List_grid.CurrentRow.Cells["Fname"].Value.ToString();
            Lname_txt.Text = List_grid.CurrentRow.Cells["Lname"].Value.ToString();
            Title_txt.Text = List_grid.CurrentRow.Cells["Title"].Value.ToString();
        }
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            int recordId = Convert.ToInt32(List_grid.CurrentRow.Cells["ID"].Value);
            DeleteData(recordId);
            MessageBox.Show("Data Deleted!");
            ReadData();
            InitButtonState();
            textBoxState(false);
        }
        private void Update_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(List_grid.CurrentRow.Cells["ID"].Value);
            UpdateData(id);
            MessageBox.Show("Data Updated");
        }
        private void Cancle_btn_Click(object sender, EventArgs e)
        {
            textBoxState(false);
            InitButtonState() ;
            ClearTextBoxes();
        }

        private void Quit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_btn_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void View_btn_Click(object sender, EventArgs e)
        {
            List_grid.Visible = true;
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
