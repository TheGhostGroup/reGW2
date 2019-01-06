using System.Collections.Generic;
using System.Xml.Serialization;

namespace GW2Emu.Common
{
    [XmlRoot(ElementName = "Message", Namespace = "", IsNullable = false)]
    public class AccountUserInfoMsg : StsMessage
    {
        public override string MessageHeader
        {
            get { return "STS/1.0 200 OK"; }
        }

        [XmlElement] public string UserId = "";

        [XmlElement] public byte UserCenter;

        [XmlElement] public string UserName = "";

        [XmlElement] public string Limits = "";

        [XmlElement] public Logins Logins;

        [XmlElement] public int ChangeId;
    }

    public class Logins
    {
        [XmlAttribute(AttributeName = "type")] public string Type = ""; //*10.51.69.34:6600 1001 1 17 376544805 1417841

        [XmlElement(ElementName = "Location")] public string Location;
    }
}
