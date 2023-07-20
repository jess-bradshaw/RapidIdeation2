using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class TriggeredCollider : MonoBehaviour
{
    public Material colourful; 
    public Material OGmaterial;
    private bool friendNear = false; 
    public Animator animator; 
    public bool restored = false; 
    //public PuzzleConditions puzzleConditions;  
    
    private void OnTriggerEnter(Collider other)
    {
       if (this.gameObject.tag == "Animal") //check to see if it's an amimal
       { 
            GetComponent<SkinnedMeshRenderer>().material = colourful;    
            friendNear = true; 
            animator.SetBool("friendNear", friendNear);
       }
           
       else 
       {   
            GetComponent<MeshRenderer>().material = colourful; 
       }
    }
    
    private void OnTriggerExit(Collider other)
    {
       if (this.gameObject.tag == "Animal") //check to see if it's an animal
       { 
            if (PuzzleConditions.FamilyTime == true)
            { //doesn't repalce material/stop animation
            }
            else if (PuzzleConditions.FriendTime == true)
            {}
            else 
            {
                GetComponent<SkinnedMeshRenderer>().material = OGmaterial;
                friendNear = false; 
                animator.SetBool("friendNear", friendNear);
            }
            
            
       }
       else if(this.gameObject.tag == "Flower" && PuzzleConditions.Roses == true) //check to see if it's a flower
       { 
           GetComponent<MeshRenderer>().material = colourful;
           Debug.Log("Flowers"); 
           restored = true; 
        }
        else 
        {
             GetComponent<MeshRenderer>().material = OGmaterial; 
            // Debug.Log("exited"); 
        }
    }
}
