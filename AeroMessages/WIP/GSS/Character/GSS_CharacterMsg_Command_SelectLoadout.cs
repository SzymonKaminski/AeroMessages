/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 150
    MsgName: SelectLoadout
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Combat_SelectLoadout
    {
        public uint LoadoutId;
        public byte Unk;
    }
}