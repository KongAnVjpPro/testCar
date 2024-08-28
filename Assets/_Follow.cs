using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Follow : MonoBehaviour
{
    public Transform player;
    public float speed;
    void Start()
    {
        this.speed = 10f;
    }

    void Update()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 distance = this.player.position - transform.position;
        if (distance.magnitude >= 0.5f)
        {
            Vector3 targetPoint = this.player.position - distance.normalized * 0.5f;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPoint, 15 * Time.deltaTime);

        }
    }
}
