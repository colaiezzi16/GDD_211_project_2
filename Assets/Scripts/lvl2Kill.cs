using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2Kill : MonoBehaviour
{
    public GameObject player;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        player.transform.position = new Vector3(-7.5f, -0.5f, 0);
    }
}
