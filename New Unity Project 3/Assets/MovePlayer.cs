using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	//This is the character controller component

	public CharacterController myCC;
	//Temp var of datatype vector3 to move the character
	private Vector3 tempPos;
	//Speed of the temp var in X
	public float speed = 1;
	public float gravity = 1;
	public float jumpSpeed =1;
	public int jumpCount = 0;
	public int jumpCountMax = 2;

	// Use this for initialization
	void Start () {
		//This finds the character controller component
		myCC = GetComponent<CharacterController> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		//waiting for input and comparing jumpcount


		if (Input.GetKeyDown (KeyCode.Space)&& jumpCount <= jumpCountMax) 
		{
			//incrementing the jumpcount by 1
			jumpCount++;
			//adding the jumpspeed var to the tempos var
			tempPos.y = jumpSpeed;

		}

		//test if the character controller is grounded
		if (myCC.isGrounded) {
			//reset the jumcout if grounded
			jumpCount=0;
		}
		//if(jumpCount > 1)
		//tempPos.y = jumpSpeed;
		//jumpCount++;

		tempPos.y -= gravity;
		//adding the speed var to the temppos var x value with the right and left keys

		tempPos.x = speed*Input.GetAxis("horizontal");
		//moves the character controller in at and even pace
		myCC.Move (tempPos * Time.deltaTime);

	
	}
}
