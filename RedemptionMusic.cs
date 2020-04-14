using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.UI;
using System;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.Localization;
using System.IO;
using Terraria.Graphics.Effects;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Shaders;
using Terraria.UI;
using Redemption.ChickenArmy;
using Redemption;
using Redemption.Items;

namespace RedemptionMusic
{
    class RedemptionMusic : Mod
    {
        public static RedemptionMusic inst = null;

        public RedemptionMusic()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadSounds = true,
            };
        }
        public static bool MoRLoaded = false;
        public override void PostSetupContent()
        {
            Mod RedemptionMod = ModLoader.GetMod("Redemption");
            if (RedemptionMod != null) MoRLoaded = true;
        }
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            Mod RedeMod = ModLoader.GetMod("Redemption");

            if (Main.gameMenu)
                return;
            if (priority > MusicPriority.Environment)
                return;
            Player player = Main.LocalPlayer;
            if (!player.active)
                return;

            if (Main.myPlayer != -1 && !Main.gameMenu)
            {
                if (ChickWorld.chickArmy)
                {
                    if (RedeWorld.downedPatientZero)
                    {
                        if (RedeConfigClient.Instance.AntiAntti)
                        {
                            if (RedeConfigClient.Instance.MusicReplacements)
                            {
                                music = GetSoundSlot(SoundType.Music, "Sounds/Music/ChickenInvasion1Alt");
                                priority = MusicPriority.Event;
                            }
                            else
                            {
                                music = MusicID.PirateInvasion;
                                priority = MusicPriority.Event;
                            }
                        }
                        else
                        {
                            music = GetSoundSlot(SoundType.Music, "Sounds/Music/ChickenInvasion1");
                            priority = MusicPriority.Event;
                        }
                    }
                    else
                    {
                        music = GetSoundSlot(SoundType.Music, "Sounds/Music/BossKingChicken");
                        priority = MusicPriority.Event;
                    }
                }
                if (Main.player[Main.myPlayer].active && (Main.player[Main.myPlayer].GetModPlayer<RedePlayer>().ZoneXeno || Main.player[Main.myPlayer].GetModPlayer<RedePlayer>().ZoneEvilXeno)) //this makes the music play only in Custom Biome
                {
                    music = this.GetSoundSlot(SoundType.Music, "Sounds/Music/XenoCaves");  //add where is the custom music is located
                    priority = MusicPriority.BiomeHigh;
                }
                if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].GetModPlayer<RedePlayer>().ZoneLab) //this makes the music play only in Custom Biome
                {
                    music = this.GetSoundSlot(SoundType.Music, "Sounds/Music/LabMusic");  //add where is the custom music is located
                    priority = MusicPriority.BiomeHigh;
                }
                if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].GetModPlayer<RedePlayer>().ZoneSlayer && RedeWorld.downedSlayer) //this makes the music play only in Custom Biome
                {
                    music = this.GetSoundSlot(SoundType.Music, "Sounds/Music/SlayerShipMusic");  //add where is the custom music is located
                    priority = MusicPriority.BiomeHigh;
                }
                if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].GetModPlayer<RedePlayer>().ZoneSoulless && Main.player[Main.myPlayer].GetModPlayer<RedePlayer>().dreamsong) //this makes the music play only in Custom Biome
                {
                    music = this.GetSoundSlot(SoundType.Music, "Sounds/Music/SoullessCaverns");  //add where is the custom music is located
                    priority = MusicPriority.Event;
                }
            }
        }
        public override void Load()
        {
            Mod RedeMod = ModLoader.GetMod("Redemption");
            inst = this;
            if (!Main.dedServ)
            {
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/XenoCaves"), RedeMod.ItemType("WastelandBox"), RedeMod.TileType("WastelandBoxTile"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossXeno1"), RedeMod.ItemType("XenomiteCrystalBox"), RedeMod.TileType("XenomiteCrystalBoxTile"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossXeno2"), RedeMod.ItemType("InfectedEyeBox"), RedeMod.TileType("InfectedEyeBoxTile"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossSlayer"), RedeMod.ItemType("KSBox"), RedeMod.TileType("KSBoxTile"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossVlitch1"), RedeMod.ItemType("VlitchBox"), RedeMod.TileType("VlitchBoxTile"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossKeeper"), RedeMod.ItemType("KeeperBox"), RedeMod.TileType("KeeperBoxTile"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossVlitch2"), RedeMod.ItemType("VlitchBox2"), RedeMod.TileType("VlitchBoxTile2"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LabMusic"), RedeMod.ItemType("LabMusicBox"), RedeMod.TileType("LabMusicBoxTile"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LabBossMusic"), RedeMod.ItemType("LabBossMusicBox"), RedeMod.TileType("LabBossMusicBoxTile"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LabBossMusic2"), RedeMod.ItemType("PZMusicBox"), RedeMod.TileType("PZMusicBoxTile"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossStarGod1"), RedeMod.ItemType("NebBox"), RedeMod.TileType("NebBoxTile"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossStarGod2"), RedeMod.ItemType("NebBox2"), RedeMod.TileType("NebBox2Tile"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossForest1"), RedeMod.ItemType("ForestBossBox"), RedeMod.TileType("ForestBossBoxTile"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossForest2"), RedeMod.ItemType("ForestBossBox2"), RedeMod.TileType("ForestBossBox2Tile"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/ChickenInvasion1"), RedeMod.ItemType("ChickenInvasionBox"), RedeMod.TileType("ChickenInvasionBoxTile"));
            }
        }
        public override void Unload()
        {
            inst = null;
        }
    }
}