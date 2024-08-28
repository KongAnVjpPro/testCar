using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    List<GameObject> minions;
    public GameObject minionPrefab;
    void Start()
    {
        this.minions = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    void Spawn()
    {

        if (this.minions.Count >= 7) return;

        int index = this.minions.Count + 1;

        GameObject minion = Instantiate(this.minionPrefab);
        minion.SetActive(true);
        minion.name = "minionPrefab#" + index;
        this.minions.Add(minion);
    }
}
