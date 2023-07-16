using CrystalCannon.Effects;
using UnboundLib.Cards;
using UnityEngine;

// ReSharper disable ParameterHidesMember

namespace CrystalCannon.Cards
{
    public class CrystalCannon : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats,
            CharacterStatModifiers statModifiers, Block block)
        {
            cardInfo.allowMultiple = false;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health,
            Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            player.gameObject.AddComponent<CrystalCannonDamageEffect>().player = player;
            player.gameObject.AddComponent<CrystalCannonWasDamagedEffect>().player = player;
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health,
            Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        protected override string GetTitle()
        {
            return "Crystal Cannon";
        }

        protected override string GetDescription()
        {
            return
                "Kill anyone with <b><color=#5fa52aff>2 shots.</color></b>\nGet killed on <b><color=#a52a2aff>ANY damage.</color></b>";
        }

        protected override GameObject GetCardArt()
        {
            return null;
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Rare;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Damage",
                    simepleAmount = CardInfoStat.SimpleAmount.aHugeAmountOf
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Health",
                    simepleAmount = CardInfoStat.SimpleAmount.aLotLower
                }
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.EvilPurple;
        }

        public override string GetModName()
        {
            return CC.ModInitials;
        }
    }
}