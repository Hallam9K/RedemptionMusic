using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Redemption;
using Redemption.NPCs.Bosses.EaglecrestGolem;
using Redemption.NPCs.Bosses;

namespace RedemptionMusic
{
    public class MusicNPC : GlobalNPC
    {
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        public override void SetDefaults(NPC npc)
        {
            Mod RedeMod = ModLoader.GetMod("Redemption");
            if (npc.type == RedeMod.NPCType("KingChicken"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossKingChicken");
            }
            if (npc.type == RedeMod.NPCType("Keeper") || npc.type == RedeMod.NPCType("KeeperSpirit"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossKeeper");
            }
            if (npc.type == RedeMod.NPCType("VlitchCleaver"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossVlitch1");
            }
            if (npc.type == RedeMod.NPCType("VlitchCore1") || npc.type == RedeMod.NPCType("VlitchCore2") || npc.type == RedeMod.NPCType("VlitchCore3") || npc.type == RedeMod.NPCType("VlitchWormHead"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossVlitch1G");
            }
            if (npc.type == RedeMod.NPCType("EaglecrestGolem") || npc.type == RedeMod.NPCType("EaglecrestGolemPZ") || npc.type == RedeMod.NPCType("Thorn") || npc.type == RedeMod.NPCType("ThornPZ"))
            {
                if (RedeConfigClient.Instance.AntiAntti)
                {
                    if (RedeConfigClient.Instance.MusicReplacements)
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Dramatic4");
                    }
                    else
                    {
                        npc.modNPC.music = MusicID.Boss1;
                    }
                }
                else
                {
                    npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossForest1");
                }
            }
            if (npc.type == RedeMod.NPCType("Ukko") || npc.type == RedeMod.NPCType("Akka"))
            {
                if (RedeConfigClient.Instance.AntiAntti)
                {
                    if (RedeConfigClient.Instance.MusicReplacements)
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Havoc");
                    }
                    else
                    {
                        npc.modNPC.music = MusicID.Boss1;
                    }
                }
                else
                {
                    npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossForest2");
                }
            }
            if (npc.type == RedeMod.NPCType("KS3_Body") || npc.type == RedeMod.NPCType("KS3_Body_Clone"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossSlayer");
            }
            if (npc.type == RedeMod.NPCType("NebP1") || npc.type == RedeMod.NPCType("NebP1_Clone") || npc.type == RedeMod.NPCType("StarWyvernHead"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossStarGod1");
            }
            if (npc.type == RedeMod.NPCType("NebP2") || npc.type == RedeMod.NPCType("NebP2_Clone"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossStarGod2");
            }
            if (npc.type == RedeMod.NPCType("OO"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossVlitch2");
            }
            if (npc.type == RedeMod.NPCType("SoI"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossXeno1");
            }
            if (npc.type == RedeMod.NPCType("TrojanChicken") || npc.type == RedeMod.NPCType("RoosterKing"))
            {
                if (RedeWorld.downedPatientZero)
                {
                    npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/ChickenInvasion1");
                }
                else
                {
                    npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossKingChicken");
                }
            }
            if (npc.type == RedeMod.NPCType("Blisterface2") || npc.type == RedeMod.NPCType("JanitorBot") || npc.type == RedeMod.NPCType("TbotMiniboss"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/LabBossMusic");
            }
            if (npc.type == RedeMod.NPCType("IrradiatedBehemoth2"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/LabBossMusicIB");
            }
            if (npc.type == RedeMod.NPCType("MACEProjectHeadA") || npc.type == RedeMod.NPCType("MACEProjectJawA"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/LabBossMusicMP");
            }
            if (npc.type == RedeMod.NPCType("Stage3Scientist2"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/LabBossMusicIS");
            }
            if (npc.type == RedeMod.NPCType("PZ2BodyCover") || npc.type == RedeMod.NPCType("PZ2Fight"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/LabBossMusic2");
            }
            if (npc.type == RedeMod.NPCType("SkullDigger"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/SilentCaverns");
            }
            if (npc.type == RedeMod.NPCType("WardenIdle"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossSoulless");
                npc.modNPC.musicPriority = MusicPriority.BossHigh;
            }
        }
        public override void PostAI(NPC npc)
        {
            Mod RedeMod = ModLoader.GetMod("Redemption");
            if (npc.type == RedeMod.NPCType("EaglecrestGolemPZ") || npc.type == RedeMod.NPCType("ThornPZ"))
            {
                if (RedeUkkoAkka.begin)
                {
                    if (!RedeConfigClient.Instance.AntiAntti)
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossForest2");
                    }
                    else
                    {
                        if (RedeConfigClient.Instance.MusicReplacements)
                        {
                            npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Havoc");
                        }
                    }
                }
            }
            if (npc.type == RedeMod.NPCType("KSStart"))
            {
                if (npc.ai[0] == 4)
                {
                    npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossSlayer");
                }
            }
            if (npc.type == RedeMod.NPCType("KS3_Body"))
            {
                if (npc.ai[0] == 13 && npc.ai[2] >= 30)
                {
                    npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossSlayer2");
                }
            }
            if (npc.type == RedeMod.NPCType("OO"))
            {
                if (npc.ai[0] > 1 && npc.ai[0] < 5)
                {
                    npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossVlitch2");
                }
            }
            if (npc.type == RedeMod.NPCType("WardenIdle"))
            {
                if (npc.ai[0] < 20)
                {
                    npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossSoulless");
                }
            }
            if (npc.type == RedeMod.NPCType("NebP1"))
            {
                if (npc.ai[0] == 10)
                {
                    npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossStarGod2");
                }
            }
        }
        public override bool StrikeNPC(NPC npc, ref double damage, int defense, ref float knockback, int hitDirection, ref bool crit)
        {
            Mod RedeMod = ModLoader.GetMod("Redemption");
            if (npc.type == RedeMod.NPCType("KS3_Body"))
            {
                if (damage <= 0.6f)
                {
                    npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossSlayer2");
                }
            }
            return base.StrikeNPC(npc, ref damage, defense, ref knockback, hitDirection, ref crit);
        }
    }
}