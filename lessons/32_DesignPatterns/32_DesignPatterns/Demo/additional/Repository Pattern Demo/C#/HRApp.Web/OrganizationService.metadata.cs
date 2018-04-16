
namespace HRApp.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;    
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using System.Data;
    using System.Data.Linq;


    // The MetadataTypeAttribute identifies EmployeeMetadata as the class
    // that carries additional metadata for the Employee class.
    [MetadataTypeAttribute(typeof(Employee.EmployeeMetadata))]
    public partial class Employee
    {

#pragma warning disable 649    // temporarily disable compiler warnings about unassigned fields

        // This class allows you to attach custom attributes to properties
        // of the Employee class.
        //
        // For example, the following marks the Xyz property as a
        // required field and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression(“[A-Z][A-Za-z0-9]*”)]
        //    [StringLength(32)]
        //    public string Xyz;
        internal sealed class EmployeeMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private EmployeeMetadata()
            {
            }

            public int EmployeeID;

            public string NationalIDNumber;

            public int ContactID;

            public string LoginID;

            public string Title;

            public DateTime BirthDate;

            public string MaritalStatus;

            [Required]
            [CustomValidation(typeof(HRApp.Web.GenderValidator), "IsGenderValid")]
            public string Gender;

            [Range(0, 70)]
            public short VacationHours;

            public DateTime HireDate;

            public bool SalariedFlag;

            public short SickLeaveHours;

            public bool CurrentFlag;

            public Guid rowguid;

            public DateTime ModifiedDate;

            [Display(AutoGenerateField=false)]
            public EntitySet<Employee> Employees;

            [Display(AutoGenerateField = false)]
            public Employee Employee1;            
        }

#pragma warning restore 649    // re-enable compiler warnings about unassigned fields
    }
}
