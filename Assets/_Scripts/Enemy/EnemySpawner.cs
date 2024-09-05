using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawner : Spawner
{

    private void Reset()
    {
        this.spawnPosName = "EnemySpawnPos";
        this.prefabName = "EnemyPrefab";
    }

    void Update()
    {
        this.Spawn();
        this.CheckDead();
    }



}
