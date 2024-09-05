using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    // [SerializeField] protected EnemyCtrl enemyCtrl;
    // protected void Awake()
    // {
    //     this.enemyCtrl = GetComponent<EnemyCtrl>();
    // }
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
    //     if (damageReceiver == null) return;

    //     damageReceiver.receiveDamage(1);
    //     this.enemyCtrl.despawner.Despawn();
    // }
    [Header("DamageSender")]
    public int damage = 1;
    protected virtual void ColliderSendDamage(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        if (damageReceiver == null) return;

        damageReceiver.receiveDamage(this.damage);
        // this.enemyCtrl.despawner.Despawn();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.ColliderSendDamage(collision);
    }
}
