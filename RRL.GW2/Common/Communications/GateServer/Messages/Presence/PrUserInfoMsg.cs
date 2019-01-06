using System.Xml.Serialization;

namespace RRL.GW2.Common.Communications.GateServer.Messages.Presence
{
    /// <summary>
    /// Author: Ara(ra)gi
    /// </summary>
    [XmlRoot(ElementName = "Message", Namespace = "", IsNullable = false)]
    public class PrUserInfoMsg : StsMessage
    {
        public override string MessageHeader
        {
            get { return "STS/1.0 200 OK"; }
        }
    }
}
