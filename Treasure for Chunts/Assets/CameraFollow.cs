using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    GameObject boat;

	// Use this for initialization
	void Start () {
        boat = GameObject.Find("BOET");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(boat.transform.position.x, boat.transform.position.y, -10);
	}
}
