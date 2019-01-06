using System.Xml.Serialization;

namespace RRL.GW2.Common.Communications.GateServer.Messages.Session
{
    [XmlRoot(ElementName = "Reply", Namespace = "", IsNullable = false)]
    public class CreateSessionMsg : StsMessage
    {
        public override string MessageHeader
        {
            get { return "STS/1.0 200 OK"; }
        }

        [XmlElement] public string SessionId;
    }
}
