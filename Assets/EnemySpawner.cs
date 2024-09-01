using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    protected float timer = 0f;
    protected float timeDelay = 2f;
    [SerializeField] protected GameObject enemyPrefab;

    void Awake()
    {
        this.enemyPrefab = GameObject.Find("EnemyPrefab");
        this.enemyPrefab.SetActive(false);
    }

    void Update()
    {
        Spawn();
    }

    protected virtual void Spawn()
    {
        if (PlayerCtrl.instance.damageReceiver.IsDead()) return;
        this.timer += Time.deltaTime;
        if (this.timer < this.timeDelay) return;
        this.timer = 0;


        GameObject enemy = Instantiate(this.enemyPrefab);
        enemy.transform.position = transform.position;
        enemy.SetActive(true);
    }
}
