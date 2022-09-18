using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 72)]
    public partial class BountyListActiveAck
    {
        public byte Unk1;
        public byte Unk2;
        [AeroString(typeof(ushort))] public string JSON;
    }
}