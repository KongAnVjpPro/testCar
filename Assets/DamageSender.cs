using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    [SerializeField] protected EnemyCtrl enemyCtrl;
    protected void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        damageReceiver.receiveDamage(1);
        this.enemyCtrl.despawner.Despawn();
    }
}
