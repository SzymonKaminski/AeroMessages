using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 111)]
    public partial class CollectLoot
    {
        public EntityId LootEntityID;
        public uint Unk;

        [AeroSdb("dbitems:RootItem", "sdb_id")]
        public uint LootSdbID;
    }
}