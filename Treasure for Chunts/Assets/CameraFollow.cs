using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject hans = GameObject.Find("hans");
        transform.position = new Vector3(hans.transform.position.x, hans.transform.position.y, -10);
	
	}
}
