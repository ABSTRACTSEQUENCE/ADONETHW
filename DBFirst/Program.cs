using System;
using System.Linq;
namespace DBFirst
{
	class Program
	{
		static void Main(string[] args)
		{
			var entities = new AdonetHWEntities();

			void select(int id)
			{
				if (id == 0)
				{
		
					foreach (Employee i in entities.Employee.AsEnumerable())
					{
						Console.WriteLine("First Name : " + i.FirstName);
						Console.WriteLine("Second Name : " + i.LastName);
						Console.WriteLine("Birth Date : " + i.BirthDate.Value.ToShortDateString());
						Console.WriteLine("-----------------------------------");
					}
				}
				else
				{
					foreach (Employee i in entities.Employee.AsEnumerable())
					{
						if (i.EmployeeID == id)
						{
							Console.WriteLine("First Name : " + entities.Employee.Find(id).FirstName);
							Console.WriteLine("Second Name : " + entities.Employee.Find(id).LastName);
							Console.WriteLine("Birth Date : " + entities.Employee.Find(id).BirthDate.Value.ToShortDateString());
							Console.WriteLine("-----------------------------------");
							break;
						}
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Employee with ID: {0} does not exist", id);
						Console.ForegroundColor = ConsoleColor.White;
						return;
					}
				}

			}

			void add(string fn, string ln, DateTime bd, int pos_id)
			{
				int id = entities.Employee.AsEnumerable().Last().EmployeeID + 1;
				entities.stp_EmployeeAdd(fn, ln, bd, pos_id, new System.Data.Entity.Core.Objects.ObjectParameter("EmployeeID", id)); //Я так и не понял почему при добавлении сотрудника его id не соответствует ни переданному значению, ни последнему значению, назначенному хранимой процедурой (функция SCOPE_IDENTITY())
				Console.WriteLine("Added " + fn + " " + ln);
			}

			void delete(string fn, string ln)
			{
				int id = 0;
				foreach (Employee i in entities.Employee.AsEnumerable())
					if (i.FirstName == fn && i.LastName == ln)
					{
						id = i.EmployeeID;
						break;
					}
				if (id == 0)
				{
					Console.WriteLine(fn + " " + ln + " does not exist");
					return;
				}

				entities.stp_EmployeeDelete(id, new System.Data.Entity.Core.Objects.ObjectParameter("Result", 1));
				Console.WriteLine("Deleted " + fn + " " + ln);


			}

			void update(int id, string fn, string ln, DateTime bd, int pos_id)
			{
				entities.stp_EmployeeUpdate(id, fn, ln, bd, pos_id, new System.Data.Entity.Core.Objects.ObjectParameter("Result", 1));
			}

			////////////////////////////////////////////////////////////////////////////////////

			add("John", "Doe", new DateTime(1990, 05, 05), 2);//Добавление Employee

			select(0);//Выборка Employee по ID (если ID = 0, выборка всех) и вывод их на экран

			delete("John", "Doe");
			Console.ReadLine();


		}


	}
}
