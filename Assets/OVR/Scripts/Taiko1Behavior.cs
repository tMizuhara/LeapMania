using UnityEngine;
using System.Collections;

public class Taiko1Behavior : MonoBehaviour {
	
	public bool taiko1Flag;
	private const int maxCollisionCounter = 30;
	private int collisionCounter = maxCollisionCounter;
	
	// Use this for initialization
	void Start () {
		taiko1Flag = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(collisionCounter);
		if (taiko1Flag && collisionCounter > 0) {
			collisionCounter--;
		}
		if (collisionCounter == 0)
		{
			taiko1Flag = false;
			collisionCounter = maxCollisionCounter;
		}
	}
	
	void OnCollisionEnter(Collision other)
	{
		Debug.Log("TAIKO1 Collision!!");
		taiko1Flag = true;
	}
}
