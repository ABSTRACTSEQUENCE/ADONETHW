using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace StoredProcedures
{
    class Employee
    {
        public int id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set;}
        public DateTime BirthDate { get; set; }
        public Employee(int ID, string fname, string lname)
        {
            id = ID;
            Fname = fname;
            Lname = lname;
        }
    }
}
