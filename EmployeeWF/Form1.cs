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
        DataSet dataset = new DataSet();
        //SqlCommandBuilder builder;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["str"].ConnectionString);
        public Form1()
        {
            InitializeComponent();
            dataGridView1.MultiSelect = false;
            to_del = new List<SqlCommand>();
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

            adapter.InsertCommand = ins.cmd;

            dataset = ins.ds;

            bt_save.Enabled = true;
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Не выбран ни один элемент");

            adapter.DeleteCommand = new SqlCommand("stp_EmployeeDelete", conn);
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
            adapter.DeleteCommand.Parameters.AddWithValue("EmployeeID", dataGridView1.SelectedRows[0].Cells[0].Value);
            adapter.DeleteCommand.Parameters.AddWithValue("Result", 1);
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            to_del.Add(adapter.DeleteCommand);
            bt_save.Enabled = true;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            foreach (SqlCommand i in to_del)
            {
                adapter.DeleteCommand = i;
                adapter.DeleteCommand.ExecuteNonQuery();
            }
            adapter.Update(dataset);
            bt_save.Enabled = false;

        }
    }
}
