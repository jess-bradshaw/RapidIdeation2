using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class TriggeredCollider : MonoBehaviour
{
    public Material colourful; 
    public Material OGmaterial;
    
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().material = colourful; 
        Debug.Log("collided"); 
    }
      private void OnTriggerExit(Collider other)
    {
        GetComponent<MeshRenderer>().material = OGmaterial; 
        Debug.Log("exited"); 
    }
}
