using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimelineLoadNext : MonoBehaviour
{
    
    
    //will activate script on the timeline
    private void OnEnable()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
