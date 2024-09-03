using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] protected List<GameObject> enemies;
    protected int maxEnemy = 1;
    protected float timer = 0f;
    protected float timeDelay = 2f;
    [SerializeField] protected GameObject enemyPrefab;
    protected GameObject enemySpawnPos;

    void Awake()
    {
        this.enemySpawnPos = GameObject.Find("EnemySpawnPos");
        this.enemies = new List<GameObject>();
        this.enemyPrefab = GameObject.Find("EnemyPrefab");
        this.enemyPrefab.SetActive(false);
    }

    void Update()
    {
        this.Spawn();
        this.CheckDead();
    }

    protected virtual void Spawn()
    {
        if (PlayerCtrl.instance.damageReceiver.IsDead()) return;
        if (this.enemies.Count >= this.maxEnemy) return;

        this.timer += Time.deltaTime;
        if (this.timer < this.timeDelay) return;
        this.timer = 0;


        GameObject enemy = Instantiate(this.enemyPrefab);
        enemy.transform.position = enemySpawnPos.transform.position;
        enemy.SetActive(true);
        enemy.transform.parent = transform;
        this.enemies.Add(enemy);
    }

    void CheckDead()
    {
        GameObject enemy;
        for (int i = 0; i < this.enemies.Count; i++)
        {
            enemy = this.enemies[i];
            if (enemy == null) this.enemies.RemoveAt(i);
        }

    }
}
