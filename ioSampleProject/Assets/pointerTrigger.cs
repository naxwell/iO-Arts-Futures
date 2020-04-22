using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script casts ray out from the right controller on trigger press that will play any depthkit clips it connects with. 
public class pointerTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag == "depthClip")
                {
                    hit.collider.gameObject.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
                }
            }
        }
    }
}
