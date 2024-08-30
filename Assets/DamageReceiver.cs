using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{

    [SerializeField] protected int hp = 10;
    void Awake()
    {

    }

    public virtual bool IsDead()
    {
        return this.hp <= 0;
    }
    public virtual void receiveDamage(int dmg)
    {
        this.hp -= dmg;
    }
}
