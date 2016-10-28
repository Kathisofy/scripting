using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class recycleOobjects : MonoBehaviour {

	private Vector3 newLocation;

	public List<recycler> recycleableList;
	void Start ()
	{
		recycleableList = new List<recycler> ();
		recycler.RecycleAction += recycleActionHandler;
	}

	private void recycleActionHandler (recycler _r)
	{
		recycleableList.Add (_r);
	}

	void OnTriggerEnter ()
	{
		//newLocation.x =StaticVars.nextSectionPostion;
		//Transform.position = newLocation;
		//StaticVars.nestSectionPosition += StaticVars.distance;
	}
}