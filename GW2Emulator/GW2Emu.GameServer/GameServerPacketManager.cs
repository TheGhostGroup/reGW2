using System;
using GW2Emu.Common;
using GW2Emu.GameServer.In;

namespace GW2Emu.GameServer
{
    public class GameServerPacketManager : PacketManager
    {
        public event PacketEventHandler<P001_Unknown> P001_Unknown;
        public event PacketEventHandler<P002_Unknown> P002_Unknown;
        public event PacketEventHandler<P003_Unknown> P003_Unknown;
        public event PacketEventHandler<P004_Unknown> P004_Unknown;
        public event PacketEventHandler<P005_Unknown> P005_Unknown;
        public event PacketEventHandler<P006_Unknown> P006_Unknown;
        public event PacketEventHandler<P007_Unknown> P007_Unknown;
        public event PacketEventHandler<P008_StartMovement> P008_Unknown;
        public event PacketEventHandler<P009_Unknown> P009_Unknown;
        public event PacketEventHandler<P010_Unknown> P010_Unknown;
        public event PacketEventHandler<P011_Unknown> P011_Unknown;
        public event PacketEventHandler<P012_Unknown> P012_Unknown;
        public event PacketEventHandler<P013_Move> P013_Unknown;
        public event PacketEventHandler<P014_Unknown> P014_Unknown;
        public event PacketEventHandler<P015_Skill> P015_Unknown;
        public event PacketEventHandler<P016_Unknown> P016_Unknown;
        public event PacketEventHandler<P017_Unknown> P017_Unknown;
        public event PacketEventHandler<P018_Unknown> P018_Unknown;
        public event PacketEventHandler<P019_Unknown> P019_Unknown;
        public event PacketEventHandler<P020_Unknown> P020_Unknown;
        public event PacketEventHandler<P021_Unknown> P021_Unknown;
        public event PacketEventHandler<P022_Unknown> P022_Unknown;
        public event PacketEventHandler<P023_Unknown> P023_Unknown;
        public event PacketEventHandler<P024_Unknown> P024_Unknown;
        public event PacketEventHandler<P025_Unknown> P025_Unknown;
        public event PacketEventHandler<P026_Unknown> P026_Unknown;
        public event PacketEventHandler<P028_Unknown> P028_Unknown;
        public event PacketEventHandler<P029_Unknown> P029_Unknown;
        public event PacketEventHandler<P030_Unknown> P030_Unknown;
        public event PacketEventHandler<P031_Unknown> P031_Unknown;
        public event PacketEventHandler<P032_Unknown> P032_Unknown;
        public event PacketEventHandler<P033_Unknown> P033_Unknown;
        public event PacketEventHandler<P034_Unknown> P034_Unknown;
        public event PacketEventHandler<P035_Unknown> P035_Unknown;
        public event PacketEventHandler<P036_Unknown> P036_Unknown;
        public event PacketEventHandler<P037_Unknown> P037_Unknown;
        public event PacketEventHandler<P038_Unknown> P038_Unknown;
        public event PacketEventHandler<P039_Unknown> P039_Unknown;
        public event PacketEventHandler<P040_Unknown> P040_Unknown;
        public event PacketEventHandler<P041_Unknown> P041_Unknown;
        public event PacketEventHandler<P042_Unknown> P042_Unknown;
        public event PacketEventHandler<P043_Unknown> P043_Unknown;
        public event PacketEventHandler<P044_Unknown> P044_Unknown;
        public event PacketEventHandler<P045_Unknown> P045_Unknown;
        public event PacketEventHandler<P046_Unknown> P046_Unknown;
        public event PacketEventHandler<P047_Unknown> P047_Unknown;
        public event PacketEventHandler<P048_Unknown> P048_Unknown;
        public event PacketEventHandler<P049_Unknown> P049_Unknown;
        public event PacketEventHandler<P050_Unknown> P050_Unknown;
        public event PacketEventHandler<P051_Unknown> P051_Unknown;
        public event PacketEventHandler<P052_Unknown> P052_Unknown;
        public event PacketEventHandler<P053_Unknown> P053_Unknown;
        public event PacketEventHandler<P054_Unknown> P054_Unknown;
        public event PacketEventHandler<P055_Unknown> P055_Unknown;
        public event PacketEventHandler<P056_Unknown> P056_Unknown;
        public event PacketEventHandler<P057_Unknown> P057_Unknown;
        public event PacketEventHandler<P058_Unknown> P058_Unknown;
        public event PacketEventHandler<P059_Unknown> P059_Unknown;
        public event PacketEventHandler<P060_Unknown> P060_Unknown;
        public event PacketEventHandler<P061_Unknown> P061_Unknown;
        public event PacketEventHandler<P062_Unknown> P062_Unknown;
        public event PacketEventHandler<P063_Unknown> P063_Unknown;
        public event PacketEventHandler<P064_Unknown> P064_Unknown;
        public event PacketEventHandler<P065_Unknown> P065_Unknown;
        public event PacketEventHandler<P066_Unknown> P066_Unknown;
        public event PacketEventHandler<P067_Unknown> P067_Unknown;
        public event PacketEventHandler<P068_Unknown> P068_Unknown;
        public event PacketEventHandler<P069_Unknown> P069_Unknown;
        public event PacketEventHandler<P070_Unknown> P070_Unknown;
        public event PacketEventHandler<P071_Unknown> P071_Unknown;
        public event PacketEventHandler<P072_Unknown> P072_Unknown;
        public event PacketEventHandler<P073_Unknown> P073_Unknown;
        public event PacketEventHandler<P074_Unknown> P074_Unknown;
        public event PacketEventHandler<P075_Unknown> P075_Unknown;
        public event PacketEventHandler<P076_Unknown> P076_Unknown;
        public event PacketEventHandler<P077_Unknown> P077_Unknown;
        public event PacketEventHandler<P078_Unknown> P078_Unknown;
        public event PacketEventHandler<P079_Unknown> P079_Unknown;
        public event PacketEventHandler<P080_Unknown> P080_Unknown;
        public event PacketEventHandler<P081_Unknown> P081_Unknown;
        public event PacketEventHandler<P082_Unknown> P082_Unknown;
        public event PacketEventHandler<P083_Unknown> P083_Unknown;
        public event PacketEventHandler<P084_Unknown> P084_Unknown;
        public event PacketEventHandler<P085_Unknown> P085_Unknown;
        public event PacketEventHandler<P086_Unknown> P086_Unknown;
        public event PacketEventHandler<P087_Unknown> P087_Unknown;
        public event PacketEventHandler<P088_Unknown> P088_Unknown;
        public event PacketEventHandler<P089_Unknown> P089_Unknown;
        public event PacketEventHandler<P090_Unknown> P090_Unknown;
        public event PacketEventHandler<P091_Unknown> P091_Unknown;
        public event PacketEventHandler<P092_Unknown> P092_Unknown;
        public event PacketEventHandler<P093_Unknown> P093_Unknown;
        public event PacketEventHandler<P094_Unknown> P094_Unknown;
        public event PacketEventHandler<P095_Unknown> P095_Unknown;
        public event PacketEventHandler<P096_Unknown> P096_Unknown;
        public event PacketEventHandler<P097_Unknown> P097_Unknown;
        public event PacketEventHandler<P098_Unknown> P098_Unknown;
        public event PacketEventHandler<P099_Unknown> P099_Unknown;
        public event PacketEventHandler<P100_Unknown> P100_Unknown;
        public event PacketEventHandler<P101_Unknown> P101_Unknown;
        public event PacketEventHandler<P102_Unknown> P102_Unknown;
        public event PacketEventHandler<P103_Unknown> P103_Unknown;
        public event PacketEventHandler<P104_Unknown> P104_Unknown;
        public event PacketEventHandler<P105_Unknown> P105_Unknown;
        public event PacketEventHandler<P106_Unknown> P106_Unknown;
        public event PacketEventHandler<P107_Unknown> P107_Unknown;
        public event PacketEventHandler<P108_Unknown> P108_Unknown;
        public event PacketEventHandler<P109_Unknown> P109_Unknown;
        public event PacketEventHandler<P110_Unknown> P110_Unknown;
        public event PacketEventHandler<P111_Unknown> P111_Unknown;
        public event PacketEventHandler<P112_Unknown> P112_Unknown;
        public event PacketEventHandler<P113_Unknown> P113_Unknown;
        public event PacketEventHandler<P114_Unknown> P114_Unknown;
        public event PacketEventHandler<P115_Unknown> P115_Unknown;
        public event PacketEventHandler<P116_Unknown> P116_Unknown;
        public event PacketEventHandler<P117_Unknown> P117_Unknown;
        public event PacketEventHandler<P118_Unknown> P118_Unknown;
        public event PacketEventHandler<P119_Unknown> P119_Unknown;
        public event PacketEventHandler<P120_Unknown> P120_Unknown;
        public event PacketEventHandler<P121_Unknown> P121_Unknown;
        public event PacketEventHandler<P122_Unknown> P122_Unknown;
        public event PacketEventHandler<P123_Unknown> P123_Unknown;
        public event PacketEventHandler<P124_Unknown> P124_Unknown;
        public event PacketEventHandler<P125_Unknown> P125_Unknown;
        public event PacketEventHandler<P126_Unknown> P126_Unknown;
        public event PacketEventHandler<P127_Unknown> P127_Unknown;
        public event PacketEventHandler<P128_Unknown> P128_Unknown;
        public event PacketEventHandler<P129_Unknown> P129_Unknown;
        public event PacketEventHandler<P130_Unknown> P130_Unknown;
        public event PacketEventHandler<P131_Unknown> P131_Unknown;
        public event PacketEventHandler<P132_Unknown> P132_Unknown;
        public event PacketEventHandler<P133_Unknown> P133_Unknown;
        public event PacketEventHandler<P134_Unknown> P134_Unknown;
        public event PacketEventHandler<P135_Unknown> P135_Unknown;
        public event PacketEventHandler<P136_Unknown> P136_Unknown;
        public event PacketEventHandler<P137_Unknown> P137_Unknown;
        public event PacketEventHandler<P138_Unknown> P138_Unknown;
        public event PacketEventHandler<P139_Unknown> P139_Unknown;
        public event PacketEventHandler<P140_Unknown> P140_Unknown;
        public event PacketEventHandler<P141_Unknown> P141_Unknown;
        public event PacketEventHandler<P142_Unknown> P142_Unknown;
        public event PacketEventHandler<P143_Unknown> P143_Unknown;
        public event PacketEventHandler<P144_Unknown> P144_Unknown;
        public event PacketEventHandler<P145_Unknown> P145_Unknown;
        public event PacketEventHandler<P146_Unknown> P146_Unknown;
        public event PacketEventHandler<P147_Unknown> P147_Unknown;
        public event PacketEventHandler<P148_Unknown> P148_Unknown;
        public event PacketEventHandler<P149_Unknown> P149_Unknown;
        public event PacketEventHandler<P150_Unknown> P150_Unknown;
        public event PacketEventHandler<P151_Unknown> P151_Unknown;
        public event PacketEventHandler<P152_Unknown> P152_Unknown;
        public event PacketEventHandler<P153_Unknown> P153_Unknown;
        public event PacketEventHandler<P154_Unknown> P154_Unknown;
        public event PacketEventHandler<P155_AccountEmail> P155_Unknown;
        public event PacketEventHandler<P156_Unknown> P156_Unknown;
        public event PacketEventHandler<P157_Unknown> P157_Unknown;
        public event PacketEventHandler<P158_Unknown> P158_Unknown;
        public event PacketEventHandler<P159_Unknown> P159_Unknown;
        public event PacketEventHandler<P160_Unknown> P160_Unknown;
        public event PacketEventHandler<P161_Unknown> P161_Unknown;
        public event PacketEventHandler<P162_Unknown> P162_Unknown;
        public event PacketEventHandler<P163_Unknown> P163_Unknown;
        public event PacketEventHandler<P164_Unknown> P164_Unknown;
        public event PacketEventHandler<P165_Unknown> P165_Unknown;
        public event PacketEventHandler<P166_Unknown> P166_Unknown;
        public event PacketEventHandler<P167_Unknown> P167_Unknown;
        public event PacketEventHandler<P168_Unknown> P168_Unknown;
        public event PacketEventHandler<P169_Unknown> P169_Unknown;
        public event PacketEventHandler<P170_Unknown> P170_Unknown;
        public event PacketEventHandler<P171_Unknown> P171_Unknown;
        public event PacketEventHandler<P172_Unknown> P172_Unknown;
        public event PacketEventHandler<P173_Unknown> P173_Unknown;
        public event PacketEventHandler<P174_Unknown> P174_Unknown;
        public event PacketEventHandler<P175_Unknown> P175_Unknown;
        public event PacketEventHandler<P176_Unknown> P176_Unknown;
        public event PacketEventHandler<P177_Unknown> P177_Unknown;
        public event PacketEventHandler<P178_Unknown> P178_Unknown;
        public event PacketEventHandler<P179_Unknown> P179_Unknown;
        public event PacketEventHandler<P180_Unknown> P180_Unknown;
        public event PacketEventHandler<P181_Unknown> P181_Unknown;
        public event PacketEventHandler<P182_Unknown> P182_Unknown;
        public event PacketEventHandler<P183_Unknown> P183_Unknown;
        public event PacketEventHandler<P184_Unknown> P184_Unknown;
        public event PacketEventHandler<P185_Unknown> P185_Unknown;
        public event PacketEventHandler<P186_Unknown> P186_Unknown;
        public event PacketEventHandler<P187_Unknown> P187_Unknown;
        public event PacketEventHandler<P188_Unknown> P188_Unknown;
        public event PacketEventHandler<P189_Unknown> P189_Unknown;
        public event PacketEventHandler<P190_Unknown> P190_Unknown;
        public event PacketEventHandler<P191_Unknown> P191_Unknown;
        public event PacketEventHandler<P192_Unknown> P192_Unknown;
        public event PacketEventHandler<P193_Unknown> P193_Unknown;
        public event PacketEventHandler<P194_Unknown> P194_Unknown;
        public event PacketEventHandler<P195_Unknown> P195_Unknown;
        public event PacketEventHandler<P196_Unknown> P196_Unknown;
        public event PacketEventHandler<P197_Unknown> P197_Unknown;
        public event PacketEventHandler<P198_Unknown> P198_Unknown;
        public event PacketEventHandler<P199_Unknown> P199_Unknown;
        public event PacketEventHandler<P200_Unknown> P200_Unknown;
        public event PacketEventHandler<P201_Unknown> P201_Unknown;
        public event PacketEventHandler<P203_Unknown> P203_Unknown;
        public event PacketEventHandler<P204_Unknown> P204_Unknown;
        public event PacketEventHandler<P205_Unknown> P205_Unknown;
        public event PacketEventHandler<P206_Unknown> P206_Unknown;

