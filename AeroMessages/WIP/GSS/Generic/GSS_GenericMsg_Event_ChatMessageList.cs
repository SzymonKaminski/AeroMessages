/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 118
    MsgName: ChatMessageList
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class Generic_Event_ChatMessageList
    {
        public byte Unk1;
        public EntityId SenderId;

        [AeroString]
        public string SenderName;

        [AeroString]
        public string Message;

        public byte Channel;
    }
}