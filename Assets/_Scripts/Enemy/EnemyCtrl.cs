using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public Despawner despawner;
    void Awake()
    {
        this.despawner = GetComponent<Despawner>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
