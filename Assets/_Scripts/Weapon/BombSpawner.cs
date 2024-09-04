using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : Spawner
{
    //[Header("Bomb")]
    // public List<GameObject> objects;

    // public GameObject spawnPos;
    // protected float spawnTimer = 0f;
    // protected float spawnDelay = 1f;
    void Start()
    {
        this.objects = new List<GameObject>();
        this.spawnPos = GameObject.Find("BombSpawnPos");
    }

    // Update is called once per frame
    void Update()
    {
        this.Spawn();
        this.CheckMinionDead();
    }
    void Awake()
    {
        this.objPrefab = GameObject.Find("Boom");
        this.objPrefab.SetActive(false);
    }
    void Spawn()
    {
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0;

        if (this.objects.Count >= 7) return;

        int index = this.objects.Count + 1;

        GameObject minion = Instantiate(this.objPrefab);
        minion.gameObject.SetActive(true);

        minion.transform.position = this.spawnPos.transform.position;
        minion.name = "minionPrefab#" + index;
        minion.transform.parent = transform;
        this.objects.Add(minion);

    }

    void CheckMinionDead()
    {
        GameObject minion;
        for (int i = 0; i < this.objects.Count; i++)
        {
            minion = this.objects[i];
            if (minion == null) this.objects.RemoveAt(i);
        }

    }
}
