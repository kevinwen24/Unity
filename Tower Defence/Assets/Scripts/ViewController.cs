using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour {

    public float speed = 1;
    public float mouseSpeed = 60;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float mouseScroll = Input.GetAxis("Mouse ScrollWheel");
        Debug.Log(mouseScroll);
        transform.Translate(new Vector3(h, mouseScroll * mouseSpeed, v) * Time.deltaTime * speed, Space.World );
	}
}
