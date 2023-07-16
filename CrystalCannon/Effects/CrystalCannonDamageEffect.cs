using UnityEngine;

namespace CrystalCannon.Effects
{
    public class CrystalCannonDamageEffect : DealtDamageEffect
    {
        public override void DealtDamage(Vector2 damage, bool selfDamage, Player damagedPlayer = null)
        {
            if (selfDamage || damagedPlayer == null || damagedPlayer.data.health <= 0)
            {
                return;
            }

            var data = damagedPlayer.data;
            data.healthHandler.TakeDamage(new Vector2(data.maxHealth / 2, data.maxHealth / 2),
                data.transform.position);
        }
    }
}