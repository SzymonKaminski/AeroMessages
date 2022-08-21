using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 85)]
    public partial class FillBuyOrder
    {
        public ulong Unk1;
        public ulong Unk2;
        public uint Unk3;
        [AeroArray(4)] public byte[] Unk4; // FIXME: What type is this
        public ulong Unk5;
    }
}