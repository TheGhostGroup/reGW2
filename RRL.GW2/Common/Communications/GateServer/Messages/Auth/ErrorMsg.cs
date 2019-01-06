using System.Xml.Serialization;

namespace RRL.GW2.Common.Communications.GateServer.Messages.Auth
{
    /// <summary>
    /// Author: Ara(ra)gi
    /// </summary>
    [XmlRoot(ElementName = "Error", Namespace = "", IsNullable = false)]
    public class ErrorMsg : StsMessage
    {
        public override string MessageHeader
        {
            get { return "STS/1.0 400 Success"; }
        }

        [XmlAttribute(AttributeName = "server")] public int Server;

        [XmlAttribute(AttributeName = "module")] public int Module;

        [XmlAttribute(AttributeName = "line")] public int Line;
    }
}
