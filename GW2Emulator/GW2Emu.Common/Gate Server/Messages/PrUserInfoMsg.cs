using System.Xml.Serialization;

namespace GW2Emu.Common
{
    [XmlRoot(ElementName = "Message", Namespace = "", IsNullable = false)]
    public class PrUserInfoMsg : StsMessage
    {
        public override string MessageHeader
        {
            get { return "STS/1.0 200 OK"; }
        }
    }
}
