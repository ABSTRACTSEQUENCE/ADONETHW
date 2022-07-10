using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static System.Console;
namespace StoredProcedures
{
    class Program
    {
        static void Main(string[] args)
        {
            { //решил немного поиграть с классом SqlParameter
              SqlParameter[] pars =
              {
                new SqlParameter("FirstName", "Pavel"),
                new SqlParameter("LastName", "Kuzmin"),
                new SqlParameter("BirthDate", new DateTime(2001,05,22)),
                new SqlParameter("EmployeeID", 5),
                new SqlParameter("PositionID", 1)
              };
               // DataLayer.Employee_add(pars);
                //DataLayer.Employee_add("Pavel", "Kuzmin", new DateTime(2001, 05, 22), 1, 1);
            }
            DataLayer.Employee_Delete(27);
        }
    }
}
