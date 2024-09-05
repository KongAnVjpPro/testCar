using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BombDamageReceiver : DamageReceiver
{


    public override void receiveDamage(int dmg)
    {
        base.receiveDamage(dmg);
        if (this.IsDead())
        {
            Vector3 effectPos = transform.position;
            effectPos.z = -2;
            EffectManager.instance.SpawnVFX("Explosion_A", effectPos, transform.rotation);
            Destroy(gameObject);
        }
    }

}
