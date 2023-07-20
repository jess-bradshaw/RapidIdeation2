using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class TriggeredCollider : MonoBehaviour
{
    public Material colourful; 
    public Material OGmaterial;
    private bool friendNear = false; 
    public Animator animator; 
    //public PuzzleConditions puzzleConditions;  
    
    void Update() 
    {
        if (PuzzleConditions.completedLevel == true)
        {
            if (this.gameObject.tag == "Animal") //check to see if it's an amimal
            { 
                 GetComponent<SkinnedMeshRenderer>().material = colourful;    
            }
            else 
            {
                 GetComponent<MeshRenderer>().material = colourful;
            }
        }
    }
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
            {
            }
            else if (PuzzleConditions.FriendTime == true)
            { 
                animator.SetBool("complete", true);
            }
            else 
            {
                GetComponent<SkinnedMeshRenderer>().material = OGmaterial;
                friendNear = false; 
                animator.SetBool("friendNear", friendNear);
            }
            
            
       }
       //check to see if it's a flower or home
       else if((this.gameObject.tag == "Flower" && PuzzleConditions.Roses == true) || (this.gameObject.tag == "Birdhouse" && PuzzleConditions.Hometime == true)) 
        { 
           GetComponent<MeshRenderer>().material = colourful;
           Debug.Log("Flowers"); 
        }
        else 
        {
             GetComponent<MeshRenderer>().material = OGmaterial; 
            // Debug.Log("exited"); 
        }
    }
}
