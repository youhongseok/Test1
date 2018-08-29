using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackController : MonoBehaviour {
    public float speed = 0.5f;
    public float x = 0.0f;
    public float y = 0.0f;
    public float roadWidth = 6.0f;
    public float roadHeight = 8.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        y += Time.deltaTime * speed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, -y);
	}
}
