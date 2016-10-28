using UnityEngine;
using System.Collections;
using System;

public class recycler : MonoBehaviour {

	public static Action<recycler> RecycleAction;
	public bool canBeRecycled;
	public Transform cube;

	// Use this for initialization
	void Start () {
		cube = this.GetComponent<Transform> ();
		if (RecycleAction != null && canBeRecycled)
			RecycleAction (this);
	}
	void OnTriggerEnter ()
	{
		canBeRecycled = true;
		Start ();
	}

}
