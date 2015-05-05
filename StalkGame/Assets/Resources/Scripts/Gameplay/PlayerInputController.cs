using UnityEngine;
using System.Collections;

public class PlayerInputController : MonoBehaviour {

	public bool crouching_state = false; 

	private void playerCrouching () {

		if (Input.GetButtonDown("Crouch")) {
			crouching_state = !crouching_state;

			if(crouching_state)
				Debug.Log("CROUCHING!");
			else 
				Debug.Log("NOT CROUCHING!"); 
		}



	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		playerCrouching ();
	
	}
}
