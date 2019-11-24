﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gazeToPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if(hit.collider.gameObject.tag == "depthClip"){
                hit.collider.gameObject.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
            }
        }


    }
}