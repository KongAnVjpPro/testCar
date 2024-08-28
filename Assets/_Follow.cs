using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class _Follow : MonoBehaviour
{
    public GameObject player;
    public float speed;
    void Start()
    {
        this.speed = 10f;
    }

    // Update is called once per frame
    // void Update()
    // {
    //     Vector3 localPosition = player.transform.position - transform.position;
    //     localPosition = localPosition.normalized; // The normalized direction in LOCAL space
    //     transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);
    // }
}
