using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : Spawner
{

    private void Reset()
    {
        this.spawnPosName = "BombSpawnPos";
        this.prefabName = "Boom";
        this.maxObj = 17;
    }
    void Update()
    {
        this.Spawn();
        this.CheckDead();
    }



}
