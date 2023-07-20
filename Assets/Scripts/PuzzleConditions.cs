using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 
using UnityEngine.InputSystem.Interactions; 

public class PuzzleConditions : MonoBehaviour
{

	private Animator animator;  
	static public bool Roses; 
	static public bool Hometime; 
	static public bool FamilyTime; 
	static public bool FriendTime; 
	void Awake()
	{
		animator = GetComponent<Animator>(); 
	}

     private void OnTriggerStay(Collider other)
    {
     //SMELL FLOWERS   
	if (other.gameObject.tag == "Roses")
    { 
	if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Sit"))
		   { 
				Debug.Log("We really did it"); 
				Roses = true; 
				Debug.Log(Roses); 
				other.gameObject.SetActive(false); 
		   }
           
       }
	   //HANGOUT AT HOME
	if (other.gameObject.tag == "Home")
	   {if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Sit"))
		   { 
				Debug.Log("We really did it"); 
				Hometime = true; 
				Debug.Log(Hometime); 
				other.gameObject.SetActive(false); 
		   }
           
       }
	   //SPEND TIME WITH FAMILY 
	   if (other.gameObject.tag == "Family")
	   {
		   if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Jump"))
		   { 
				Debug.Log("We really did it"); 
				FamilyTime = true; 
				Debug.Log(FamilyTime); 
				other.gameObject.SetActive(false); 
		   }
           
       }
	     //SPEND TIME WITH Friend
	   if (other.gameObject.tag == "Friend")
	   {
		   if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Spin"))
		   { 
				Debug.Log("We really did it"); 
				FriendTime = true; 
				Debug.Log(FriendTime); 
				other.gameObject.SetActive(false); 
		   }
           
       }

	}
}
