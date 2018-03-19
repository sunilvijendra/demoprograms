using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLExample
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Company
    {
        private CompanyEmployee[] employeesField;

        private CompanyDepartment[] departmentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Employee", IsNullable = false)]
        public CompanyEmployee[] Employees
        {
            get
            {
                return this.employeesField;
            }
            set
            {
                this.employeesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Department", IsNullable = false)]
        public CompanyDepartment[] Departments
        {
            get
            {
                return this.departmentsField;
            }
            set
            {
                this.departmentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CompanyEmployee
    {

        private string nameField;

        private ushort employeeIDField;

        private byte departmentIDField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ushort EmployeeID
        {
            get
            {
                return this.employeeIDField;
            }
            set
            {
                this.employeeIDField = value;
            }
        }

        /// <remarks/>
        public byte DepartmentID
        {
            get
            {
                return this.departmentIDField;
            }
            set
            {
                this.departmentIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CompanyDepartment
    {

        private string nameField;

        private byte idField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }


}
