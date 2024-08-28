using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(this.destroy), 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void destroy()
    {
        Destroy(gameObject);
    }
}
