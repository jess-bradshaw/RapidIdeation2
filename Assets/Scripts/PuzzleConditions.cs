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
	static public bool completedLevel = false; 
	public GameObject hPart; 
	public GameObject famPart; 
	public GameObject friPart; 
	public GameObject floPart; 


	void Awake()
	{
		animator = GetComponent<Animator>(); 
	}
	void Update()
	{
		if (Roses == true && Hometime == true && FamilyTime == true && FriendTime == true)
		completedLevel = true; 
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
				floPart.gameObject.SetActive(true); 
		   }
           
       }
	   //HANGOUT AT HOME
	if (other.gameObject.tag == "Home")
	   {if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Eat"))
		   { 
				Debug.Log("We really did it"); 
				Hometime = true; 
				Debug.Log(Hometime); 
				other.gameObject.SetActive(false); 
				hPart.gameObject.SetActive(true); 
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
				famPart.gameObject.SetActive(true);
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
				friPart.gameObject.SetActive(true); 
		   }
           
       }

	}
}
