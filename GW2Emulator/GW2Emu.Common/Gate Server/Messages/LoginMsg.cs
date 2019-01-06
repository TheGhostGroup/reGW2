using System.Xml.Serialization;

namespace GW2Emu.Common
{
    [XmlRoot(ElementName = "Reply", Namespace = "", IsNullable = false)]
    public class LoginMsg : StsMessage
    {
        public override string MessageHeader
        {
            get { return "STS/1.0 200 OK"; }
        }

        [XmlElement]
        public string UserId = "";

        [XmlElement]
        public byte UserCenter;

        [XmlElement]
        public byte HasPhone = 0;

        [XmlElement]
        public byte EmailVerified = 0;
    }
}
