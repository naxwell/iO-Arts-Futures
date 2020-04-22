using System.Collections;
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
        // vreate a raycast
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {  
            //Check if raycast hits a depthkit clip
            if(hit.collider.gameObject.tag == "depthClip"){
                //if yes, play said clip
                hit.collider.gameObject.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
            }
        }


    }
}
