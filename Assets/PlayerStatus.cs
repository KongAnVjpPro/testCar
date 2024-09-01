using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    protected PlayerCtrl playerCtrl;

    void Awake()
    {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }

    public virtual void Dead()
    {
        Debug.Log("Dead");
    }

}
