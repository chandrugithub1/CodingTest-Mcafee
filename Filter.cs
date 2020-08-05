using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace CodeTest
{
    class Filter
    {
        public void ReadXml()
        {
            var filename = "Employee.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(currentDirectory, filename);

            XElement employee = XElement.Load(filePath);

            var s = from item in employee.Descendants("root")
                    select (string)item.Attribute("dob");

        }

    }
}
