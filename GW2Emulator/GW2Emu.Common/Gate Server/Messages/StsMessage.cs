using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace GW2Emu.Common
{
    [XmlRoot(ElementName = "Reply", Namespace = "", IsNullable = false)]
    public class StsMessage
    {
        public virtual string MessageHeader
        {
            get { return "STS/1.0 200 OK"; }
        }

        private static readonly XmlSerializerNamespaces Namespace =
            new XmlSerializerNamespaces(new[] {new XmlQualifiedName("", "")});

        private static readonly XmlWriterSettings Settings = new XmlWriterSettings
                                                                 {
                                                                     Indent = true,
                                                                     IndentChars = "",
                                                                     NewLineChars = "\n",
                                                                     OmitXmlDeclaration = true,
                                                                 };


        public virtual byte[] BuildStsMessage()
        {
            using (var sw = new StreamWriter(new MemoryStream(), Encoding.ASCII))
            {
                new XmlSerializer(GetType()).Serialize(XmlWriter.Create(sw, Settings), this, Namespace);
                sw.Write("\n");
                return ((MemoryStream) sw.BaseStream).ToArray();
            }
        }

        public override string ToString()
        {
            using (var sw = new StringWriter())
            {
                new XmlSerializer(GetType()).Serialize(XmlWriter.Create(sw, Settings), this, Namespace);
                sw.Write("\n");
                return sw.ToString();
            }
        }
    }
}
