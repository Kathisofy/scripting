using UnityEngine;
using System.Collections;

public class clicktomove : MonoBehaviour {

	public float walkDistance = 10f;
	private NavMeshAgent navAgent;
	private Transform targetItem;
	private Ray clickRay;
	private RaycastHit clickHit;
	private bool walking;
	private bool itemClicked;

	// Use this for initialization
	void Awake() 
	{
		navAgent = GetComponent<NavMeshAgent> ();
	}


	void Update()
		{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Input.GetButtonDown ("Fire1")){
			if (Physics.Raycast(ray, out hit, 100))
			{
				if (hit.collider.CompareTag ("Item")) 
					{
					targetItem = hit.transform;
					itemClicked = true;
					}	 

				else 
					{ 
					walking = true;
					itemClicked = false;
					navAgent.destination = hit.point;
					navAgent.Resume();
					}
			}
		}
	}
}

