using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawner : Spawner
{
    [Header("Enemy")]
    // public List<GameObject> objects;
    protected int maxEnemy = 1;
    // protected float spawnTimer = 0f;
    // protected float spawnDelay = 2f;
    // public GameObject objPrefab;
    // protected GameObject spawnPos;

    void Awake()
    {
        this.spawnPos = GameObject.Find("EnemySpawnPos");
        this.objects = new List<GameObject>();
        this.objPrefab = GameObject.Find("EnemyPrefab");
        this.objPrefab.SetActive(false);
    }

    void Update()
    {
        this.Spawn();
        this.CheckDead();
    }

    protected virtual void Spawn()
    {
        if (PlayerCtrl.instance.damageReceiver.IsDead()) return;
        if (this.objects.Count >= this.maxEnemy) return;

        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0;


        GameObject enemy = Instantiate(this.objPrefab);
        enemy.transform.position = spawnPos.transform.position;
        enemy.SetActive(true);
        enemy.transform.parent = transform;
        this.objects.Add(enemy);
    }

    void CheckDead()
    {
        GameObject enemy;
        for (int i = 0; i < this.objects.Count; i++)
        {
            enemy = this.objects[i];
            if (enemy == null) this.objects.RemoveAt(i);
        }

    }
}
