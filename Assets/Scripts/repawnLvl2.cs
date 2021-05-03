using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repawnLvl2 : MonoBehaviour
{
    
    public float threshold;

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
            transform.position = new Vector3(-7.5f, -0.5f, 0);
    }
}
