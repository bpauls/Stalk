using UnityEngine;
using System.Collections;

public class ZebraMovement : MonoBehaviour {

	public GameObject player;
	public float movespeed = 10f; // Base speed is 10f
	public int comfydist = 20;//Base distance is 20


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		ZebraFlee (); 
		
	}

	public void ZebraFlee(){

		float dist = Vector3.Distance(player.transform.position, transform.position); 
		if (dist < comfydist) {
						transform.Translate (Vector3.forward * movespeed * Time.deltaTime, Space.World);
						//transform. Translate (Vector3.left * movespeed * Time.deltaTime, Space.World);
				}
		Debug.Log ("Current Distance = "+ dist); 
	}



}
