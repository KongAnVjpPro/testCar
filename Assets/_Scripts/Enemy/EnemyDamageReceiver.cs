using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyDamageReceiver : DamageReceiver
{

    [Header("Enemy")]
    public EnemyCtrl enemyCtrl;

    void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }
    private void Reset()
    {
        this.hp = 3;
    }

    public override void receiveDamage(int dmg)
    {
        base.receiveDamage(dmg);
        if (this.IsDead())
        {
            Vector3 effectPos = transform.position;
            effectPos.z = -2;
            EffectManager.instance.SpawnVFX("Explosion_B", effectPos, transform.rotation);
            this.enemyCtrl.despawner.Despawn();

        }
    }
}
