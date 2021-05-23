/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 138
    MsgName: ActivateConsumable
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class CharacterCombatControllerActivateConsumable
    {
        public uint Time;

        //[AeroSDB("dbitems::RootItem", "sdb_id")]
        public uint ItemSdbId;
    }
}