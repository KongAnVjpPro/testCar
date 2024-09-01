using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReceiver : DamageReceiver
{
    protected PlayerCtrl playerCtrl;

    void Awake()
    {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }
    public override void receiveDamage(int dmg)
    {
        base.receiveDamage(dmg);
        if (this.IsDead())
        {
            UIManager.instance.bnGameOver.SetActive(true);
            this.playerCtrl.playerStatus.Dead();

        }
    }
}
