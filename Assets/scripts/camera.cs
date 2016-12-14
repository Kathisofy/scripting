using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	public Transform target;
	
	void Update() {
		transform.LookAt(target);

	}
}
