using UnityEngine;
	using System.Collections;
	
	public float forceDuration = 0.1f;
	private bool canAddForce = true;
	private Rigidbody rigid;
	private float force = 10;
	public float forceRange =10;
	private Vector3 forceVector;
	private Vector3 torqueVector;
	
	void start()
	{
		rigid = GetComponent<Rigidbody> ();
		StartCoroutine (RunRandomForce ());
	}

	IEnumerator RunRandomForce()
	{
		force = Random.Range (-forceRage, forceRange);
		while(canAddForce)
		{
			yeild return new WaitForSeconds(forceDuration);
			forceVector.x = force;
			torqueVector.z = force/force;
			rigid.AddTorque(torqueVector);
			rigid.AddForce(forceVector);
		}
	}
	
	public float endTime =3;
	
	void OnCollisionEnter () {
		canAddForce = flase;
		Destroy(gameObject, endTime);
	}
	
}
