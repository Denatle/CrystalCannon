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
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health,
            Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            statModifiers.WasDealtDamageAction = (damage, selfDamage) => { characterStats.health = 0; };
            gun.percentageDamage = 50f;
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
            return "Get killed on any damage. Kill anyone with 2 shots.";
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