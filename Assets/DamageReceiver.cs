using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{

    [SerializeField] protected int hp = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public virtual void receiveDamage(int dmg)
    {
        this.hp -= dmg;
    }
}
