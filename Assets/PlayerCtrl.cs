using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public static PlayerCtrl instance;
    public DamageReceiver damageReceiver;
    public PlayerStatus playerStatus;
    void Awake()
    {
        PlayerCtrl.instance = this;
        this.damageReceiver = GetComponent<DamageReceiver>();
        this.playerStatus = GetComponent<PlayerStatus>();
    }

}