﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AdonetHWEntities : DbContext
    {
        public AdonetHWEntities()
            : base("name=AdonetHWEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employee { get; set; }
    
        public virtual int stp_EmployeeAdd(string firstName, string lastName, Nullable<System.DateTime> birthDate, Nullable<int> positionID, ObjectParameter employeeID)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var birthDateParameter = birthDate.HasValue ?
                new ObjectParameter("BirthDate", birthDate) :
                new ObjectParameter("BirthDate", typeof(System.DateTime));
    
            var positionIDParameter = positionID.HasValue ?
                new ObjectParameter("PositionID", positionID) :
                new ObjectParameter("PositionID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_EmployeeAdd", firstNameParameter, lastNameParameter, birthDateParameter, positionIDParameter, employeeID);
        }
    
        public virtual int stp_EmployeeDelete(Nullable<int> employeeID, ObjectParameter result)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_EmployeeDelete", employeeIDParameter, result);
        }
    
        public virtual int stp_EmployeeUpdate(Nullable<int> employeeID, string firstName, string lastName, Nullable<System.DateTime> birthDate, Nullable<int> positionID, ObjectParameter result)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var birthDateParameter = birthDate.HasValue ?
                new ObjectParameter("BirthDate", birthDate) :
                new ObjectParameter("BirthDate", typeof(System.DateTime));
    
            var positionIDParameter = positionID.HasValue ?
                new ObjectParameter("PositionID", positionID) :
                new ObjectParameter("PositionID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_EmployeeUpdate", employeeIDParameter, firstNameParameter, lastNameParameter, birthDateParameter, positionIDParameter, result);
        }
    }
}
