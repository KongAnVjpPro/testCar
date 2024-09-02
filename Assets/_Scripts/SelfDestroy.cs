using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(this.destroy), 12f);
    }


    void destroy()
    {
        Destroy(gameObject);
    }
}
