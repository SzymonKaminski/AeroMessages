/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 251
    TypeName: Generic
    MsgId: 20
    MsgName: LocalProximityAbilitySuccess
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class Generic_Command_LocalProximityAbilitySuccess
    {
        public EntityId Source;
        public byte Unk;

        //[AeroSDB("aptfs::RegisterClientProximityCommandDef", "id")]
        public uint ClientProximityCommandId;

        [AeroArray(typeof(byte))]
        public EntityId[] Targets;

        public uint Time;
    }
}