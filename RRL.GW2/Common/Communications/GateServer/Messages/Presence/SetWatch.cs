using System.Xml.Serialization;

namespace RRL.GW2.Common.Communications.GateServer.Messages.Presence
{
    /// <summary>
    /// Author: Ara(ra)gi
    /// </summary>
    [XmlRoot(ElementName = "Reply", Namespace = "", IsNullable = false)]
    public class SetWatch : StsMessage
    {
        public override string MessageHeader
        {
            get { return "STS/1.0 200 OK"; }
        }

        [XmlElement] public string UserId = "";

        [XmlElement] public byte UserCenter;

        [XmlElement] public string UserName = "";

        [XmlElement] public Parts Parts;
    }

    public class Parts
    {
        [XmlElement] public string Aliases;

        [XmlElement] public string AppData;

        [XmlElement] public string Channels;

        [XmlElement] public string Contacts;

        [XmlElement] public string Groups;

        [XmlElement] public string Status;

        [XmlElement] public string Talk;

        [XmlElement] public string Whisper;
    }
}
