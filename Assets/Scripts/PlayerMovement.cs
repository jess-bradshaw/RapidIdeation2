using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
	//-----Variables 
	private PlayerInputActions inputActions; 
	private Animator animator; 
	private Vector2 movementInput; 
	[SerializeField] private float moveSpeed = 10f; 
	private Vector3 inputDirection; 
	private Vector3 moveVector; 
	private Quaternion currentRotation; 
	private bool isWalking = false; 

	//-----Functions
	void Awake()
	{
		inputActions = new PlayerInputActions();
		inputActions.Player.Movement.performed += context => movementInput = context.ReadValue<Vector2>(); 
		animator = GetComponent<Animator>(); 
	}

	void FixedUpdate()
	{
		float h = movementInput.x; 
		float v = movementInput.y; 
		Vector3 targetInput = new Vector3(h, 0, v); //jump missing aka 0. 

		inputDirection = Vector3.Lerp(inputDirection, targetInput, Time.deltaTime *10f); 
		
		Vector3 camForward = Camera.main.transform.forward; 
		Vector3 camRight = Camera.main.transform.right; 
		camForward.y = 0f; 
		camRight.y = 0f; 

		Vector3 desiredDirection = camForward * inputDirection.z + camRight * inputDirection.x; 

		Move (desiredDirection); 
		Turn (desiredDirection);
		AnimateWalk (desiredDirection); 
	}

	void Move(Vector3 desiredDirection)
	{
		moveVector.Set(desiredDirection.x, 0f, desiredDirection.z);
		moveVector = moveVector * moveSpeed * Time.deltaTime; 
		transform.position += moveVector; 
	}

	void Turn(Vector3 desiredDirection)
	{
		if((desiredDirection.x >0.1 || desiredDirection.x < -0.1)|| (desiredDirection.z >0.1 || desiredDirection.z < -0.1))
		{
			currentRotation = Quaternion.LookRotation(desiredDirection);
			transform.rotation = currentRotation; 
		}
		else 
		transform.rotation = currentRotation; 
	}

	void AnimateWalk(Vector3 desiredDirection)
	{
		isWalking = (desiredDirection.x > 0.01f || desiredDirection.x < - 0.1f) || (desiredDirection.z >0.1f || desiredDirection.z <-0.1f) ? true : false; 
		animator.SetBool("isWalking", isWalking); 

	}
	private void OnEnable()
	{
		inputActions.Enable();
	}
	private void OnDisable()
	{
		inputActions.Disable();
	}
}