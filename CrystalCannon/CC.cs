using BepInEx; // requires BepInEx.dll and BepInEx.Harmony.dll
using UnboundLib; // requires UnboundLib.dll
using UnboundLib.Cards; // " "
using HarmonyLib; // requires 0Harmony.dll
using CC.Cards;
using UnityEngine;


// ReSharper disable InconsistentNaming
// ReSharper disable StringLiteralTypo


namespace CC
{
    [BepInDependency("com.willis.rounds.unbound")] // necessary for most modding stuff here
    [BepInDependency("pykess.rounds.plugins.playerjumppatch")] // fixes multiple jumps
    [BepInDependency("pykess.rounds.plugins.legraycasterspatch")] // fixes physics for small players
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch")] // fixes allowMultiple and blacklistedCategories
    [BepInDependency("pykess.rounds.plugins.gununblockablepatch")] // fixes gun.unblockable
    [BepInDependency("pykess.rounds.plugins.temporarystatspatch")] // fixes Taste Of Blood, Pristine Perserverence, and Chase when combined with cards from PCE
    [BepInDependency("pykess.rounds.plugins.moddingutils")] // utilities for cards and cardbars
    [BepInDependency("com.dk.rounds.plugins.zerogpatch")]
    [BepInPlugin(ModId, ModName, "0.0.1")]
    [BepInProcess("Rounds.exe")]
    public class CC : BaseUnityPlugin
    {
        private void Awake()
        {
            UnityEngine.Debug.Log("Crystal Cannon It WORKS!!!"); 
            new Harmony(ModId).PatchAll();
        }

        private void Start()
        {
            instance = this;
            // register credits with unbound
            Unbound.RegisterCredits(ModName, new[] { "Denatle" }, null, "");

            // build all cards
            CustomCard.BuildCard<CrystalCannon>();
        }

        private const string ModId = "denatle.rounds.plugins.crystalcannon";
        private const string ModName = "Crystal Cannon";
        public const string ModInitials = "CC";
    }
}