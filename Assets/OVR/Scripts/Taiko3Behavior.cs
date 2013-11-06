using UnityEngine;
using System.Collections;

public class Taiko3Behavior : MonoBehaviour {
	
	public bool taiko3Flag;
	private const int maxCollisionCounter = 30;
	private int collisionCounter = maxCollisionCounter;
	
	// Use this for initialization
	void Start () {
		taiko3Flag = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(collisionCounter);
		if (taiko3Flag && collisionCounter > 0) {
			collisionCounter--;
		}
		if (collisionCounter == 0)
		{
			taiko3Flag = false;
			collisionCounter = maxCollisionCounter;
		}
	}
	
	void OnCollisionEnter(Collision other)
	{
		Debug.Log("TAIKO3 Collision!!");
		taiko3Flag = true;
	}
}

