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

            FileStream fs = new FileStream(@"C:\Users\sunilvijendra\Documents\rockwell_csharp\DemoPrograms\XMLExample\sample_company.xml", FileMode.Open);

            Company co = (Company) xs.Deserialize(fs);
        }
    }
}
