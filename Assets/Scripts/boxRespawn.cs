using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxRespawn : MonoBehaviour
{
    public float threshold;

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
            transform.position = new Vector3(53.13f, -0.34f, 0);
    }
}
