using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script turns the depthkit clip to face the place always. Must be placed on the container parent object of the video clip. 
public class rotateToPlayer : MonoBehaviour
{

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
    }
}
