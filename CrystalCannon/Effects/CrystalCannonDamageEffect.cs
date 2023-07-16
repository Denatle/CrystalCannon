using UnityEngine;

namespace CrystalCannon.Effects
{
    public class CrystalCannonDamageEffect : DealtDamageEffect
    {
        public Player player;

        public override void DealtDamage(Vector2 damage, bool selfDamage, Player damagedPlayer = null)
        {
            if (damagedPlayer == null || selfDamage)
            {
                UnityEngine.Debug.Log("Dealt Damage! Crystal");
                return;
            }

            UnityEngine.Debug.Log($"Dealt Damage to {damagedPlayer}! Crystal");

            var data = damagedPlayer.data;
            data.healthHandler.TakeDamage(new Vector2(data.maxHealth / 2, data.maxHealth / 2) * damage,
                data.transform.position, damagingPlayer:player);
        }
    }
}