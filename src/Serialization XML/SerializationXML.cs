using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CodeUtilities
{
    class SerializationXML
    {
        public byte[] serializeObject(Type typeObject, object objectExample)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObjectExample));
            MemoryStream memoryStream = new MemoryStream();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
            xmlSerializer.Serialize(xmlTextWriter, objectExample);
            memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
            byte[] byteMemoryStream = memoryStream.ToArray();
            memoryStream.Close();
            return byteMemoryStream;
        }

        public object deserializerObject(byte[] byteSerialization)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObjectExample));
            MemoryStream memoryStream = new MemoryStream(byteSerialization);
            StreamReader streamReader = new StreamReader(memoryStream);
            ObjectExample ObjectExample = (ObjectExample)xmlSerializer.Deserialize(streamReader);
            streamReader.Close();
            memoryStream.Close();
            return ObjectExample;
        }

        /*--------- Sample Object ---------*/

        [XmlRootAttribute("ObjectExample")]
        public class ObjectExample
        {
            [XmlElementAttribute("StockNumber")]
            public string attribute1{ get; set; }

            [XmlElementAttribute("Make")]
            public string attribute2{ get; set; }

            [XmlElementAttribute("Model")]
            public string attribute3{ get; set; }
        }
    }
}
