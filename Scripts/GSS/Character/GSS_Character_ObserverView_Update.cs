using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 8, 1, true)]
    public class CharacterObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            StaticInfo              = 0x00,
            SpawnTime               = 0x01,
            EffectsFlags            = 0x02, // aka flashlight
            GibVisualsID            = 0x03,
            ProcessDelay            = 0x04, // Equivalent of 0x0d on base controller
            CharacterState          = 0x05,
            HostilityInfo           = 0x06, // Not sure about the parsing 
            PersonalFactionStance   = 0x07, // Not sure about the parsing 
            CurrentHealthPct        = 0x08, // % integer
            MaxHealth               = 0x09,
            EmoteID                 = 0x0A,
            AttachedTo              = 0x0B, // used when the character is mounted to a vehicle
            SnapMount               = 0x0C,
            SinFlags                = 0x0D,
            SinFactionsAcquiredBy   = 0x0E,
            SinTeamsAcquiredBy      = 0x0F,
            ArmyGUID                = 0x10,
            OwnerId                 = 0x11,
            NPCType                 = 0x12,
            DockedParams            = 0x13,
            LookAtTarget            = 0x14,
            WaterLevelAndDesc       = 0x15,
            CarryableObjects_0      = 0x16,
            CarryableObjects_1      = 0x17,
            CarryableObjects_2      = 0x18,
            RespawnTimes            = 0x19,
            SinCardType             = 0x1a,
            SinCardFields_0         = 0x1b,
            SinCardFields_1         = 0x1c,
            SinCardFields_2         = 0x1d,
            SinCardFields_3         = 0x1e,
            SinCardFields_4         = 0x1f,
            SinCardFields_5         = 0x20,
            SinCardFields_6         = 0x21,
            SinCardFields_7         = 0x22,
            SinCardFields_8         = 0x23,
            SinCardFields_9         = 0x24,
            SinCardFields_10        = 0x25,
            SinCardFields_11        = 0x26,
            SinCardFields_12        = 0x27,
            SinCardFields_13        = 0x28,
            SinCardFields_14        = 0x29,
            SinCardFields_15        = 0x2a,
            SinCardFields_16        = 0x2b,
            SinCardFields_17        = 0x2c,
            SinCardFields_18        = 0x2d,
            SinCardFields_19        = 0x2e,
            SinCardFields_20        = 0x2f,
            SinCardFields_21        = 0x30,
            SinCardFields_22        = 0x31,
            AssetOverrides          = 0x32,

            // These are not named by the client
            Reset_PersonalFactionStance = 0x87, // Guess
            Reset_AttachedTo            = 0x8b, // Confirmed
            Reset_SinFactionsAcquiredBy = 0x8e, // Guess
            Reset_SinTeamsAcquiredBy    = 0x8f, // Guess
            Reset_LookAtTarget          = 0x94, // Confirmed
            Reset_CarryableObjects_0    = 0x96, // Guess
            Reset_CarryableObjects_1    = 0x97, // Guess
            Reset_CarryableObjects_2    = 0x98, // Guess
            Reset_RespawnTimes          = 0x99, // Guess
            Reset_SinCardFields_0       = 0x9b, // Guess
            Reset_SinCardFields_1       = 0x9c, // Guess
            Reset_SinCardFields_2       = 0x9d, // Guess
            Reset_SinCardFields_3       = 0x9e, // Guess
            Reset_SinCardFields_4       = 0x9f, // Guess
            Reset_SinCardFields_5       = 0xa0, // Guess
            Reset_SinCardFields_6       = 0xa1, // Guess
            Reset_SinCardFields_7       = 0xa2, // Guess
            Reset_SinCardFields_8       = 0xa3, // Guess
            Reset_SinCardFields_9       = 0xa4, // Guess
            Reset_SinCardFields_10      = 0xa5, // Guess
            Reset_SinCardFields_11      = 0xa6, // Guess
            Reset_SinCardFields_12      = 0xa7, // Guess
            Reset_SinCardFields_13      = 0xa8, // Guess
            Reset_SinCardFields_14      = 0xa9, // Guess
            Reset_SinCardFields_15      = 0xaa, // Guess
            Reset_SinCardFields_16      = 0xab, // Guess
            Reset_SinCardFields_17      = 0xac, // Guess
            Reset_SinCardFields_18      = 0xad, // Guess
            Reset_SinCardFields_19      = 0xae, // Guess
            Reset_SinCardFields_20      = 0xaf, // Guess
            Reset_SinCardFields_21      = 0xb0, // Guess
            Reset_SinCardFields_22      = 0xb1, // Guess
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield

        public string StaticInfo;

        public byte? EffectsFlags;
        public uint? GibVisualsID;
        public uint? GibVisualsID_Time;
        public uint? ProcessDelay; 
        public byte? CharacterState;
        public uint? CharacterState_Time;
        public byte[] HostilityInfo;

        public byte[] PersonalFactionStance;

        public byte? CurrentHealthPct;
        public uint? MaxHealth;
        public uint? MaxHealth_Time;
        public ushort? EmoteID; // Sdb table 73, id column
        public uint? EmoteID_Time;

        public byte[] AttachedTo_VehicleEntity1;
        public byte[] AttachedTo_VehicleEntity2;
        public byte[] AttachedTo_Bytes;

        public byte? SnapMount;
        public byte? SinFlags; // guess

        public byte[] SinFactionsAcquiredBy;
        public byte[] SinTeamsAcquiredBy;

        public ulong? ArmyGUID;
        public ulong? OwnerId;
        public uint? NPCType; // guess
        public byte[] DockedParams; // guess

        public byte[] LookAtTarget_TargetId;
        public float[] LookAtTarget_Position;
        public byte[] LookAtTarget_UnkBytes;

        public byte? WaterLevelAndDesc;

        // TODO: CarryableObjects

        public uint? RespawnTimes_Time1;
        public uint? RespawnTimes_Time2;

        public uint? SinCardType;

        // TODO: SinCardFields

        public byte? AssetOverrides;

        public bool? Reset_PersonalFactionStance;
        public bool? Reset_AttachedTo;
        public bool? Reset_SinFactionsAcquiredBy;
        public bool? Reset_SinTeamsAcquiredBy;
        public bool? Reset_LookAtTarget;
        public bool? Reset_CarryableObjects_0;
        public bool? Reset_CarryableObjects_1;
        public bool? Reset_CarryableObjects_2;
        public bool? Reset_RespawnTimes;
        public bool? Reset_SinCardFields_0;
        public bool? Reset_SinCardFields_1;
        public bool? Reset_SinCardFields_2;
        public bool? Reset_SinCardFields_3;
        public bool? Reset_SinCardFields_4;
        public bool? Reset_SinCardFields_5;
        public bool? Reset_SinCardFields_6;
        public bool? Reset_SinCardFields_7;
        public bool? Reset_SinCardFields_8;
        public bool? Reset_SinCardFields_9;
        public bool? Reset_SinCardFields_10;
        public bool? Reset_SinCardFields_11;
        public bool? Reset_SinCardFields_12;
        public bool? Reset_SinCardFields_13;
        public bool? Reset_SinCardFields_14;
        public bool? Reset_SinCardFields_15;
        public bool? Reset_SinCardFields_16;
        public bool? Reset_SinCardFields_17;
        public bool? Reset_SinCardFields_18;
        public bool? Reset_SinCardFields_19;
        public bool? Reset_SinCardFields_20;
        public bool? Reset_SinCardFields_21;
        public bool? Reset_SinCardFields_22;


        public byte[] UnableToParse;
       

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
 
                    case ShadowFieldIndex.StaticInfo:
                        long startOffset = Stream.baseStream.ByteOffset;
                        Stream.Read.StringZ(Stream);
                        Stream.Read.StringZ(Stream);
                        Stream.Read.Byte();
                        Stream.Read.Byte();
                        Stream.Read.UInt();
                        Stream.Read.UInt();
                        Stream.Read.UInt();
                        Stream.Read.Byte();
                        Stream.Read.Byte();
                        Stream.Read.Byte();
                        Stream.Read.UInt();
                        Stream.Read.UInt();
                        Stream.Read.UShort();
                        Stream.Read.UInt();
                        byte numberOfHeadAccessories = Stream.Read.Byte();
                        Stream.Read.UIntArray(numberOfHeadAccessories);
                        Stream.Read.UInt();
                        Stream.Read.UInt();
                        Stream.Read.ByteArray(3);

                        long endOffset = Stream.baseStream.ByteOffset;
                        Stream.baseStream.ByteOffset = startOffset;
                        int length = (int)(endOffset-startOffset);
                        StaticInfo = Stream.Read.String(length);

                        break;

                    case ShadowFieldIndex.EffectsFlags:
                        EffectsFlags = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.GibVisualsID:
                        GibVisualsID = Stream.Read.UInt();
                        GibVisualsID_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.ProcessDelay:
                        ProcessDelay = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.CharacterState:
                        CharacterState = Stream.Read.Byte();
                        CharacterState_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.HostilityInfo:
                        HostilityInfo = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.PersonalFactionStance:
                        PersonalFactionStance = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.CurrentHealthPct:
                        CurrentHealthPct = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.MaxHealth:
                        MaxHealth = Stream.Read.UInt();
                        MaxHealth_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.EmoteID:
                        EmoteID = Stream.Read.UShort();
                        EmoteID_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.AttachedTo:
                        AttachedTo_VehicleEntity1 = Stream.Read.
                        ByteArray(8);
                        AttachedTo_VehicleEntity2 = Stream.Read.
                        ByteArray(8);
                        AttachedTo_Bytes = Stream.Read.ByteArray(3);
                        break;

                    case ShadowFieldIndex.SnapMount:
                        SnapMount = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.SinFlags:
                        SinFlags = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.SinFactionsAcquiredBy:
                        SinFactionsAcquiredBy = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.SinTeamsAcquiredBy:
                        SinTeamsAcquiredBy = Stream.Read.ByteArray(2);
                        break;


                    case ShadowFieldIndex.ArmyGUID:
                        ArmyGUID = Stream.Read.ULong();
                        break;

                    case ShadowFieldIndex.OwnerId:
                        OwnerId = Stream.Read.ULong();
                        break;

                    case ShadowFieldIndex.NPCType:
                        NPCType = Stream.Read.UInt(); // guess
                        break;

                    case ShadowFieldIndex.DockedParams:
                        DockedParams = Stream.Read.ByteArray(19); // guess
                        break;

                    case ShadowFieldIndex.LookAtTarget:
                        LookAtTarget_TargetId = Stream.Read.ByteArray(8);
                        LookAtTarget_Position = Stream.Read.FloatArray(3);
                        LookAtTarget_UnkBytes = Stream.Read.ByteArray(4);
                        break;

                    case ShadowFieldIndex.WaterLevelAndDesc:
                        WaterLevelAndDesc = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.RespawnTimes:
                        RespawnTimes_Time1 = Stream.Read.UInt();
                        RespawnTimes_Time2 = Stream.Read.UInt();
                        break;

                    // TODO: CarryableObjects

                    case ShadowFieldIndex.SinCardType:
                        SinCardType = Stream.Read.UInt();
                        break;
                    
                    // TODO: SinCardFields

                    case ShadowFieldIndex.AssetOverrides:
                        AssetOverrides = Stream.Read.Byte(); // probably more if we have content
                        break;

                    case ShadowFieldIndex.Reset_PersonalFactionStance:
                        Reset_PersonalFactionStance = true;
                        break;

                    case ShadowFieldIndex.Reset_AttachedTo:
                        Reset_AttachedTo = true;
                        break;

                    case ShadowFieldIndex.Reset_SinFactionsAcquiredBy:
                        Reset_SinFactionsAcquiredBy = true;
                        break;

                    case ShadowFieldIndex.Reset_SinTeamsAcquiredBy:
                        Reset_SinTeamsAcquiredBy = true;
                        break;

                    case ShadowFieldIndex.Reset_LookAtTarget:
                        Reset_LookAtTarget = true;
                        break;

                    case ShadowFieldIndex.Reset_CarryableObjects_0:
                        Reset_CarryableObjects_0 = true;
                        break;

                    case ShadowFieldIndex.Reset_CarryableObjects_1:
                        Reset_CarryableObjects_1 = true;
                        break;

                    case ShadowFieldIndex.Reset_CarryableObjects_2:
                        Reset_CarryableObjects_2 = true;
                        break;

                    case ShadowFieldIndex.Reset_RespawnTimes:
                        Reset_RespawnTimes = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_0:
                        Reset_SinCardFields_0 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_1:
                        Reset_SinCardFields_1 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_2:
                        Reset_SinCardFields_2 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_3:
                        Reset_SinCardFields_3 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_4:
                        Reset_SinCardFields_4 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_5:
                        Reset_SinCardFields_5 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_6:
                        Reset_SinCardFields_6 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_7:
                        Reset_SinCardFields_7 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_8:
                        Reset_SinCardFields_8 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_9:
                        Reset_SinCardFields_9 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_10:
                        Reset_SinCardFields_10 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_11:
                        Reset_SinCardFields_11 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_12:
                        Reset_SinCardFields_12 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_13:
                        Reset_SinCardFields_13 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_14:
                        Reset_SinCardFields_14 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_15:
                        Reset_SinCardFields_15 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_16:
                        Reset_SinCardFields_16 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_17:
                        Reset_SinCardFields_17 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_18:
                        Reset_SinCardFields_18 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_19:
                        Reset_SinCardFields_19 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_20:
                        Reset_SinCardFields_20 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_21:
                        Reset_SinCardFields_21 = true;
                        break;

                    case ShadowFieldIndex.Reset_SinCardFields_22:
                        Reset_SinCardFields_22 = true;
                        break;

                    default:
                        UnableToParseWarning = $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
        }
    }

    public static class MyExtensions
    {
        public static string StringZ(this Bitter.BinaryReader rdr, Bitter.BinaryStream stream) {
            string ret = "";
            do
            {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                ret += (char)b;
            }
            while (stream.baseStream.ByteOffset < stream.baseStream.Length);
            return ret;
        }
    }
}