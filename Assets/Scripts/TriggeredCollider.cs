using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class TriggeredCollider : MonoBehaviour
{
    public Material colourful; 
    public Material OGmaterial;
    private bool friendNear = false; 
    public Animator animator; 
    
    private void OnTriggerEnter(Collider other)
    {
       if (this.gameObject.tag == "Animal")
       { 
       GetComponent<SkinnedMeshRenderer>().material = colourful;    
       friendNear = true; 
       animator.SetBool("friendNear", friendNear);
      // Debug.Log("FRIEND"+ friendNear); 
       }
           
       else 
       {   
            GetComponent<MeshRenderer>().material = colourful; 
          //  Debug.Log("collided"); 
       }
    }
      private void OnTriggerExit(Collider other)
    {
       if (this.gameObject.tag == "Animal")
            { 
            GetComponent<SkinnedMeshRenderer>().material = OGmaterial;
            friendNear = false; 
            animator.SetBool("friendNear", friendNear);
           // Debug.Log("FRIEND gone"+ friendNear); 
            }
        else 
        {
             GetComponent<MeshRenderer>().material = OGmaterial; 
            // Debug.Log("exited"); 
        }
    }
}
