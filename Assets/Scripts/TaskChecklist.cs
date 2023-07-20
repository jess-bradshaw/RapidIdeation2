using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskChecklist : MonoBehaviour
{
    // 
    public GameObject Family; 
    public GameObject Flowers; 
    public GameObject Friends; 
    public GameObject Home; 

    // Update is called once per frame
    void Update()
    {
        if (PuzzleConditions.Hometime == true)
        {
            Home.gameObject.SetActive(true); 
        }
         
        if (PuzzleConditions.FamilyTime == true)
        {
            Family.gameObject.SetActive(true); 
        } 
        
        if (PuzzleConditions.FriendTime == true)
        {
            Friends.gameObject.SetActive(true); 
        } 
        
        if (PuzzleConditions.Roses == true)
        {
            Flowers.gameObject.SetActive(true); 
        }
    }
}
