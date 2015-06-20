using UnityEngine;
using System.Collections;

public class BackgroundMover : MonoBehaviour {
    private bool flag;

	// Use this for initialization
	void Start () {
        flag = true; 
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!GetComponent<Renderer>().isVisible && !flag) {
            transform.position = new Vector2(transform.position.x + GetComponent<Renderer>().bounds.size.x * 2, transform.position.y);
            flag = true;
        }
        if (GetComponent<Renderer>().isVisible)
            flag = false;
	}
}
