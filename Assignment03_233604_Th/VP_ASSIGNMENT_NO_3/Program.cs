using System;
using System.Xml;

namespace VP_ASSIGNMENT_NO_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";

            using (XmlWriter writer = XmlWriter.Create("GPS.xml", settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("GPS_Log");

                writer.WriteStartElement("Position");
                writer.WriteAttributeString("DateTime", DateTime.Now.ToString());
                writer.WriteElementString("x", "65.8973342");
                writer.WriteElementString("y", "72.3452346");

                writer.WriteStartElement("SatteliteInfo");
                writer.WriteElementString("Speed", "40");
                writer.WriteElementString("NoSatt", "7");
                writer.WriteEndElement();

                writer.WriteEndElement();

                writer.WriteStartElement("Image");
                writer.WriteAttributeString("Resolution", "1024x800");
                writer.WriteElementString("Path", @"\images\1.jpg");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            Console.WriteLine("XML file created successfully!");
            Console.WriteLine("Press Enter to read the XML file...");
            Console.ReadLine();

            ReadXML();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void ReadXML()
        {
            Console.WriteLine("\nReading the generated XML file...");
            using (XmlReader reader = XmlReader.Create("GPS.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        Console.WriteLine($"Element: {reader.Name}");
                        if (reader.HasAttributes)
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                Console.WriteLine($" -> Attribute: {reader.Name} = {reader.Value}");
                            }
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.Text)
                    {
                        Console.WriteLine($" -> Value: {reader.Value}");
                    }
                }
            }
        }
    }
}
