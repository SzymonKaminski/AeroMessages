using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 78)]
    public partial class BountyRerollResponse
    {
        public uint BountyDefId;
        public byte Success;
        [AeroString] public string Response;
    }
}