using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class elevatorTrig1 : MonoBehaviour
{
    //loads scene when player walks into elevator trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("IceLevel");
    }
}
