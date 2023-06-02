using HealthEat.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HealthEat.Core.Serializer
{
    public class Serizalizer
    {
        public string SerializeObjectToXmlString(List<Favorites> favorites)
        {
            string path = $"{typeof(Favorites)}_file.xml";
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(Favorites));
                using (var writer = new StreamWriter(path))
                {
                    foreach (var f in favorites)
                    {
                        xmlSerializer.Serialize(writer, favorites);
                        var xmlContent = writer.ToString();
                        Console.WriteLine(xmlContent);
                    }
                }

                return "Success";
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error");
            }
        }

        public string DeserializeXmlFileToList()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Favorites>));
            using (var reader = new StringReader(""))
            {
                var result = (List<Favorites>)xmlSerializer.Deserialize(reader);
            }

            return "Success";
        }
    }
}
