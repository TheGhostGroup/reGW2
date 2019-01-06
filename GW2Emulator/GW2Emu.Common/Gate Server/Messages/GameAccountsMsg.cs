using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace GW2Emu.Common
{
    [XmlRoot(ElementName = "Reply", Namespace = "", IsNullable = false)]
    public class GameAccountsMsg : StsMessage
    {
        public override string MessageHeader
        {
            get { return "STS/1.0 200 OK"; }
        }

        [XmlAttribute(AttributeName = "type")] public string Type = "";

        [XmlElement("Row", Form = XmlSchemaForm.Unqualified)]
        public List<Row> AccsRows = new List<Row>();
    }

    public class Row
    {
        [XmlElement] public string GameCode = "";

        [XmlElement] public string Alias = "";

        [XmlElement] public string Created = "";
    }
}
