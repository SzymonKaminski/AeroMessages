using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 138)]
    public partial class Character_Event_ActivateConsumable
    {
        public uint Time;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ItemSdbId;
    }
}