using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Redemption;
using Redemption.NPCs.Bosses.EaglecrestGolem;

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
            if (npc.type == RedeMod.NPCType("TheKeeper"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossKeeper");
            }
            if (npc.type == RedeMod.NPCType("VlitchCleaver") || npc.type == RedeMod.NPCType("VlitchCore1") || npc.type == RedeMod.NPCType("VlitchCore2") || npc.type == RedeMod.NPCType("VlitchCore3") || npc.type == RedeMod.NPCType("VlitchWormHead"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossVlitch1");
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
            if (npc.type == RedeMod.NPCType("InfectedEye"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossXeno2");
            }
            if (npc.type == RedeMod.NPCType("KSEntrance") || npc.type == RedeMod.NPCType("KSEntranceClone"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossSlayer");
            }
            if (npc.type == RedeMod.NPCType("Nebuleus") || npc.type == RedeMod.NPCType("NebuleusClone") || npc.type == RedeMod.NPCType("StarWyvernHead"))
            {
                if (RedeConfigClient.Instance.AntiAntti)
                {
                    if (RedeConfigClient.Instance.MusicReplacements)
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Flap2");
                    }
                    else
                    {
                        npc.modNPC.music = MusicID.LunarBoss;
                    }
                }
                else
                {
                    npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossStarGod1");
                }
            }
            if (npc.type == RedeMod.NPCType("BigNebuleus") || npc.type == RedeMod.NPCType("BigNebuleusClone"))
            {
                if (RedeConfigClient.Instance.AntiAntti)
                {
                    if (RedeConfigClient.Instance.MusicReplacements)
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Irregular");
                    }
                    else
                    {
                        npc.modNPC.music = MusicID.LunarBoss;
                    }
                }
                else
                {
                    npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossStarGod2");
                }
            }
            if (npc.type == RedeMod.NPCType("OmegaOblitIdle") || npc.type == RedeMod.NPCType("OmegaOblitDamaged"))
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
            if (npc.type == RedeMod.NPCType("Blisterface2") || npc.type == RedeMod.NPCType("IrradiatedBehemoth2") || npc.type == RedeMod.NPCType("JanitorBot") || npc.type == RedeMod.NPCType("MACEProjectHeadA") || npc.type == RedeMod.NPCType("MACEProjectJawA") || npc.type == RedeMod.NPCType("Stage3Scientist2") || npc.type == RedeMod.NPCType("TbotMiniboss"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/LabBossMusic");
            }
            if (npc.type == RedeMod.NPCType("Blisterface") || npc.type == RedeMod.NPCType("IrradiatedBehemoth") || npc.type == RedeMod.NPCType("MACEProjectHead") || npc.type == RedeMod.NPCType("MACEProjectJaw") || npc.type == RedeMod.NPCType("Stage2ScientistBoss") || npc.type == RedeMod.NPCType("Stage3Scientist"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/LabBossMusic");
            }
            if (npc.type == RedeMod.NPCType("PZ2BodyCover") || npc.type == RedeMod.NPCType("PZ2Fight") || npc.type == RedeMod.NPCType("PatientZero"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/LabBossMusic2");
            }
            if (npc.type == RedeMod.NPCType("SkullDigger"))
            {
                npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/SilentCaverns");
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
            if (npc.type == RedeMod.NPCType("KSEntrance"))
            {
                if (npc.life <= 10000 && npc.ai[0] >= 580 && !NPC.AnyNPCs(mod.NPCType("SpaceKeeper")))
                {
                    npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossSlayer2");
                }
            }
            if (npc.type == RedeMod.NPCType("Nebuleus") || npc.type == RedeMod.NPCType("NebuleusClone"))
            {
                if (Main.expertMode && npc.life <= (int)(npc.lifeMax * 0.07f) && (RedeConfigClient.Instance.NoBossText || npc.type == RedeMod.NPCType("NebuleusClone") ? npc.ai[3] >= 0 : npc.ai[3] >= 400))
                {
                    if (RedeConfigClient.Instance.AntiAntti)
                    {
                        if (RedeConfigClient.Instance.MusicReplacements)
                        {
                            npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Irregular");
                        }
                        else
                        {
                            npc.modNPC.music = MusicID.LunarBoss;
                        }
                    }
                    else
                    {
                        npc.modNPC.music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BossStarGod2");
                    }
                }
            }
        }
    }
}