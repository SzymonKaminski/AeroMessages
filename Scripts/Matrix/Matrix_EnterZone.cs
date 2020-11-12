using Bitter;
using System;
namespace PacketPeepScript
{
    [Script(MessageType.Matrix, 37)]
    public class EnterZone : BaseScript
    {
        public ulong InstanceId;
        public uint ZoneId;
        public ulong ZoneTimestamp;
        public byte PreviewModeFlag;
        public string ZoneOwner;
        public byte[] Unk1;
        public byte HotfixLevel;
        public ulong MatchId;
        public byte[] Unk2;
        public uint Unk3;
        public string ZoneName;
        public byte Unk4;
        public byte[] Unk_ZoneTime;
        public DateTimeOffset Unk5_MicroUnix;
        public DateTimeOffset Unk6_MicroUnix;
        public byte[] Unk7;
        public float Timescale;
        public byte[] Unk8;
        public byte SpectatorModeFlag;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            if (true) {
                InstanceId = Stream.Read.ULong();
                ZoneId = Stream.Read.UInt();
                ZoneTimestamp = Stream.Read.ULong();
                PreviewModeFlag = Stream.Read.Byte();
                ZoneOwner = Stream.Read.String(GetNullTerminatedStrSize(Stream));
                Unk1 = Stream.Read.ByteArray(6);
                HotfixLevel = Stream.Read.Byte();
                MatchId = Stream.Read.ULong();
                Unk2 = Stream.Read.ByteArray(1);
                Unk3 = Stream.Read.UInt();
                ZoneName = Stream.Read.String(GetNullTerminatedStrSize(Stream));
                Unk4 = Stream.Read.Byte();
                Unk_ZoneTime = Stream.Read.ByteArray(16);
                Unk5_MicroUnix = Stream.Read.MicroUnixToMillis();
                Unk6_MicroUnix = Stream.Read.MicroUnixToMillis();
                Unk7 = Stream.Read.ByteArray(4);
                Timescale = Stream.Read.Float();
                Unk8 = Stream.Read.ByteArray(17);
                SpectatorModeFlag = Stream.Read.Byte();
            }
        }

        // Reads until we find 0x00, then resets the head and returns the number of bytes read.
        private int GetNullTerminatedStrSize(Bitter.BinaryStream Stream)
        {
            long StartOffset = Stream.baseStream.ByteOffset;
            do
            {
                byte b = Stream.Read.Byte();
                if (b == 0x00)
                {
                    break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
            long EndOffset = Stream.baseStream.ByteOffset;
            Stream.baseStream.ByteOffset = StartOffset;
            return (int)(EndOffset - StartOffset);
        } 
    }

    public static class MyExtensions
    {
        public static DateTimeOffset MicroUnixToMillis(this Bitter.BinaryReader R)
        {
            ulong Micros = R.ULong();
            ulong Millis = Micros / 1000;
            return DateTimeOffset.FromUnixTimeMilliseconds((long) Millis);
        }
    }
}