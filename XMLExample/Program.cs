using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLExample
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Company));

            FileStream fs = new FileStream("sample_company.xml", FileMode.Open);

            Company co = (Company) xs.Deserialize(fs);

            fs.Close();

            CompanyEmployee e = new CompanyEmployee();
            e.DepartmentID = 12;
            e.EmployeeID = 100;
            e.Name = "Nagarjuna";

            CompanyEmployee[] ceArr = new CompanyEmployee[1];
            ceArr[0] = e;

            co.Employees = ceArr;

            FileStream fswrite = new FileStream("new_company.xml", FileMode.OpenOrCreate);

            xs.Serialize(fswrite, co);
            fswrite.Close();
            ;
        }
    }
}
