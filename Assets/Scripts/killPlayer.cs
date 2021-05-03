using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer : MonoBehaviour
{
    public GameObject player;
   
    //on trigger when player hits collider resets player to start
    private void OnCollisionEnter2D(Collision2D collision)
    {
        player.transform.position = new Vector3(-7, -2, 0);
    }
}

