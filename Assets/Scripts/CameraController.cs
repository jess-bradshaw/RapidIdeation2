using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// code from https://www.youtube.com/watch?v=ysV9ph0rRHM tutorial 
public class CameraController : MonoBehaviour
{
   Vector3 velocity; 
   public float smoothTimeZ;
   public float smoothTimeX; 
   public float offsetZ = -20f; 
   public GameObject player; 

   private Vector3 originPos; 
   private void Start()
   {
	   originPos = transform.position; 
   }

   void FixedUpdate()
   {
		float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX); 
		float posz = Mathf.SmoothDamp(transform.position.z, player.transform.position.z + offsetZ, ref velocity.z, smoothTimeZ); 
		transform.position = new Vector3(posX, transform.position.y, posz); 
   }
}
