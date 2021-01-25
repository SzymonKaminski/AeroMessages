using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 35, 1, true)]
    public class DeployableObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Type = 0x00,
            OwningEntity = 0x01,
            AbilitySrcId = 0x02,
            Position = 0x03,
            Orientation = 0x04,
            AimPosition = 0x05,
            AimDirection = 0x06,
            ConstructedTime = 0x07,
            CurrentHealthPct    = 0x08, // % integer
            MaxHealth = 0x09,
            Level = 0x0a,
            StatusEffects_0_ChangeTime = 0x0b,
            StatusEffects_1_ChangeTime = 0x0c,
            StatusEffects_2_ChangeTime = 0x0d,
            StatusEffects_3_ChangeTime = 0x0e,
            StatusEffects_4_ChangeTime = 0x0f,
            StatusEffects_5_ChangeTime = 0x10,
            StatusEffects_6_ChangeTime = 0x11,
            StatusEffects_7_ChangeTime = 0x12,
            StatusEffects_8_ChangeTime = 0x13,
            StatusEffects_9_ChangeTime = 0x14,
            StatusEffects_10_ChangeTime = 0x15,
            StatusEffects_11_ChangeTime = 0x16,
            StatusEffects_12_ChangeTime = 0x17,
            StatusEffects_13_ChangeTime = 0x18,
            StatusEffects_14_ChangeTime = 0x19,
            StatusEffects_15_ChangeTime = 0x1a,
            StatusEffects_16_ChangeTime = 0x1b,
            StatusEffects_17_ChangeTime = 0x1c,
            StatusEffects_18_ChangeTime = 0x1d,
            StatusEffects_19_ChangeTime = 0x1e,
            StatusEffects_20_ChangeTime = 0x1f,
            StatusEffects_21_ChangeTime = 0x20,
            StatusEffects_22_ChangeTime = 0x21,
            StatusEffects_23_ChangeTime = 0x22,
            StatusEffects_24_ChangeTime = 0x23,
            StatusEffects_25_ChangeTime = 0x24,
            StatusEffects_26_ChangeTime = 0x25,
            StatusEffects_27_ChangeTime = 0x26,
            StatusEffects_28_ChangeTime = 0x27,
            StatusEffects_29_ChangeTime = 0x28,
            StatusEffects_30_ChangeTime = 0x29,
            StatusEffects_31_ChangeTime = 0x2a,
            StatusEffects_0_Data = 0x2b,
            StatusEffects_1_Data = 0x2c,
            StatusEffects_2_Data = 0x2d,
            StatusEffects_3_Data = 0x2e,
            StatusEffects_4_Data = 0x2f,
            StatusEffects_5_Data = 0x30,
            StatusEffects_6_Data = 0x31,
            StatusEffects_7_Data = 0x32,
            StatusEffects_8_Data = 0x33,
            StatusEffects_9_Data = 0x34,
            StatusEffects_10_Data = 0x35,
            StatusEffects_11_Data = 0x36,
            StatusEffects_12_Data = 0x37,
            StatusEffects_13_Data = 0x38,
            StatusEffects_14_Data = 0x39,
            StatusEffects_15_Data = 0x3a,
            StatusEffects_16_Data = 0x3b,
            StatusEffects_17_Data = 0x3c,
            StatusEffects_18_Data = 0x3d,
            StatusEffects_19_Data = 0x3e,
            StatusEffects_20_Data = 0x3f,
            StatusEffects_21_Data = 0x40,
            StatusEffects_22_Data = 0x41,
            StatusEffects_23_Data = 0x42,
            StatusEffects_24_Data = 0x43,
            StatusEffects_25_Data = 0x44,
            StatusEffects_26_Data = 0x45,
            StatusEffects_27_Data = 0x46,
            StatusEffects_28_Data = 0x47,
            StatusEffects_29_Data = 0x48,
            StatusEffects_30_Data = 0x49,
            StatusEffects_31_Data = 0x4a,

            HostilityInfo = 0x4b,
            PersonalFactionStance = 0x4c,
            GibVisualsID = 0x04d,
            ForcedMovement = 0x4e,
            SinFlags = 0x4f,
            SinFactionsAcquiredBy = 0x50,
            SinTeamsAcquiredBy = 0x51,
            AttachedTo = 0x52,
            WarpaintColors = 0x53,
            VisualInfoGroupIndex = 0x54,
            CharacterStats = 0x55,
            SinCardType = 0x56,
            SinCardFields_0 =  0x57,
            SinCardFields_1 =  0x58,
            SinCardFields_2 =  0x59,
            SinCardFields_3 =  0x5a,
            SinCardFields_4 =  0x5b,
            SinCardFields_5 =  0x5c,
            SinCardFields_6 =  0x5d,
            SinCardFields_7 =  0x5e,
            SinCardFields_8 =  0x5f,
            SinCardFields_9 =  0x60,
            SinCardFields_10 =  0x61,
            SinCardFields_11 =  0x62,
            SinCardFields_12 =  0x63,
            SinCardFields_13 =  0x64,
            SinCardFields_14 =  0x65,
            SinCardFields_15 =  0x66,
            SinCardFields_16 =  0x67,
            SinCardFields_17 =  0x68,
            SinCardFields_18 =  0x69,
            SinCardFields_19 =  0x6a,
            ScalingLevel = 0x6b,
            AppendageHealthPools_0 = 0x6c,
            AppendageHealthPools_1 = 0x6d,
            AppendageHealthPools_2 = 0x6e,
            AppendageHealthPools_3 = 0x6f,
            AppendageHealthPools_4 = 0x70,
            AppendageHealthPools_5 = 0x71,
            AppendageHealthPools_6 = 0x72,
            AppendageHealthPools_7 = 0x73,
            AppendageHealthPct_0 = 0x74,
            AppendageHealthPct_1 = 0x75,
            AppendageHealthPct_2 = 0x76,
            AppendageHealthPct_3 = 0x77,
            AppendageHealthPct_4 = 0x78,
            AppendageHealthPct_5 = 0x79,
            AppendageHealthPct_6 = 0x7a,
            AppendageHealthPct_7 = 0x7b,


            StatusEffects_0_Cancel = 0xab,
            StatusEffects_1_Cancel = 0xac,
            StatusEffects_2_Cancel = 0xad,
            StatusEffects_3_Cancel = 0xae,
            StatusEffects_4_Cancel = 0xaf,
            StatusEffects_5_Cancel = 0xb0,
            StatusEffects_6_Cancel = 0xb1,
            StatusEffects_7_Cancel = 0xb2,
            StatusEffects_8_Cancel = 0xb3,
            StatusEffects_9_Cancel = 0xb4,
            StatusEffects_10_Cancel = 0xb5,
            StatusEffects_11_Cancel = 0xb6,
            StatusEffects_12_Cancel = 0xb7,
            StatusEffects_13_Cancel = 0xb8,
            StatusEffects_14_Cancel = 0xb9,
            StatusEffects_15_Cancel = 0xba,
            StatusEffects_16_Cancel = 0xbb,
            StatusEffects_17_Cancel = 0xbc,
            StatusEffects_18_Cancel = 0xbd,
            StatusEffects_19_Cancel = 0xbe,
            StatusEffects_20_Cancel = 0xbf,
            StatusEffects_21_Cancel = 0xc0,
            StatusEffects_22_Cancel = 0xc1,
            StatusEffects_23_Cancel = 0xc2,
            StatusEffects_24_Cancel = 0xc3,
            StatusEffects_25_Cancel = 0xc4,
            StatusEffects_26_Cancel = 0xc5,
            StatusEffects_27_Cancel = 0xc6,
            StatusEffects_28_Cancel = 0xc7,
            StatusEffects_29_Cancel = 0xc8,
            StatusEffects_30_Cancel = 0xc9,
            StatusEffects_31_Cancel = 0xca,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield


        public byte? CurrentHealthPct;

        public byte[] HostilityInfo;
        public byte[] SinFactionsAcquiredBy;
        public byte[] SinTeamsAcquiredBy;


        public ushort? StatusEffects_0_ChangeTime;
        public uint? StatusEffects_0_Id;
        public byte[] StatusEffects_0_Unk1;
        public byte[] StatusEffects_0_Entity;
        public uint? StatusEffects_0_Time1;
        public byte? StatusEffects_0_MoreDataFlag;
        public byte? StatusEffects_0_Data1_Count;
        public byte[] StatusEffects_0_Data1_Entity;
        public byte[] StatusEffects_0_UnkData;
        public float? StatusEffects_0_Data_Float1;
        public float? StatusEffects_0_Data_Float2;
        public bool? StatusEffects_0_Cancel;

        public ushort? StatusEffects_1_ChangeTime;
        public uint? StatusEffects_1_Id;
        public byte[] StatusEffects_1_Unk1;
        public byte[] StatusEffects_1_Entity;
        public uint? StatusEffects_1_Time1;
        public byte? StatusEffects_1_MoreDataFlag;
        public byte? StatusEffects_1_Data1_Count;
        public byte[] StatusEffects_1_Data1_Entity;
        public byte[] StatusEffects_1_UnkData;
        public float? StatusEffects_1_Data_Float1;
        public float? StatusEffects_1_Data_Float2;
        public bool? StatusEffects_1_Cancel;

        public ushort? StatusEffects_2_ChangeTime;
        public uint? StatusEffects_2_Id;
        public byte[] StatusEffects_2_Unk1;
        public byte[] StatusEffects_2_Entity;
        public uint? StatusEffects_2_Time1;
        public byte? StatusEffects_2_MoreDataFlag;
        public byte? StatusEffects_2_Data1_Count;
        public byte[] StatusEffects_2_Data1_Entity;
        public byte[] StatusEffects_2_UnkData;
        public float? StatusEffects_2_Data_Float1;
        public float? StatusEffects_2_Data_Float2;
        public bool? StatusEffects_2_Cancel;

        public ushort? StatusEffects_3_ChangeTime;
        public uint? StatusEffects_3_Id;
        public byte[] StatusEffects_3_Unk1;
        public byte[] StatusEffects_3_Entity;
        public uint? StatusEffects_3_Time1;
        public byte? StatusEffects_3_MoreDataFlag;
        public byte? StatusEffects_3_Data1_Count;
        public byte[] StatusEffects_3_Data1_Entity;
        public byte[] StatusEffects_3_UnkData;
        public float? StatusEffects_3_Data_Float1;
        public float? StatusEffects_3_Data_Float2;
        public bool? StatusEffects_3_Cancel;

        public ushort? StatusEffects_4_ChangeTime;
        public uint? StatusEffects_4_Id;
        public byte[] StatusEffects_4_Unk1;
        public byte[] StatusEffects_4_Entity;
        public uint? StatusEffects_4_Time1;
        public byte? StatusEffects_4_MoreDataFlag;
        public byte? StatusEffects_4_Data1_Count;
        public byte[] StatusEffects_4_Data1_Entity;
        public byte[] StatusEffects_4_UnkData;
        public float? StatusEffects_4_Data_Float1;
        public float? StatusEffects_4_Data_Float2;
        public bool? StatusEffects_4_Cancel;

        public ushort? StatusEffects_5_ChangeTime;
        public uint? StatusEffects_5_Id;
        public byte[] StatusEffects_5_Unk1;
        public byte[] StatusEffects_5_Entity;
        public uint? StatusEffects_5_Time1;
        public byte? StatusEffects_5_MoreDataFlag;
        public byte? StatusEffects_5_Data1_Count;
        public byte[] StatusEffects_5_Data1_Entity;
        public byte[] StatusEffects_5_UnkData;
        public float? StatusEffects_5_Data_Float1;
        public float? StatusEffects_5_Data_Float2;
        public bool? StatusEffects_5_Cancel;

        public ushort? StatusEffects_6_ChangeTime;
        public uint? StatusEffects_6_Id;
        public byte[] StatusEffects_6_Unk1;
        public byte[] StatusEffects_6_Entity;
        public uint? StatusEffects_6_Time1;
        public byte? StatusEffects_6_MoreDataFlag;
        public byte? StatusEffects_6_Data1_Count;
        public byte[] StatusEffects_6_Data1_Entity;
        public byte[] StatusEffects_6_UnkData;
        public float? StatusEffects_6_Data_Float1;
        public float? StatusEffects_6_Data_Float2;
        public bool? StatusEffects_6_Cancel;

        public ushort? StatusEffects_7_ChangeTime;
        public uint? StatusEffects_7_Id;
        public byte[] StatusEffects_7_Unk1;
        public byte[] StatusEffects_7_Entity;
        public uint? StatusEffects_7_Time1;
        public byte? StatusEffects_7_MoreDataFlag;
        public byte? StatusEffects_7_Data1_Count;
        public byte[] StatusEffects_7_Data1_Entity;
        public byte[] StatusEffects_7_UnkData;
        public float? StatusEffects_7_Data_Float1;
        public float? StatusEffects_7_Data_Float2;
        public bool? StatusEffects_7_Cancel;

        public ushort? StatusEffects_8_ChangeTime;
        public uint? StatusEffects_8_Id; 
        public byte[] StatusEffects_8_Unk1;
        public byte[] StatusEffects_8_Entity;
        public uint? StatusEffects_8_Time1;
        public byte? StatusEffects_8_MoreDataFlag;
        public byte? StatusEffects_8_Data1_Count;
        public byte[] StatusEffects_8_Data1_Entity;
        public byte[] StatusEffects_8_UnkData;
        public float? StatusEffects_8_Data_Float1;
        public float? StatusEffects_8_Data_Float2;
        public bool? StatusEffects_8_Cancel;

        public ushort? StatusEffects_9_ChangeTime;
        public uint? StatusEffects_9_Id;
        public byte[] StatusEffects_9_Unk1;
        public byte[] StatusEffects_9_Entity;
        public uint? StatusEffects_9_Time1;
        public byte? StatusEffects_9_MoreDataFlag;
        public byte? StatusEffects_9_Data1_Count;
        public byte[] StatusEffects_9_Data1_Entity;
        public byte[] StatusEffects_9_UnkData;
        public float? StatusEffects_9_Data_Float1;
        public float? StatusEffects_9_Data_Float2;
        public bool? StatusEffects_9_Cancel;

        public ushort? StatusEffects_10_ChangeTime;
        public uint? StatusEffects_10_Id;
        public byte[] StatusEffects_10_Unk1;
        public byte[] StatusEffects_10_Entity;
        public uint? StatusEffects_10_Time1;
        public byte? StatusEffects_10_MoreDataFlag;
        public byte? StatusEffects_10_Data1_Count;
        public byte[] StatusEffects_10_Data1_Entity;
        public byte[] StatusEffects_10_UnkData;
        public float? StatusEffects_10_Data_Float1;
        public float? StatusEffects_10_Data_Float2;
        public bool? StatusEffects_10_Cancel;

        public ushort? StatusEffects_11_ChangeTime;
        public uint? StatusEffects_11_Id;
        public byte[] StatusEffects_11_Unk1;
        public byte[] StatusEffects_11_Entity;
        public uint? StatusEffects_11_Time1;
        public byte? StatusEffects_11_MoreDataFlag;
        public byte? StatusEffects_11_Data1_Count;
        public byte[] StatusEffects_11_Data1_Entity;
        public byte[] StatusEffects_11_UnkData;
        public float? StatusEffects_11_Data_Float1;
        public float? StatusEffects_11_Data_Float2;
        public bool? StatusEffects_11_Cancel;

        public ushort? StatusEffects_12_ChangeTime;
        public uint? StatusEffects_12_Id;
        public byte[] StatusEffects_12_Unk1;
        public byte[] StatusEffects_12_Entity;
        public uint? StatusEffects_12_Time1;
        public byte? StatusEffects_12_MoreDataFlag;
        public byte? StatusEffects_12_Data1_Count;
        public byte[] StatusEffects_12_Data1_Entity;
        public byte[] StatusEffects_12_UnkData;
        public float? StatusEffects_12_Data_Float1;
        public float? StatusEffects_12_Data_Float2;
        public bool? StatusEffects_12_Cancel;

        public ushort? StatusEffects_13_ChangeTime;
        public uint? StatusEffects_13_Id;
        public byte[] StatusEffects_13_Unk1;
        public byte[] StatusEffects_13_Entity;
        public uint? StatusEffects_13_Time1;
        public byte? StatusEffects_13_MoreDataFlag;
        public byte? StatusEffects_13_Data1_Count;
        public byte[] StatusEffects_13_Data1_Entity;
        public byte[] StatusEffects_13_UnkData;
        public float? StatusEffects_13_Data_Float1;
        public float? StatusEffects_13_Data_Float2;
        public bool? StatusEffects_13_Cancel;

        public ushort? StatusEffects_14_ChangeTime;
        public uint? StatusEffects_14_Id;
        public byte[] StatusEffects_14_Unk1;
        public byte[] StatusEffects_14_Entity;
        public uint? StatusEffects_14_Time1;
        public byte? StatusEffects_14_MoreDataFlag;
        public byte? StatusEffects_14_Data1_Count;
        public byte[] StatusEffects_14_Data1_Entity;
        public byte[] StatusEffects_14_UnkData;
        public float? StatusEffects_14_Data_Float1;
        public float? StatusEffects_14_Data_Float2;
        public bool? StatusEffects_14_Cancel;

        public ushort? StatusEffects_15_ChangeTime;
        public uint? StatusEffects_15_Id;
        public byte[] StatusEffects_15_Unk1;
        public byte[] StatusEffects_15_Entity;
        public uint? StatusEffects_15_Time1;
        public byte? StatusEffects_15_MoreDataFlag;
        public byte? StatusEffects_15_Data1_Count;
        public byte[] StatusEffects_15_Data1_Entity;
        public byte[] StatusEffects_15_UnkData;
        public float? StatusEffects_15_Data_Float1;
        public float? StatusEffects_15_Data_Float2;
        public bool? StatusEffects_15_Cancel;

        public ushort? StatusEffects_16_ChangeTime;
        public uint? StatusEffects_16_Id;
        public byte[] StatusEffects_16_Unk1;
        public byte[] StatusEffects_16_Entity;
        public uint? StatusEffects_16_Time1;
        public byte? StatusEffects_16_MoreDataFlag;
        public byte? StatusEffects_16_Data1_Count;
        public byte[] StatusEffects_16_Data1_Entity;
        public byte[] StatusEffects_16_UnkData;
        public float? StatusEffects_16_Data_Float1;
        public float? StatusEffects_16_Data_Float2;
        public bool? StatusEffects_16_Cancel;

        public ushort? StatusEffects_17_ChangeTime;
        public uint? StatusEffects_17_Id;
        public byte[] StatusEffects_17_Unk1;
        public byte[] StatusEffects_17_Entity;
        public uint? StatusEffects_17_Time1;
        public byte? StatusEffects_17_MoreDataFlag;
        public byte? StatusEffects_17_Data1_Count;
        public byte[] StatusEffects_17_Data1_Entity;
        public byte[] StatusEffects_17_UnkData;
        public float? StatusEffects_17_Data_Float1;
        public float? StatusEffects_17_Data_Float2;
        public bool? StatusEffects_17_Cancel;

        public ushort? StatusEffects_18_ChangeTime;
        public uint? StatusEffects_18_Id;
        public byte[] StatusEffects_18_Unk1;
        public byte[] StatusEffects_18_Entity;
        public uint? StatusEffects_18_Time1;
        public byte? StatusEffects_18_MoreDataFlag;
        public byte? StatusEffects_18_Data1_Count;
        public byte[] StatusEffects_18_Data1_Entity;
        public byte[] StatusEffects_18_UnkData;
        public float? StatusEffects_18_Data_Float1;
        public float? StatusEffects_18_Data_Float2;
        public bool? StatusEffects_18_Cancel;

        public ushort? StatusEffects_19_ChangeTime;
        public uint? StatusEffects_19_Id;
        public byte[] StatusEffects_19_Unk1;
        public byte[] StatusEffects_19_Entity;
        public uint? StatusEffects_19_Time1;
        public byte? StatusEffects_19_MoreDataFlag;
        public byte? StatusEffects_19_Data1_Count;
        public byte[] StatusEffects_19_Data1_Entity;
        public byte[] StatusEffects_19_UnkData;
        public float? StatusEffects_19_Data_Float1;
        public float? StatusEffects_19_Data_Float2;
        public bool? StatusEffects_19_Cancel;

        public ushort? StatusEffects_20_ChangeTime;
        public uint? StatusEffects_20_Id;
        public byte[] StatusEffects_20_Unk1;
        public byte[] StatusEffects_20_Entity;
        public uint? StatusEffects_20_Time1;
        public byte? StatusEffects_20_MoreDataFlag;
        public byte? StatusEffects_20_Data1_Count;
        public byte[] StatusEffects_20_Data1_Entity;
        public byte[] StatusEffects_20_UnkData;
        public float? StatusEffects_20_Data_Float1;
        public float? StatusEffects_20_Data_Float2;
        public bool? StatusEffects_20_Cancel;

        public ushort? StatusEffects_21_ChangeTime;
        public uint? StatusEffects_21_Id;
        public byte[] StatusEffects_21_Unk1;
        public byte[] StatusEffects_21_Entity;
        public uint? StatusEffects_21_Time1;
        public byte? StatusEffects_21_MoreDataFlag;
        public byte? StatusEffects_21_Data1_Count;
        public byte[] StatusEffects_21_Data1_Entity;
        public byte[] StatusEffects_21_UnkData;
        public float? StatusEffects_21_Data_Float1;
        public float? StatusEffects_21_Data_Float2;
        public bool? StatusEffects_21_Cancel;

        public ushort? StatusEffects_22_ChangeTime;
        public uint? StatusEffects_22_Id;
        public byte[] StatusEffects_22_Unk1;
        public byte[] StatusEffects_22_Entity;
        public uint? StatusEffects_22_Time1;
        public byte? StatusEffects_22_MoreDataFlag;
        public byte? StatusEffects_22_Data1_Count;
        public byte[] StatusEffects_22_Data1_Entity;
        public byte[] StatusEffects_22_UnkData;
        public float? StatusEffects_22_Data_Float1;
        public float? StatusEffects_22_Data_Float2;
        public bool? StatusEffects_22_Cancel;

        public ushort? StatusEffects_23_ChangeTime;
        public uint? StatusEffects_23_Id;
        public byte[] StatusEffects_23_Unk1;
        public byte[] StatusEffects_23_Entity;
        public uint? StatusEffects_23_Time1;
        public byte? StatusEffects_23_MoreDataFlag;
        public byte? StatusEffects_23_Data1_Count;
        public byte[] StatusEffects_23_Data1_Entity;
        public byte[] StatusEffects_23_UnkData;
        public float? StatusEffects_23_Data_Float1;
        public float? StatusEffects_23_Data_Float2;
        public bool? StatusEffects_23_Cancel;

        public ushort? StatusEffects_24_ChangeTime;
        public uint? StatusEffects_24_Id; 
        public byte[] StatusEffects_24_Unk1;
        public byte[] StatusEffects_24_Entity;
        public uint? StatusEffects_24_Time1;
        public byte? StatusEffects_24_MoreDataFlag;
        public byte? StatusEffects_24_Data1_Count;
        public byte[] StatusEffects_24_Data1_Entity;
        public byte[] StatusEffects_24_UnkData;
        public float? StatusEffects_24_Data_Float1;
        public float? StatusEffects_24_Data_Float2;
        public bool? StatusEffects_24_Cancel;

        public ushort? StatusEffects_25_ChangeTime;
        public uint? StatusEffects_25_Id;
        public byte[] StatusEffects_25_Unk1;
        public byte[] StatusEffects_25_Entity;
        public uint? StatusEffects_25_Time1;
        public byte? StatusEffects_25_MoreDataFlag;
        public byte? StatusEffects_25_Data1_Count;
        public byte[] StatusEffects_25_Data1_Entity;
        public byte[] StatusEffects_25_UnkData;
        public float? StatusEffects_25_Data_Float1;
        public float? StatusEffects_25_Data_Float2;
        public bool? StatusEffects_25_Cancel;

        public ushort? StatusEffects_26_ChangeTime;
        public uint? StatusEffects_26_Id;
        public byte[] StatusEffects_26_Unk1;
        public byte[] StatusEffects_26_Entity;
        public uint? StatusEffects_26_Time1;
        public byte? StatusEffects_26_MoreDataFlag;
        public byte? StatusEffects_26_Data1_Count;
        public byte[] StatusEffects_26_Data1_Entity;
        public byte[] StatusEffects_26_UnkData;
        public float? StatusEffects_26_Data_Float1;
        public float? StatusEffects_26_Data_Float2;
        public bool? StatusEffects_26_Cancel;

        public ushort? StatusEffects_27_ChangeTime;
        public uint? StatusEffects_27_Id;
        public byte[] StatusEffects_27_Unk1;
        public byte[] StatusEffects_27_Entity;
        public uint? StatusEffects_27_Time1;
        public byte? StatusEffects_27_MoreDataFlag;
        public byte? StatusEffects_27_Data1_Count;
        public byte[] StatusEffects_27_Data1_Entity;
        public byte[] StatusEffects_27_UnkData;
        public float? StatusEffects_27_Data_Float1;
        public float? StatusEffects_27_Data_Float2;
        public bool? StatusEffects_27_Cancel;

        public ushort? StatusEffects_28_ChangeTime;
        public uint? StatusEffects_28_Id;
        public byte[] StatusEffects_28_Unk1;
        public byte[] StatusEffects_28_Entity;
        public uint? StatusEffects_28_Time1;
        public byte? StatusEffects_28_MoreDataFlag;
        public byte? StatusEffects_28_Data1_Count;
        public byte[] StatusEffects_28_Data1_Entity;
        public byte[] StatusEffects_28_UnkData;
        public float? StatusEffects_28_Data_Float1;
        public float? StatusEffects_28_Data_Float2;
        public bool? StatusEffects_28_Cancel;

        public ushort? StatusEffects_29_ChangeTime;
        public uint? StatusEffects_29_Id;
        public byte[] StatusEffects_29_Unk1;
        public byte[] StatusEffects_29_Entity;
        public uint? StatusEffects_29_Time1;
        public byte? StatusEffects_29_MoreDataFlag;
        public byte? StatusEffects_29_Data1_Count;
        public byte[] StatusEffects_29_Data1_Entity;
        public byte[] StatusEffects_29_UnkData;
        public float? StatusEffects_29_Data_Float1;
        public float? StatusEffects_29_Data_Float2;
        public bool? StatusEffects_29_Cancel;

        public ushort? StatusEffects_30_ChangeTime;
        public uint? StatusEffects_30_Id;
        public byte[] StatusEffects_30_Unk1;
        public byte[] StatusEffects_30_Entity;
        public uint? StatusEffects_30_Time1;
        public byte? StatusEffects_30_MoreDataFlag;
        public byte? StatusEffects_30_Data1_Count;
        public byte[] StatusEffects_30_Data1_Entity;
        public byte[] StatusEffects_30_UnkData;
        public float? StatusEffects_30_Data_Float1;
        public float? StatusEffects_30_Data_Float2;
        public bool? StatusEffects_30_Cancel;

        public ushort? StatusEffects_31_ChangeTime;
        public uint? StatusEffects_31_Id;
        public byte[] StatusEffects_31_Unk1;
        public byte[] StatusEffects_31_Entity;
        public uint? StatusEffects_31_Time1;
        public byte? StatusEffects_31_MoreDataFlag;
        public byte? StatusEffects_31_Data1_Count;
        public byte[] StatusEffects_31_Data1_Entity;
        public byte[] StatusEffects_31_UnkData;
        public float? StatusEffects_31_Data_Float1;
        public float? StatusEffects_31_Data_Float2;
        public bool? StatusEffects_31_Cancel;

        public byte[] UnableToParse;



        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
 
                    
                    case ShadowFieldIndex.CurrentHealthPct:
                        CurrentHealthPct = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.HostilityInfo:
                        HostilityInfo = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.SinFactionsAcquiredBy:
                        SinFactionsAcquiredBy = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.SinTeamsAcquiredBy:
                        SinTeamsAcquiredBy = Stream.Read.ByteArray(2);
                        break;


                    case ShadowFieldIndex.StatusEffects_0_ChangeTime:
                        StatusEffects_0_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_1_ChangeTime:
                        StatusEffects_1_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_2_ChangeTime:
                        StatusEffects_2_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_3_ChangeTime:
                        StatusEffects_3_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_4_ChangeTime:
                        StatusEffects_4_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_5_ChangeTime:
                        StatusEffects_5_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_6_ChangeTime:
                        StatusEffects_6_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_7_ChangeTime:
                        StatusEffects_7_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_8_ChangeTime:
                        StatusEffects_8_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_9_ChangeTime:
                        StatusEffects_9_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_10_ChangeTime:
                        StatusEffects_10_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_11_ChangeTime:
                        StatusEffects_11_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_12_ChangeTime:
                        StatusEffects_12_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_13_ChangeTime:
                        StatusEffects_13_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_14_ChangeTime:
                        StatusEffects_14_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_15_ChangeTime:
                        StatusEffects_15_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_16_ChangeTime:
                        StatusEffects_16_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_17_ChangeTime:
                        StatusEffects_17_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_18_ChangeTime:
                        StatusEffects_18_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_19_ChangeTime:
                        StatusEffects_19_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_20_ChangeTime:
                        StatusEffects_20_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_21_ChangeTime:
                        StatusEffects_21_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_22_ChangeTime:
                        StatusEffects_22_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_23_ChangeTime:
                        StatusEffects_23_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_24_ChangeTime:
                        StatusEffects_24_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_25_ChangeTime:
                        StatusEffects_25_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_26_ChangeTime:
                        StatusEffects_26_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_27_ChangeTime:
                        StatusEffects_27_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_28_ChangeTime:
                        StatusEffects_28_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_29_ChangeTime:
                        StatusEffects_29_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_30_ChangeTime:
                        StatusEffects_30_ChangeTime = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.StatusEffects_31_ChangeTime:
                        StatusEffects_31_ChangeTime = Stream.Read.UShort();
                        break;


                    case ShadowFieldIndex.StatusEffects_0_Data:
                        StatusEffects_0_Id     = Stream.Read.UInt();
                        StatusEffects_0_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_0_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_0_Time1  = Stream.Read.UInt();
                        StatusEffects_0_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_0_MoreDataFlag == 0x01)
                        {
                            StatusEffects_0_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_0_Data1_Count > 0) {
                                StatusEffects_0_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_0_Data1_Count);
                            }
                            StatusEffects_0_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_0_Data_Float1 = Stream.Read.Float();
                            StatusEffects_0_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_1_Data:
                        StatusEffects_1_Id     = Stream.Read.UInt();
                        StatusEffects_1_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_1_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_1_Time1  = Stream.Read.UInt();
                        StatusEffects_1_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_1_MoreDataFlag == 0x01)
                        {
                            StatusEffects_1_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_1_Data1_Count > 0) {
                                StatusEffects_1_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_1_Data1_Count);
                            }
                            StatusEffects_1_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_1_Data_Float1 = Stream.Read.Float();
                            StatusEffects_1_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_2_Data:
                        StatusEffects_2_Id     = Stream.Read.UInt();
                        StatusEffects_2_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_2_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_2_Time1  = Stream.Read.UInt();
                        StatusEffects_2_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_2_MoreDataFlag == 0x01)
                        {
                            StatusEffects_2_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_2_Data1_Count > 0) {
                                StatusEffects_2_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_2_Data1_Count);
                            }
                            StatusEffects_2_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_2_Data_Float1 = Stream.Read.Float();
                            StatusEffects_2_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_3_Data:
                        StatusEffects_3_Id     = Stream.Read.UInt();
                        StatusEffects_3_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_3_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_3_Time1  = Stream.Read.UInt();
                        StatusEffects_3_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_3_MoreDataFlag == 0x01)
                        {
                            StatusEffects_3_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_3_Data1_Count > 0) {
                                StatusEffects_3_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_3_Data1_Count);
                            }
                            StatusEffects_3_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_3_Data_Float1 = Stream.Read.Float();
                            StatusEffects_3_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_4_Data:
                        StatusEffects_4_Id     = Stream.Read.UInt();
                        StatusEffects_4_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_4_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_4_Time1  = Stream.Read.UInt();
                        StatusEffects_4_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_4_MoreDataFlag == 0x01)
                        {
                            StatusEffects_4_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_4_Data1_Count > 0) {
                                StatusEffects_4_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_4_Data1_Count);
                            }
                            StatusEffects_4_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_4_Data_Float1 = Stream.Read.Float();
                            StatusEffects_4_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_5_Data:
                        StatusEffects_5_Id     = Stream.Read.UInt();
                        StatusEffects_5_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_5_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_5_Time1  = Stream.Read.UInt();
                        StatusEffects_5_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_5_MoreDataFlag == 0x01)
                        {
                            StatusEffects_5_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_5_Data1_Count > 0) {
                                StatusEffects_5_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_5_Data1_Count);
                            }
                            StatusEffects_5_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_5_Data_Float1 = Stream.Read.Float();
                            StatusEffects_5_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_6_Data:
                        StatusEffects_6_Id     = Stream.Read.UInt();
                        StatusEffects_6_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_6_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_6_Time1  = Stream.Read.UInt();
                        StatusEffects_6_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_6_MoreDataFlag == 0x01)
                        {
                            StatusEffects_6_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_6_Data1_Count > 0) {
                                StatusEffects_6_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_6_Data1_Count);
                            }
                            StatusEffects_6_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_6_Data_Float1 = Stream.Read.Float();
                            StatusEffects_6_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_7_Data:
                        StatusEffects_7_Id     = Stream.Read.UInt();
                        StatusEffects_7_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_7_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_7_Time1  = Stream.Read.UInt();
                        StatusEffects_7_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_7_MoreDataFlag == 0x01)
                        {
                            StatusEffects_7_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_7_Data1_Count > 0) {
                                StatusEffects_7_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_7_Data1_Count);
                            }
                            StatusEffects_7_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_7_Data_Float1 = Stream.Read.Float();
                            StatusEffects_7_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_8_Data:
                        StatusEffects_8_Id     = Stream.Read.UInt();
                        StatusEffects_8_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_8_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_8_Time1  = Stream.Read.UInt();
                        StatusEffects_8_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_8_MoreDataFlag == 0x01)
                        {
                            StatusEffects_8_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_8_Data1_Count > 0) {
                                StatusEffects_8_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_8_Data1_Count);
                            }
                            StatusEffects_8_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_8_Data_Float1 = Stream.Read.Float();
                            StatusEffects_8_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_9_Data:
                        StatusEffects_9_Id     = Stream.Read.UInt();
                        StatusEffects_9_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_9_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_9_Time1  = Stream.Read.UInt();
                        StatusEffects_9_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_9_MoreDataFlag == 0x01)
                        {
                            StatusEffects_9_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_9_Data1_Count > 0) {
                                StatusEffects_9_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_9_Data1_Count);
                            }
                            StatusEffects_9_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_9_Data_Float1 = Stream.Read.Float();
                            StatusEffects_9_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_10_Data:
                        StatusEffects_10_Id     = Stream.Read.UInt();
                        StatusEffects_10_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_10_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_10_Time1  = Stream.Read.UInt();
                        StatusEffects_10_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_10_MoreDataFlag == 0x01)
                        {
                            StatusEffects_10_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_10_Data1_Count > 0) {
                                StatusEffects_10_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_10_Data1_Count);
                            }
                            StatusEffects_10_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_10_Data_Float1 = Stream.Read.Float();
                            StatusEffects_10_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_11_Data:
                        StatusEffects_11_Id     = Stream.Read.UInt();
                        StatusEffects_11_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_11_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_11_Time1  = Stream.Read.UInt();
                        StatusEffects_11_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_11_MoreDataFlag == 0x01)
                        {
                            StatusEffects_11_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_11_Data1_Count > 0) {
                                StatusEffects_11_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_11_Data1_Count);
                            }
                            StatusEffects_11_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_11_Data_Float1 = Stream.Read.Float();
                            StatusEffects_11_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_12_Data:
                        StatusEffects_12_Id     = Stream.Read.UInt();
                        StatusEffects_12_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_12_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_12_Time1  = Stream.Read.UInt();
                        StatusEffects_12_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_12_MoreDataFlag == 0x01)
                        {
                            StatusEffects_12_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_12_Data1_Count > 0) {
                                StatusEffects_12_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_12_Data1_Count);
                            }
                            StatusEffects_12_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_12_Data_Float1 = Stream.Read.Float();
                            StatusEffects_12_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_13_Data:
                        StatusEffects_13_Id     = Stream.Read.UInt();
                        StatusEffects_13_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_13_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_13_Time1  = Stream.Read.UInt();
                        StatusEffects_13_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_13_MoreDataFlag == 0x01)
                        {
                            StatusEffects_13_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_13_Data1_Count > 0) {
                                StatusEffects_13_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_13_Data1_Count);
                            }
                            StatusEffects_13_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_13_Data_Float1 = Stream.Read.Float();
                            StatusEffects_13_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_14_Data:
                        StatusEffects_14_Id     = Stream.Read.UInt();
                        StatusEffects_14_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_14_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_14_Time1  = Stream.Read.UInt();
                        StatusEffects_14_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_14_MoreDataFlag == 0x01)
                        {
                            StatusEffects_14_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_14_Data1_Count > 0) {
                                StatusEffects_14_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_14_Data1_Count);
                            }
                            StatusEffects_14_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_14_Data_Float1 = Stream.Read.Float();
                            StatusEffects_14_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_15_Data:
                        StatusEffects_15_Id     = Stream.Read.UInt();
                        StatusEffects_15_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_15_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_15_Time1  = Stream.Read.UInt();
                        StatusEffects_15_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_15_MoreDataFlag == 0x01)
                        {
                            StatusEffects_15_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_15_Data1_Count > 0) {
                                StatusEffects_15_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_15_Data1_Count);
                            }
                            StatusEffects_15_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_15_Data_Float1 = Stream.Read.Float();
                            StatusEffects_15_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_16_Data:
                        StatusEffects_16_Id     = Stream.Read.UInt();
                        StatusEffects_16_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_16_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_16_Time1  = Stream.Read.UInt();
                        StatusEffects_16_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_16_MoreDataFlag == 0x01)
                        {
                            StatusEffects_16_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_16_Data1_Count > 0) {
                                StatusEffects_16_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_16_Data1_Count);
                            }
                            StatusEffects_16_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_16_Data_Float1 = Stream.Read.Float();
                            StatusEffects_16_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_17_Data:
                        StatusEffects_17_Id     = Stream.Read.UInt();
                        StatusEffects_17_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_17_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_17_Time1  = Stream.Read.UInt();
                        StatusEffects_17_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_17_MoreDataFlag == 0x01)
                        {
                            StatusEffects_17_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_17_Data1_Count > 0) {
                                StatusEffects_17_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_17_Data1_Count);
                            }
                            StatusEffects_17_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_17_Data_Float1 = Stream.Read.Float();
                            StatusEffects_17_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_18_Data:
                        StatusEffects_18_Id     = Stream.Read.UInt();
                        StatusEffects_18_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_18_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_18_Time1  = Stream.Read.UInt();
                        StatusEffects_18_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_18_MoreDataFlag == 0x01)
                        {
                            StatusEffects_18_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_18_Data1_Count > 0) {
                                StatusEffects_18_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_18_Data1_Count);
                            }
                            StatusEffects_18_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_18_Data_Float1 = Stream.Read.Float();
                            StatusEffects_18_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_19_Data:
                        StatusEffects_19_Id     = Stream.Read.UInt();
                        StatusEffects_19_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_19_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_19_Time1  = Stream.Read.UInt();
                        StatusEffects_19_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_19_MoreDataFlag == 0x01)
                        {
                            StatusEffects_19_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_19_Data1_Count > 0) {
                                StatusEffects_19_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_19_Data1_Count);
                            }
                            StatusEffects_19_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_19_Data_Float1 = Stream.Read.Float();
                            StatusEffects_19_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_20_Data:
                        StatusEffects_20_Id     = Stream.Read.UInt();
                        StatusEffects_20_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_20_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_20_Time1  = Stream.Read.UInt();
                        StatusEffects_20_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_20_MoreDataFlag == 0x01)
                        {
                            StatusEffects_20_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_20_Data1_Count > 0) {
                                StatusEffects_20_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_20_Data1_Count);
                            }
                            StatusEffects_20_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_20_Data_Float1 = Stream.Read.Float();
                            StatusEffects_20_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_21_Data:
                        StatusEffects_21_Id     = Stream.Read.UInt();
                        StatusEffects_21_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_21_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_21_Time1  = Stream.Read.UInt();
                        StatusEffects_21_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_21_MoreDataFlag == 0x01)
                        {
                            StatusEffects_21_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_21_Data1_Count > 0) {
                                StatusEffects_21_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_21_Data1_Count);
                            }
                            StatusEffects_21_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_21_Data_Float1 = Stream.Read.Float();
                            StatusEffects_21_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_22_Data:
                        StatusEffects_22_Id     = Stream.Read.UInt();
                        StatusEffects_22_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_22_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_22_Time1  = Stream.Read.UInt();
                        StatusEffects_22_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_22_MoreDataFlag == 0x01)
                        {
                            StatusEffects_22_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_22_Data1_Count > 0) {
                                StatusEffects_22_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_22_Data1_Count);
                            }
                            StatusEffects_22_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_22_Data_Float1 = Stream.Read.Float();
                            StatusEffects_22_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_23_Data:
                        StatusEffects_23_Id     = Stream.Read.UInt();
                        StatusEffects_23_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_23_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_23_Time1  = Stream.Read.UInt();
                        StatusEffects_23_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_23_MoreDataFlag == 0x01)
                        {
                            StatusEffects_23_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_23_Data1_Count > 0) {
                                StatusEffects_23_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_23_Data1_Count);
                            }
                            StatusEffects_23_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_23_Data_Float1 = Stream.Read.Float();
                            StatusEffects_23_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_24_Data:
                        StatusEffects_24_Id     = Stream.Read.UInt();
                        StatusEffects_24_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_24_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_24_Time1  = Stream.Read.UInt();
                        StatusEffects_24_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_24_MoreDataFlag == 0x01)
                        {
                            StatusEffects_24_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_24_Data1_Count > 0) {
                                StatusEffects_24_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_24_Data1_Count);
                            }
                            StatusEffects_24_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_24_Data_Float1 = Stream.Read.Float();
                            StatusEffects_24_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_25_Data:
                        StatusEffects_25_Id     = Stream.Read.UInt();
                        StatusEffects_25_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_25_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_25_Time1  = Stream.Read.UInt();
                        StatusEffects_25_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_25_MoreDataFlag == 0x01)
                        {
                            StatusEffects_25_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_25_Data1_Count > 0) {
                                StatusEffects_25_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_25_Data1_Count);
                            }
                            StatusEffects_25_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_25_Data_Float1 = Stream.Read.Float();
                            StatusEffects_25_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_26_Data:
                        StatusEffects_26_Id     = Stream.Read.UInt();
                        StatusEffects_26_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_26_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_26_Time1  = Stream.Read.UInt();
                        StatusEffects_26_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_26_MoreDataFlag == 0x01)
                        {
                            StatusEffects_26_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_26_Data1_Count > 0) {
                                StatusEffects_26_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_26_Data1_Count);
                            }
                            StatusEffects_26_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_26_Data_Float1 = Stream.Read.Float();
                            StatusEffects_26_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_27_Data:
                        StatusEffects_27_Id     = Stream.Read.UInt();
                        StatusEffects_27_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_27_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_27_Time1  = Stream.Read.UInt();
                        StatusEffects_27_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_27_MoreDataFlag == 0x01)
                        {
                            StatusEffects_27_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_27_Data1_Count > 0) {
                                StatusEffects_27_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_27_Data1_Count);
                            }
                            StatusEffects_27_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_27_Data_Float1 = Stream.Read.Float();
                            StatusEffects_27_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_28_Data:
                        StatusEffects_28_Id     = Stream.Read.UInt();
                        StatusEffects_28_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_28_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_28_Time1  = Stream.Read.UInt();
                        StatusEffects_28_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_28_MoreDataFlag == 0x01)
                        {
                            StatusEffects_28_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_28_Data1_Count > 0) {
                                StatusEffects_28_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_28_Data1_Count);
                            }
                            StatusEffects_28_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_28_Data_Float1 = Stream.Read.Float();
                            StatusEffects_28_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_29_Data:
                        StatusEffects_29_Id     = Stream.Read.UInt();
                        StatusEffects_29_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_29_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_29_Time1  = Stream.Read.UInt();
                        StatusEffects_29_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_29_MoreDataFlag == 0x01)
                        {
                            StatusEffects_29_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_29_Data1_Count > 0) {
                                StatusEffects_29_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_29_Data1_Count);
                            }
                            StatusEffects_29_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_29_Data_Float1 = Stream.Read.Float();
                            StatusEffects_29_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_30_Data:
                        StatusEffects_30_Id     = Stream.Read.UInt();
                        StatusEffects_30_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_30_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_30_Time1  = Stream.Read.UInt();
                        StatusEffects_30_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_30_MoreDataFlag == 0x01)
                        {
                            StatusEffects_30_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_30_Data1_Count > 0) {
                                StatusEffects_30_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_30_Data1_Count);
                            }
                            StatusEffects_30_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_30_Data_Float1 = Stream.Read.Float();
                            StatusEffects_30_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    case ShadowFieldIndex.StatusEffects_31_Data:
                        StatusEffects_31_Id     = Stream.Read.UInt();
                        StatusEffects_31_Unk1   = Stream.Read.ByteArray(1);
                        StatusEffects_31_Entity = Stream.Read.ByteArray(8);
                        StatusEffects_31_Time1  = Stream.Read.UInt();
                        StatusEffects_31_MoreDataFlag = Stream.Read.Byte();
                        if (StatusEffects_31_MoreDataFlag == 0x01)
                        {
                            StatusEffects_31_Data1_Count = Stream.Read.Byte();
                            if (StatusEffects_31_Data1_Count > 0) {
                                StatusEffects_31_Data1_Entity = Stream.Read.ByteArray(8*(int)StatusEffects_31_Data1_Count);
                            }
                            StatusEffects_31_UnkData   = Stream.Read.ByteArray(29);
                            StatusEffects_31_Data_Float1 = Stream.Read.Float();
                            StatusEffects_31_Data_Float2 = Stream.Read.Float();
                        }
                        break;

                    // These keys do not come with any data
                    case ShadowFieldIndex.StatusEffects_0_Cancel:
                        StatusEffects_0_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_1_Cancel:
                        StatusEffects_1_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_2_Cancel:
                        StatusEffects_2_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_3_Cancel:
                        StatusEffects_3_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_4_Cancel:
                        StatusEffects_4_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_5_Cancel:
                        StatusEffects_5_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_6_Cancel:
                        StatusEffects_6_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_7_Cancel:
                        StatusEffects_7_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_8_Cancel:
                        StatusEffects_8_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_9_Cancel:
                        StatusEffects_9_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_10_Cancel:
                        StatusEffects_10_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_11_Cancel:
                        StatusEffects_11_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_12_Cancel:
                        StatusEffects_12_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_13_Cancel:
                        StatusEffects_13_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_14_Cancel:
                        StatusEffects_14_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_15_Cancel:
                        StatusEffects_15_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_16_Cancel:
                        StatusEffects_16_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_17_Cancel:
                        StatusEffects_17_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_18_Cancel:
                        StatusEffects_18_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_19_Cancel:
                        StatusEffects_19_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_20_Cancel:
                        StatusEffects_20_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_21_Cancel:
                        StatusEffects_21_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_22_Cancel:
                        StatusEffects_22_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_23_Cancel:
                        StatusEffects_23_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_24_Cancel:
                        StatusEffects_24_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_25_Cancel:
                        StatusEffects_25_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_26_Cancel:
                        StatusEffects_26_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_27_Cancel:
                        StatusEffects_27_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_28_Cancel:
                        StatusEffects_28_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_29_Cancel:
                        StatusEffects_29_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_30_Cancel:
                        StatusEffects_30_Cancel = true;
                        break;
                    case ShadowFieldIndex.StatusEffects_31_Cancel:
                        StatusEffects_31_Cancel = true;
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
}