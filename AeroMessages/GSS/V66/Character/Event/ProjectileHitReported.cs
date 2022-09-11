using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 97)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 11, 97)]
    public partial class ProjectileHitReported
    {
        public ushort Unk1; // Matches Unk1 in ReportProjectileHit?
        public ushort ShortTime; 
        public byte Unk2;
        public byte Unk3;
    }
}