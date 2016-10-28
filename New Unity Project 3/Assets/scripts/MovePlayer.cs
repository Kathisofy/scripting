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
	//sliding vars
	public int slideDuration= 20;
	public float slideTime= 0.01f;
	//corutine for the slide
	IEnumerator Slide()
	{
		//just kidding, I did it.  we set a temp var to the value of slide duration
		int durationTemp = slideDuration;
		float speedTemp= speed;
		speed += speed;
		//then while loop runs while the slide duration is greater than 0
			while(slideDuration> 0)
		{
			//decrement the slideduration
			slideDuration --;
			//yield holds the coroutine
			//return tells the corutine to do an operation while yeilding
			//new creates an instance of an object
			//wait for seconds is an object
			yield return new WaitForSeconds(slideTime);

		}
		speed = speedTemp;
		slideDuration = durationTemp;

	}




	// Use this for initialization
	void Start () {
		//This finds the character controller component
		myCC = GetComponent<CharacterController> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		//waiting for input and comparing jumpcount


		if (Input.GetKeyDown (KeyCode.Space)&& jumpCount <= jumpCountMax-1) 
		{
			//incrementing the jumpcount by 1
			jumpCount++;
			//adding the jumpspeed var to the tempos var
			tempPos.y = jumpSpeed;

		}
		//start sliding
		if (Input.GetKey (KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S)) 
		{
			//startcorutine calls it from above, don't forget to add it in so it can call it
			StartCoroutine(Slide());
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

		tempPos.x = speed*Input.GetAxis("Horizontal");
		//moves the character controller in at and even pace
		myCC.Move (tempPos * Time.deltaTime);

	
	}
}
