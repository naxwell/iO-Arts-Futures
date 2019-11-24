using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class pauseAtStart : MonoBehaviour
{

    public VideoPlayer vp;


    // Start is called before the first frame update
    void Start()
    {
        vp = GetComponent<VideoPlayer>();
        StartCoroutine(initPause());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
    
    IEnumerator initPause()
    {
        yield return new WaitForSeconds(1);
        vp.Pause();
    }
}
