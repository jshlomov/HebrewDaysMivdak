using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HebrewDaysMivdak
{
    public class XmlService
    {
        string path;
        XDocument document;

        public XmlService(string path)
        {
            this.path = path;
            if (!File.Exists(path))
            {
                new XDocument(new XElement("Queries")).Save(path);
            }
            document = XDocument.Load(path);
        }

        public void CreateQuery(HebrewDateModel query)
        {
            document.Root.Add(QueryToXml(query));
            document.Root.Save(path);
        }

        private XElement QueryToXml(HebrewDateModel query)
        {
            return new XElement("Query",
                new XElement("Day", query.Day),
                new XElement("DayMonth", query.DayMonth),
                new XElement("Month", query.Month),
                new XElement("Year", query.Year),
                new XElement("Result", query.Result)
                );

        }
    }
}
