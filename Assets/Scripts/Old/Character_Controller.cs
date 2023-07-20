using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

[RequireComponent(typeof(CharacterController))]

public class Character_Controller : MonoBehaviour
{ //-----Variables-----//
   private Vector2 _input;
   private CharacterController _characterController; 
  //Movement
   private Vector3 _direction; 
   private float _currentVelocity;
  [SerializeField] private float speed; 
  //Animations
   private bool isWalking = false; 
   private Animator _animator; 
   
   //-----Functions-----//
    private void Awake()
   {
       _characterController = GetComponent<CharacterController>();
       _animator = GetComponent<Animator>(); 
   }

   private void Update()
   {//Location
        _characterController.Move(_direction * speed * Time.deltaTime ); 
   }
   
   public void Walk(Vector3 _direction)
   { //Animation for Walking
        isWalking = (_direction.x > 0.1f || _direction.x > -0.1f) || (_direction.z > 0.1f || _direction.z > -0.1f) ? true : false; 
        _animator.SetBool("isWalking", isWalking); 
   }
  
   public void Move(InputAction.CallbackContext context)
   {//Movement 
    _input = context.ReadValue<Vector2>();     
    _direction = new Vector3 (_input.x, 0.0f, _input.y);
    Walk(_direction); 
    Debug.Log("pressed"); 
    }

   
}

