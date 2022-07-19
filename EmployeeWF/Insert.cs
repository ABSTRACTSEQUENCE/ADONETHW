using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace EmployeeWF
{
    public partial class Insert : Form
    {
        public SqlParameter[] pars;
        public SqlCommand cmd { get;}
        public DataSet ds;
        public Insert(SqlConnection conn, DataSet DS)
        {
            InitializeComponent();
            cmd = new SqlCommand("SELECT PositionID, PositionName FROM Position", conn);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                string str = data[0].ToString() + " " + data[1].ToString();
                pos.Items.Add(str);
            }
            data.Close();
            ds = DS;
        }
        private void done_Click(object sender, System.EventArgs e)
        {
            pars = new SqlParameter[]
            {
                new SqlParameter("EmployeeID", SqlDbType.Int),
                new SqlParameter("FirstName", tb_fn.Text),
                new SqlParameter("LastName", tb_ln.Text),
                new SqlParameter("BirthDate", SqlDbType.Date),
                new SqlParameter("PositionID", pos.Text[0])
            };
            cmd.CommandText = "stp_EmployeeAdd";
            cmd.CommandType = CommandType.StoredProcedure;
            pars[0].Direction = ParameterDirection.Output;
            pars[3].Value = bd.Text;
            cmd.Parameters.AddRange(pars);
            DataRow row = ds.Tables[0].NewRow();
            try
            {
                row.ItemArray = new object[] { 0, pars[1].Value, pars[2].Value, pars[3].Value, pars[4].Value };
            }
            catch (System.Exception)
            {
                MessageBox.Show("Неверно введена дата");
                return;
            }
            ds.Tables[0].Rows.Add(row);
            Close();
        }
    }
}
