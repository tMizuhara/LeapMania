using UnityEngine;
using System.Collections;

public class Taiko2Behavior : MonoBehaviour {
	
	public bool taiko2Flag;
	private const int maxCollisionCounter = 30;
	private int collisionCounter = maxCollisionCounter;
	
	// Use this for initialization
	void Start () {
		taiko2Flag = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(collisionCounter);
		if (taiko2Flag && collisionCounter > 0) {
			collisionCounter--;
		}
		if (collisionCounter == 0)
		{
			taiko2Flag = false;
			collisionCounter = maxCollisionCounter;
		}
	}
	
	void OnCollisionEnter(Collision other)
	{
		Debug.Log("TAIKO2 Collision!!");
		taiko2Flag = true;
	}
}

