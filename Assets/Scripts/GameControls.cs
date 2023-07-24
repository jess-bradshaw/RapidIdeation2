using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Access to scenes to load. 

public class GameControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
       {
           Application.Quit(); 
           Debug.Log("Quit!"); 
       }
    }
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1); 
    }

}
