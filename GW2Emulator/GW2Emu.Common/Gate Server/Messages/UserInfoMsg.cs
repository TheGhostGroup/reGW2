using System.Xml.Serialization;

namespace GW2Emu.Common
{
    [XmlRoot(ElementName = "Reply", Namespace = "", IsNullable = false)]
    public class UserInfoMsg : StsMessage
    {
        public override string MessageHeader
        {
            get { return "STS/1.0 200 OK"; }
        }

        [XmlElement] public string UserId = "";

        [XmlElement] public byte UserCenter;

        [XmlElement] public string UserName = "";

        [XmlElement] public string LoginName = "";

        [XmlElement] public string TransferGameCode = "";

        [XmlElement] public string EmailVerified = "";

        [XmlElement] public string LastPasswordChange = "";

        [XmlElement] public string DisableForcePasswordChange = "";
    }
}
