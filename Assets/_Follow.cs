using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Follow : MonoBehaviour
{
    public Transform player;
    public float speed;
    public float distanceLimit;
    void Start()
    {
        this.speed = 10f;
        this.distanceLimit = 0.5f;
    }

    void Update()
    {
        Invoke(nameof(this.Follow), 3f);
    }

    void Follow()
    {
        Vector3 distance = this.player.position - transform.position;
        if (distance.magnitude >= this.distanceLimit)
        {
            Vector3 targetPoint = this.player.position - distance.normalized * this.distanceLimit;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPoint, this.speed * Time.deltaTime);

        }
    }
}
