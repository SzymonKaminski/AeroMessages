using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.Matrix.V25
{
    [AeroBlock]
    public struct DevZoneInfoData
    {
        // FUN_00755d40
        [AeroArray(typeof(byte))] DevPortsData DevPorts;

        // FUN_00756a50
        [AeroArray(typeof(byte))] DevPidsData DevPids;
    }   

    [AeroBlock]
    public struct DevPortsData
    {
        // FUN_00755d40
        [AeroString] public string Name;
        public ushort Port;
    }

    [AeroBlock]
    public struct DevPidsData
    {
        // FUN_00756a50
        [AeroString] public string Name;
        public uint Pid;
    }
}