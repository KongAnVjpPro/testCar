using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyDamageSender : DamageSender
{
    [Header("Enemy")]
    // public int damage = 1;
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
    //     if (damageReceiver == null) return;

    //     damageReceiver.receiveDamage(this.damage);
    //     // this.enemyCtrl.despawner.Despawn();
    // }

    public EnemyCtrl enemyCtrl;
    protected void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    protected override void ColliderSendDamage(Collider2D collision)
    {
        base.ColliderSendDamage(collision);
        this.enemyCtrl.damageReceiver.receiveDamage(1);

    }
}
