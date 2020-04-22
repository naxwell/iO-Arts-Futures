using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

// This script pauses the Depthkit clip at the beginning of the experience. This ensures he correct clip is visible in the scene and prepares it to be played by one of the other interaction scripts
public class pauseAtStart : MonoBehaviour
{

    public VideoPlayer vp;


    // Start is called before the first frame update
    void Start()
    {
        //associates the connected videoplayer and runs the coroutine
        vp = GetComponent<VideoPlayer>();
        StartCoroutine(initPause());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
    // A coroutine is used in order to put in a slight pause, ensuring the clip has time to load correctly before pausing 
    IEnumerator initPause()
    {
        yield return new WaitForSeconds(1);
        vp.Pause();
    }
}
