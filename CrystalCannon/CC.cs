using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using HarmonyLib;

// ReSharper disable InconsistentNaming
// ReSharper disable StringLiteralTypo


namespace CrystalCannon
{
    [BepInDependency("com.willis.rounds.unbound")] // necessary for most modding stuff here
    [BepInDependency("pykess.rounds.plugins.playerjumppatch")] // fixes multiple jumps
    [BepInDependency("pykess.rounds.plugins.legraycasterspatch")] // fixes physics for small players
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch")] // fixes allowMultiple and blacklistedCategories
    [BepInDependency("pykess.rounds.plugins.gununblockablepatch")] // fixes gun.unblockable
    [BepInDependency("pykess.rounds.plugins.temporarystatspatch")] // fixes Taste Of Blood, Pristine Perserverence, and Chase when combined with cards from PCE
    [BepInDependency("pykess.rounds.plugins.moddingutils")] // utilities for cards and cardbars
    [BepInDependency("com.dk.rounds.plugins.zerogpatch")]
    [BepInPlugin(ModId, ModName, "0.1.0")]
    [BepInProcess("Rounds.exe")]
    public class CC : BaseUnityPlugin
    {
        private void Awake()
        {
            new Harmony(ModId).PatchAll();
        }

        private void Start()
        {
            instance = this;
            // register credits with unbound
            Unbound.RegisterCredits(ModName, new[] { "Denatle" }, null, "");

            // build all cards
            CustomCard.BuildCard<global::CrystalCannon.Cards.CrystalCannon>();
        }

        public static CC instance { get; private set; }
        private const string ModId = "denatle.rounds.plugins.crystalcannon";
        private const string ModName = "Crystal Cannon";
        public const string ModInitials = "CC";
    }
}