using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace EmployeeWF
{
    /*
	По аналогии с проектом, созданным на уроке,
	выполнить действия Delete, Insert, Update, Select для таблицы Employee 
	( через соответствующие классы в коде).
	Добавить через WF возможность работы с данными таблицы Employee, 
	с различными выборами, добавить поле картинка (изображение сотрудника).
	*/
    public partial class Form1 : Form
    {
        SqlDataAdapter adapter;
        List<SqlCommand> to_del;
        List<SqlCommand> to_add;
        DataSet dataset = new DataSet();
        //SqlCommandBuilder builder;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["str"].ConnectionString);
        public Form1()
        {
            InitializeComponent();
            dataGridView1.MultiSelect = false;
            to_del = new List<SqlCommand>();
            to_add = new List<SqlCommand>();
            //builder = new SqlCommandBuilder(adapter);
            bt_save.Enabled = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            conn.Open();
            adapter = new SqlDataAdapter(@"SELECT
                EmployeeID,
                FirstName,
				LastName, BirthDate,
				PositionName
				FROM Employee, Position
				WHERE Employee.PositionID = Position.PositionID", conn);
            adapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void bt_ins_Click(object sender, EventArgs e)
        {
            Insert ins = new Insert(conn, dataset);
            ins.ShowDialog();

            to_add.Add(ins.cmd);

            dataset = ins.ds;

            ins.Dispose();

            bt_save.Enabled = true;
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Не выбран ни один элемент");

            SqlCommand cmd = new SqlCommand("stp_EmployeeDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("EmployeeID", dataGridView1.SelectedRows[0].Cells[0].Value);
            cmd.Parameters.AddWithValue("Result", 1);
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            to_del.Add(cmd);
            bt_save.Enabled = true;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            foreach (SqlCommand i in to_del)
            {
                adapter.DeleteCommand = i;
                adapter.DeleteCommand.ExecuteNonQuery();
                adapter.DeleteCommand.Dispose();
            }

            foreach (SqlCommand i in to_add)
            {
                adapter.InsertCommand = i;
                adapter.InsertCommand.ExecuteNonQuery();
                adapter.InsertCommand.Dispose();
            }
            //adapter.Update(dataset);
            bt_save.Enabled = false;

        }
    }
}
