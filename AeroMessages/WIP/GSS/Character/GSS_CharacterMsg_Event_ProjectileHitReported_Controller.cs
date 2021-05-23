/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 97
    MsgName: ProjectileHitReported
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_ProjectileHitReported_Controller
    {
        // TODO: Verify if same as view or not
        [AeroArray(2)]
        public byte[] Unk1;
        public ushort ShortTime;
    }
}