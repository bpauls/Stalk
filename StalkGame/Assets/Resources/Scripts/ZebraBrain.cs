using UnityEngine;
using System.Collections;

public class ZebraBrain : MonoBehaviour {

	public class ZebraInfo {
		public float max_food; //Maximum amount of grass the Zebra can eat  
		public int life_stage; //Current life stage of the Zebra: 0 = Foal, 1 = Teen, 2 = Adult, 3 = Elder;
		public bool flee_state; //State of running/spooked by lion
		public bool eat_state;  //State of munching on grass
		public bool search_state;  //State of onguard for lions/predators 

		public ZebraInfo (float mfood, int lstage, bool fstate, bool estate, bool sstate){
			max_food = mfood;
			life_stage = lstage;
			flee_state = fstate; 
			eat_state = estate;
			search_state = sstate; 
		}

	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