        public override bool OnPacketReceived(SecurePacketBasedClient client, Packet packet)
        {
            GamePacketHeaderIn header = (GamePacketHeaderIn)packet.Reader.ReadUInt16();
            
            switch (header)
            {
                case GamePacketHeaderIn.P001_Unknown:
                    RaiseEvent<P001_Unknown>(P001_Unknown, client, new P001_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P002_Unknown:
                    RaiseEvent<P002_Unknown>(P002_Unknown, client, new P002_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P003_Unknown:
                    RaiseEvent<P003_Unknown>(P003_Unknown, client, new P003_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P004_Unknown:
                    RaiseEvent<P004_Unknown>(P004_Unknown, client, new P004_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P005_Unknown:
                    RaiseEvent<P005_Unknown>(P005_Unknown, client, new P005_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P006_Unknown:
                    RaiseEvent<P006_Unknown>(P006_Unknown, client, new P006_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P007_Unknown:
                    RaiseEvent<P007_Unknown>(P007_Unknown, client, new P007_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P008_StartMovement:
                    RaiseEvent<P008_StartMovement>(P008_Unknown, client, new P008_StartMovement(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P009_Unknown:
                    RaiseEvent<P009_Unknown>(P009_Unknown, client, new P009_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P010_Unknown:
                    RaiseEvent<P010_Unknown>(P010_Unknown, client, new P010_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P011_Unknown:
                    RaiseEvent<P011_Unknown>(P011_Unknown, client, new P011_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P012_Unknown:
                    RaiseEvent<P012_Unknown>(P012_Unknown, client, new P012_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P013_Move:
                    RaiseEvent<P013_Move>(P013_Unknown, client, new P013_Move(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P014_Unknown:
                    RaiseEvent<P014_Unknown>(P014_Unknown, client, new P014_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P015_Skill:
                    RaiseEvent<P015_Skill>(P015_Unknown, client, new P015_Skill(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P016_Unknown:
                    RaiseEvent<P016_Unknown>(P016_Unknown, client, new P016_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P017_Unknown:
                    RaiseEvent<P017_Unknown>(P017_Unknown, client, new P017_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P018_Unknown:
                    RaiseEvent<P018_Unknown>(P018_Unknown, client, new P018_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P019_Unknown:
                    RaiseEvent<P019_Unknown>(P019_Unknown, client, new P019_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P020_Unknown:
                    RaiseEvent<P020_Unknown>(P020_Unknown, client, new P020_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P021_Unknown:
                    RaiseEvent<P021_Unknown>(P021_Unknown, client, new P021_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P022_Unknown:
                    RaiseEvent<P022_Unknown>(P022_Unknown, client, new P022_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P023_Unknown:
                    RaiseEvent<P023_Unknown>(P023_Unknown, client, new P023_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P024_Unknown:
                    RaiseEvent<P024_Unknown>(P024_Unknown, client, new P024_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P025_Unknown:
                    RaiseEvent<P025_Unknown>(P025_Unknown, client, new P025_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P026_Unknown:
                    RaiseEvent<P026_Unknown>(P026_Unknown, client, new P026_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P028_Unknown:
                    RaiseEvent<P028_Unknown>(P028_Unknown, client, new P028_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P029_Unknown:
                    RaiseEvent<P029_Unknown>(P029_Unknown, client, new P029_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P030_Unknown:
                    RaiseEvent<P030_Unknown>(P030_Unknown, client, new P030_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P031_Unknown:
                    RaiseEvent<P031_Unknown>(P031_Unknown, client, new P031_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P032_Unknown:
                    RaiseEvent<P032_Unknown>(P032_Unknown, client, new P032_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P033_Unknown:
                    RaiseEvent<P033_Unknown>(P033_Unknown, client, new P033_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P034_Unknown:
                    RaiseEvent<P034_Unknown>(P034_Unknown, client, new P034_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P035_Unknown:
                    RaiseEvent<P035_Unknown>(P035_Unknown, client, new P035_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P036_Unknown:
                    RaiseEvent<P036_Unknown>(P036_Unknown, client, new P036_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P037_Unknown:
                    RaiseEvent<P037_Unknown>(P037_Unknown, client, new P037_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P038_Unknown:
                    RaiseEvent<P038_Unknown>(P038_Unknown, client, new P038_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P039_Unknown:
                    RaiseEvent<P039_Unknown>(P039_Unknown, client, new P039_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P040_Unknown:
                    RaiseEvent<P040_Unknown>(P040_Unknown, client, new P040_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P041_Unknown:
                    RaiseEvent<P041_Unknown>(P041_Unknown, client, new P041_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P042_Unknown:
                    RaiseEvent<P042_Unknown>(P042_Unknown, client, new P042_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P043_Unknown:
                    RaiseEvent<P043_Unknown>(P043_Unknown, client, new P043_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P044_Unknown:
                    RaiseEvent<P044_Unknown>(P044_Unknown, client, new P044_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P045_Unknown:
                    RaiseEvent<P045_Unknown>(P045_Unknown, client, new P045_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P046_Unknown:
                    RaiseEvent<P046_Unknown>(P046_Unknown, client, new P046_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P047_Unknown:
                    RaiseEvent<P047_Unknown>(P047_Unknown, client, new P047_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P048_Unknown:
                    RaiseEvent<P048_Unknown>(P048_Unknown, client, new P048_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P049_Unknown:
                    RaiseEvent<P049_Unknown>(P049_Unknown, client, new P049_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P050_Unknown:
                    RaiseEvent<P050_Unknown>(P050_Unknown, client, new P050_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P051_Unknown:
                    RaiseEvent<P051_Unknown>(P051_Unknown, client, new P051_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P052_Unknown:
                    RaiseEvent<P052_Unknown>(P052_Unknown, client, new P052_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P053_Unknown:
                    RaiseEvent<P053_Unknown>(P053_Unknown, client, new P053_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P054_Unknown:
                    RaiseEvent<P054_Unknown>(P054_Unknown, client, new P054_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P055_Unknown:
                    RaiseEvent<P055_Unknown>(P055_Unknown, client, new P055_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P056_Unknown:
                    RaiseEvent<P056_Unknown>(P056_Unknown, client, new P056_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P057_Unknown:
                    RaiseEvent<P057_Unknown>(P057_Unknown, client, new P057_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P058_Unknown:
                    RaiseEvent<P058_Unknown>(P058_Unknown, client, new P058_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P059_Unknown:
                    RaiseEvent<P059_Unknown>(P059_Unknown, client, new P059_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P060_Unknown:
                    RaiseEvent<P060_Unknown>(P060_Unknown, client, new P060_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P061_Unknown:
                    RaiseEvent<P061_Unknown>(P061_Unknown, client, new P061_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P062_Unknown:
                    RaiseEvent<P062_Unknown>(P062_Unknown, client, new P062_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P063_Unknown:
                    RaiseEvent<P063_Unknown>(P063_Unknown, client, new P063_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P064_Unknown:
                    RaiseEvent<P064_Unknown>(P064_Unknown, client, new P064_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P065_Unknown:
                    RaiseEvent<P065_Unknown>(P065_Unknown, client, new P065_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P066_Unknown:
                    RaiseEvent<P066_Unknown>(P066_Unknown, client, new P066_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P067_Unknown:
                    RaiseEvent<P067_Unknown>(P067_Unknown, client, new P067_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P068_Unknown:
                    RaiseEvent<P068_Unknown>(P068_Unknown, client, new P068_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P069_Unknown:
                    RaiseEvent<P069_Unknown>(P069_Unknown, client, new P069_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P070_Unknown:
                    RaiseEvent<P070_Unknown>(P070_Unknown, client, new P070_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P071_Unknown:
                    RaiseEvent<P071_Unknown>(P071_Unknown, client, new P071_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P072_Unknown:
                    RaiseEvent<P072_Unknown>(P072_Unknown, client, new P072_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P073_Unknown:
                    RaiseEvent<P073_Unknown>(P073_Unknown, client, new P073_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P074_Unknown:
                    RaiseEvent<P074_Unknown>(P074_Unknown, client, new P074_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P075_Unknown:
                    RaiseEvent<P075_Unknown>(P075_Unknown, client, new P075_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P076_Unknown:
                    RaiseEvent<P076_Unknown>(P076_Unknown, client, new P076_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P077_Unknown:
                    RaiseEvent<P077_Unknown>(P077_Unknown, client, new P077_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P078_Unknown:
                    RaiseEvent<P078_Unknown>(P078_Unknown, client, new P078_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P079_Unknown:
                    RaiseEvent<P079_Unknown>(P079_Unknown, client, new P079_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P080_Unknown:
                    RaiseEvent<P080_Unknown>(P080_Unknown, client, new P080_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P081_Unknown:
                    RaiseEvent<P081_Unknown>(P081_Unknown, client, new P081_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P082_Unknown:
                    RaiseEvent<P082_Unknown>(P082_Unknown, client, new P082_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P083_Unknown:
                    RaiseEvent<P083_Unknown>(P083_Unknown, client, new P083_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P084_Unknown:
                    RaiseEvent<P084_Unknown>(P084_Unknown, client, new P084_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P085_Unknown:
                    RaiseEvent<P085_Unknown>(P085_Unknown, client, new P085_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P086_Unknown:
                    RaiseEvent<P086_Unknown>(P086_Unknown, client, new P086_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P087_Unknown:
                    RaiseEvent<P087_Unknown>(P087_Unknown, client, new P087_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P088_Unknown:
                    RaiseEvent<P088_Unknown>(P088_Unknown, client, new P088_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P089_Unknown:
                    RaiseEvent<P089_Unknown>(P089_Unknown, client, new P089_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P090_Unknown:
                    RaiseEvent<P090_Unknown>(P090_Unknown, client, new P090_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P091_Unknown:
                    RaiseEvent<P091_Unknown>(P091_Unknown, client, new P091_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P092_Unknown:
                    RaiseEvent<P092_Unknown>(P092_Unknown, client, new P092_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P093_Unknown:
                    RaiseEvent<P093_Unknown>(P093_Unknown, client, new P093_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P094_Unknown:
                    RaiseEvent<P094_Unknown>(P094_Unknown, client, new P094_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P095_Unknown:
                    RaiseEvent<P095_Unknown>(P095_Unknown, client, new P095_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P096_Unknown:
                    RaiseEvent<P096_Unknown>(P096_Unknown, client, new P096_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P097_Unknown:
                    RaiseEvent<P097_Unknown>(P097_Unknown, client, new P097_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P098_Unknown:
                    RaiseEvent<P098_Unknown>(P098_Unknown, client, new P098_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P099_Unknown:
                    RaiseEvent<P099_Unknown>(P099_Unknown, client, new P099_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P100_Unknown:
                    RaiseEvent<P100_Unknown>(P100_Unknown, client, new P100_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P101_Unknown:
                    RaiseEvent<P101_Unknown>(P101_Unknown, client, new P101_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P102_Unknown:
                    RaiseEvent<P102_Unknown>(P102_Unknown, client, new P102_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P103_Unknown:
                    RaiseEvent<P103_Unknown>(P103_Unknown, client, new P103_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P104_Unknown:
                    RaiseEvent<P104_Unknown>(P104_Unknown, client, new P104_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P105_Unknown:
                    RaiseEvent<P105_Unknown>(P105_Unknown, client, new P105_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P106_Unknown:
                    RaiseEvent<P106_Unknown>(P106_Unknown, client, new P106_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P107_Unknown:
                    RaiseEvent<P107_Unknown>(P107_Unknown, client, new P107_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P108_Unknown:
                    RaiseEvent<P108_Unknown>(P108_Unknown, client, new P108_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P109_Unknown:
                    RaiseEvent<P109_Unknown>(P109_Unknown, client, new P109_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P110_Unknown:
                    RaiseEvent<P110_Unknown>(P110_Unknown, client, new P110_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P111_Unknown:
                    RaiseEvent<P111_Unknown>(P111_Unknown, client, new P111_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P112_Unknown:
                    RaiseEvent<P112_Unknown>(P112_Unknown, client, new P112_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P113_Unknown:
                    RaiseEvent<P113_Unknown>(P113_Unknown, client, new P113_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P114_Unknown:
                    RaiseEvent<P114_Unknown>(P114_Unknown, client, new P114_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P115_Unknown:
                    RaiseEvent<P115_Unknown>(P115_Unknown, client, new P115_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P116_Unknown:
                    RaiseEvent<P116_Unknown>(P116_Unknown, client, new P116_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P117_Unknown:
                    RaiseEvent<P117_Unknown>(P117_Unknown, client, new P117_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P118_Unknown:
                    RaiseEvent<P118_Unknown>(P118_Unknown, client, new P118_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P119_Unknown:
                    RaiseEvent<P119_Unknown>(P119_Unknown, client, new P119_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P120_Unknown:
                    RaiseEvent<P120_Unknown>(P120_Unknown, client, new P120_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P121_Unknown:
                    RaiseEvent<P121_Unknown>(P121_Unknown, client, new P121_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P122_Unknown:
                    RaiseEvent<P122_Unknown>(P122_Unknown, client, new P122_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P123_Unknown:
                    RaiseEvent<P123_Unknown>(P123_Unknown, client, new P123_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P124_Unknown:
                    RaiseEvent<P124_Unknown>(P124_Unknown, client, new P124_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P125_Unknown:
                    RaiseEvent<P125_Unknown>(P125_Unknown, client, new P125_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P126_Unknown:
                    RaiseEvent<P126_Unknown>(P126_Unknown, client, new P126_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P127_Unknown:
                    RaiseEvent<P127_Unknown>(P127_Unknown, client, new P127_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P128_Unknown:
                    RaiseEvent<P128_Unknown>(P128_Unknown, client, new P128_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P129_Unknown:
                    RaiseEvent<P129_Unknown>(P129_Unknown, client, new P129_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P130_Unknown:
                    RaiseEvent<P130_Unknown>(P130_Unknown, client, new P130_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P131_Unknown:
                    RaiseEvent<P131_Unknown>(P131_Unknown, client, new P131_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P132_Unknown:
                    RaiseEvent<P132_Unknown>(P132_Unknown, client, new P132_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P133_Unknown:
                    RaiseEvent<P133_Unknown>(P133_Unknown, client, new P133_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P134_Unknown:
                    RaiseEvent<P134_Unknown>(P134_Unknown, client, new P134_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P135_Unknown:
                    RaiseEvent<P135_Unknown>(P135_Unknown, client, new P135_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P136_Unknown:
                    RaiseEvent<P136_Unknown>(P136_Unknown, client, new P136_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P137_Unknown:
                    RaiseEvent<P137_Unknown>(P137_Unknown, client, new P137_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P138_Unknown:
                    RaiseEvent<P138_Unknown>(P138_Unknown, client, new P138_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P139_Unknown:
                    RaiseEvent<P139_Unknown>(P139_Unknown, client, new P139_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P140_Unknown:
                    RaiseEvent<P140_Unknown>(P140_Unknown, client, new P140_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P141_Unknown:
                    RaiseEvent<P141_Unknown>(P141_Unknown, client, new P141_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P142_Unknown:
                    RaiseEvent<P142_Unknown>(P142_Unknown, client, new P142_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P143_Unknown:
                    RaiseEvent<P143_Unknown>(P143_Unknown, client, new P143_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P144_Unknown:
                    RaiseEvent<P144_Unknown>(P144_Unknown, client, new P144_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P145_Unknown:
                    RaiseEvent<P145_Unknown>(P145_Unknown, client, new P145_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P146_Unknown:
                    RaiseEvent<P146_Unknown>(P146_Unknown, client, new P146_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P147_Unknown:
                    RaiseEvent<P147_Unknown>(P147_Unknown, client, new P147_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P148_Unknown:
                    RaiseEvent<P148_Unknown>(P148_Unknown, client, new P148_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P149_Unknown:
                    RaiseEvent<P149_Unknown>(P149_Unknown, client, new P149_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P150_Unknown:
                    RaiseEvent<P150_Unknown>(P150_Unknown, client, new P150_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P151_Unknown:
                    RaiseEvent<P151_Unknown>(P151_Unknown, client, new P151_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P152_Unknown:
                    RaiseEvent<P152_Unknown>(P152_Unknown, client, new P152_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P153_Unknown:
                    RaiseEvent<P153_Unknown>(P153_Unknown, client, new P153_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P154_Unknown:
                    RaiseEvent<P154_Unknown>(P154_Unknown, client, new P154_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P155_AccountEmail:
                    RaiseEvent<P155_AccountEmail>(P155_Unknown, client, new P155_AccountEmail(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P156_Unknown:
                    RaiseEvent<P156_Unknown>(P156_Unknown, client, new P156_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P157_Unknown:
                    RaiseEvent<P157_Unknown>(P157_Unknown, client, new P157_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P158_Unknown:
                    RaiseEvent<P158_Unknown>(P158_Unknown, client, new P158_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P159_Unknown:
                    RaiseEvent<P159_Unknown>(P159_Unknown, client, new P159_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P160_Unknown:
                    RaiseEvent<P160_Unknown>(P160_Unknown, client, new P160_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P161_Unknown:
                    RaiseEvent<P161_Unknown>(P161_Unknown, client, new P161_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P162_Unknown:
                    RaiseEvent<P162_Unknown>(P162_Unknown, client, new P162_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P163_Unknown:
                    RaiseEvent<P163_Unknown>(P163_Unknown, client, new P163_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P164_Unknown:
                    RaiseEvent<P164_Unknown>(P164_Unknown, client, new P164_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P165_Unknown:
                    RaiseEvent<P165_Unknown>(P165_Unknown, client, new P165_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P166_Unknown:
                    RaiseEvent<P166_Unknown>(P166_Unknown, client, new P166_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P167_Unknown:
                    RaiseEvent<P167_Unknown>(P167_Unknown, client, new P167_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P168_Unknown:
                    RaiseEvent<P168_Unknown>(P168_Unknown, client, new P168_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P169_Unknown:
                    RaiseEvent<P169_Unknown>(P169_Unknown, client, new P169_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P170_Unknown:
                    RaiseEvent<P170_Unknown>(P170_Unknown, client, new P170_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P171_Unknown:
                    RaiseEvent<P171_Unknown>(P171_Unknown, client, new P171_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P172_Unknown:
                    RaiseEvent<P172_Unknown>(P172_Unknown, client, new P172_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P173_Unknown:
                    RaiseEvent<P173_Unknown>(P173_Unknown, client, new P173_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P174_Unknown:
                    RaiseEvent<P174_Unknown>(P174_Unknown, client, new P174_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P175_Unknown:
                    RaiseEvent<P175_Unknown>(P175_Unknown, client, new P175_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P176_Unknown:
                    RaiseEvent<P176_Unknown>(P176_Unknown, client, new P176_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P177_Unknown:
                    RaiseEvent<P177_Unknown>(P177_Unknown, client, new P177_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P178_Unknown:
                    RaiseEvent<P178_Unknown>(P178_Unknown, client, new P178_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P179_Unknown:
                    RaiseEvent<P179_Unknown>(P179_Unknown, client, new P179_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P180_Unknown:
                    RaiseEvent<P180_Unknown>(P180_Unknown, client, new P180_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P181_Unknown:
                    RaiseEvent<P181_Unknown>(P181_Unknown, client, new P181_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P182_Unknown:
                    RaiseEvent<P182_Unknown>(P182_Unknown, client, new P182_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P183_Unknown:
                    RaiseEvent<P183_Unknown>(P183_Unknown, client, new P183_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P184_Unknown:
                    RaiseEvent<P184_Unknown>(P184_Unknown, client, new P184_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P185_Unknown:
                    RaiseEvent<P185_Unknown>(P185_Unknown, client, new P185_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P186_Unknown:
                    RaiseEvent<P186_Unknown>(P186_Unknown, client, new P186_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P187_Unknown:
                    RaiseEvent<P187_Unknown>(P187_Unknown, client, new P187_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P188_Unknown:
                    RaiseEvent<P188_Unknown>(P188_Unknown, client, new P188_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P189_Unknown:
                    RaiseEvent<P189_Unknown>(P189_Unknown, client, new P189_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P190_Unknown:
                    RaiseEvent<P190_Unknown>(P190_Unknown, client, new P190_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P191_Unknown:
                    RaiseEvent<P191_Unknown>(P191_Unknown, client, new P191_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P192_Unknown:
                    RaiseEvent<P192_Unknown>(P192_Unknown, client, new P192_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P193_Unknown:
                    RaiseEvent<P193_Unknown>(P193_Unknown, client, new P193_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P194_Unknown:
                    RaiseEvent<P194_Unknown>(P194_Unknown, client, new P194_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P195_Unknown:
                    RaiseEvent<P195_Unknown>(P195_Unknown, client, new P195_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P196_Unknown:
                    RaiseEvent<P196_Unknown>(P196_Unknown, client, new P196_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P197_Unknown:
                    RaiseEvent<P197_Unknown>(P197_Unknown, client, new P197_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P198_Unknown:
                    RaiseEvent<P198_Unknown>(P198_Unknown, client, new P198_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P199_Unknown:
                    RaiseEvent<P199_Unknown>(P199_Unknown, client, new P199_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P200_Unknown:
                    RaiseEvent<P200_Unknown>(P200_Unknown, client, new P200_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P201_Unknown:
                    RaiseEvent<P201_Unknown>(P201_Unknown, client, new P201_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P203_Unknown:
                    RaiseEvent<P203_Unknown>(P203_Unknown, client, new P203_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P204_Unknown:
                    RaiseEvent<P204_Unknown>(P204_Unknown, client, new P204_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P205_Unknown:
                    RaiseEvent<P205_Unknown>(P205_Unknown, client, new P205_Unknown(packet.Reader));
                    return true;
                case GamePacketHeaderIn.P206_Unknown:
                    RaiseEvent<P206_Unknown>(P206_Unknown, client, new P206_Unknown(packet.Reader));
                    return true;
                default:
                    Console.WriteLine("Unhandled packet: " + header);
                    return false;
            }
        }
    }
}
