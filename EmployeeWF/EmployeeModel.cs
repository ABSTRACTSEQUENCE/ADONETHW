using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EmployeeWF
{
    public class EmployeeModel
    {
        public string FN { get; set; }
        public string LN { get; set; }
        public DateTime BD { get; set; }
        public int ID { get; set; }
        public int PosID { get; set; }

        public EmployeeModel(SqlParameter[]pars) 
        {
            pars[0].Value = FN;
            pars[1].Value = LN;
            pars[2].Value = BD;
            pars[3].Value = PosID;
            pars[4].Value = ID;
        }
    }
}
