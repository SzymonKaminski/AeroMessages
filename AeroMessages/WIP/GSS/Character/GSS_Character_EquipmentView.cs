using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero(true)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 9, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 9, 3)]
    public partial class Character_EquipmentView
    {
        private VisualOverridesField VisualOverrides;
        private EquipmentData CurrentEquipment;
        private byte Level;
        private byte EffectiveLevel;
        private byte LevelResetCount;
        private byte CurrentDurabilityPct;
        private CharacterStatsData CharacterStats;
        private uint ScalingLevel;
        private uint PvPRank;
        private uint EliteLevel;
    }

    [AeroBlock]
    public struct VisualOverridesField
    {
        public byte HaveData;
        [AeroIf(nameof(HaveData), 1)]
        public VisualOverridesData Data;
    }

    [AeroBlock]
    public struct VisualOverridesData
    {
        public byte UnkByte;
        public uint VisualsGroupId;
    }
}