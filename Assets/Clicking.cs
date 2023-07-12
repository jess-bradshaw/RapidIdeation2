using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicking : MonoBehaviour
{
    Renderer cubeRenderer; 
    Vector4 cHSV; 

    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = gameObject.GetComponent<Renderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            cHSV.x = Random.value;
            cHSV.y = 0.5f; 
            cHSV.z = 1f;
            cHSV.w = 1f; 
            cubeRenderer.material.SetColor("_Color", toRGB(cHSV)); 
            Debug.Log("was clicked"); 
        }
    }
    static Color toRGB(Vector4 v)
    {
        Color col = Color.HSVToRGB(v.x, v.y, v.z);
        return col;
    }
}
