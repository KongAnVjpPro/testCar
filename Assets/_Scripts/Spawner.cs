using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawner")]
    public GameObject objPrefab;
    public List<GameObject> objects;
    public GameObject spawnPos;
    public float spawnDelay = 1f;
    public float spawnTimer = 0f;
}
