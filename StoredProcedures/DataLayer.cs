using System;
using System.Configuration;
using System.Data;
//using static StoredProcedures.Employee;
using System.Data.SqlClient;
using static System.Console;
namespace StoredProcedures
{
    static class DataLayer
    {
        static string conn_string { get; set; } = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        static SqlConnection conn;
        public static void Employee_add(SqlParameter[] pars)
        {
            using (conn = new SqlConnection(conn_string))
            {
                conn.Open();
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Connection Sucessfull");
                ForegroundColor = ConsoleColor.White;
                SqlCommand cmd = new SqlCommand("stp_EmployeeAdd", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(pars);
                {/*

                    foreach (SqlParameter i in pars)
                    {
                        switch (i.ParameterName)
                        {
                            case "FirstName":
                                cmd.Parameters.AddWithValue("FirstName", (string)i.Value);
                                break;
                            case "LastName":
                                cmd.Parameters.AddWithValue("LastName", (string)i.Value);
                                break;
                            case "BirthDate":
                                cmd.Parameters.AddWithValue("BirthDate", (DateTime)i.Value);
                                break;
                            case "PositionID":
                                cmd.Parameters.AddWithValue("PositionID", (int)i.Value);
                                break;
                            case "EmployeeID":
                                cmd.Parameters.AddWithValue("EmployeeID", (int)i.Value);
                                break;
                        }
                    }
                    
        
                */
                }
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Wrong parameters");
                    return;
                }
                WriteLine("Operation Sucessful!");
            }
            conn.Close();
            conn.Dispose();
        }
        public static void Employee_add(string fn, string ln, DateTime bd, int posID, int ID)
        {
            using (conn = new SqlConnection(conn_string))
            {
                conn.Open();
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Connection Sucessfull");
                ForegroundColor = ConsoleColor.White;
                SqlCommand cmd = new SqlCommand("stp_EmployeeAdd", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("FirstName", fn);
                cmd.Parameters.AddWithValue("LastName", ln);
                cmd.Parameters.AddWithValue("BirthDate", bd);
                cmd.Parameters.AddWithValue("PositionID", posID);
                cmd.Parameters.AddWithValue("EmployeeID", ID);
                cmd.ExecuteNonQuery();
                WriteLine("Operation Sucessful");
            }
            conn.Close();
            conn.Dispose();
        }
        public static void Employee_Delete(int ID)
        {
            using (conn = new SqlConnection(conn_string))
            {
                conn.Open();
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Connection Sucessfull");
                ForegroundColor = ConsoleColor.White;
                SqlCommand cmd = new SqlCommand("stp_EmployeeDelete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("EmployeeID", ID);
                cmd.Parameters.AddWithValue("Result", 0);
                cmd.ExecuteNonQuery();
                Write("Operation Sucsessful");
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
