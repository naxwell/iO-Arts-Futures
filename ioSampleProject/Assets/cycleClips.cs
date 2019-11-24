using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class cycleClips : MonoBehaviour
{

    public VideoClip[] depthClips;
    public VideoPlayer vp;
    public int currentClip;
    // Start is called before the first frame update
    void Start()
    {
        vp = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            vp.Pause();
            if(currentClip < depthClips.Length)
            {
                currentClip++;
            }
            else
            {
                currentClip = 0;
            }

            vp.clip = depthClips[currentClip];
            vp.Play();
        }
    }
}
