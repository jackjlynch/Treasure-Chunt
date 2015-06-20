using UnityEngine;
using System.Collections;

public class Boat : MonoBehaviour {
    Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(new Vector2(10, 0), ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
