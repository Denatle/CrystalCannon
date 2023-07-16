using UnityEngine;

namespace CrystalCannon.Effects
{
    public class CrystalCannonWasDamagedEffect : WasDealtDamageEffect
    {
        public Player player;

        public override void WasDealtDamage(Vector2 damage, bool selfDamage)
        {
            var data = player.data;
            if (player.data.health <= 0)
            {
                return;
            }

            data.healthHandler.TakeDamage(new Vector2(data.maxHealth, data.maxHealth) * damage,
                data.transform.position);
        }
    }
}