using UnityEngine;
using System.Collections;
using System;

public class NewBehaviourScript : MonoBehaviour {
	DateTime timeOfLastClick;
	TimeSpan desiredInterval;
	TimeSpan gracePeriod;
    Vector3 distance;
    Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
		timeOfLastClick = DateTime.Now;
		desiredInterval = new TimeSpan(0, 0, 0, 0, 500);
		gracePeriod = new TimeSpan(0, 0, 0, 0, 300);
		distance = new Vector3(1, 0);
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")) {
			TimeSpan difference = DateTime.Now.Subtract(timeOfLastClick);
			if(difference < desiredInterval + gracePeriod && difference > desiredInterval - gracePeriod) {
                //transform.position = transform.position + distance;
                rigidbody.AddForce(distance, ForceMode2D.Impulse);
				Debug.Log("triggered");
			}
			timeOfLastClick = DateTime.Now;
		}
	}
}