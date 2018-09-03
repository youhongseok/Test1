using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {
    public float speed = 5.0f;
    public float deadHeight = -5.0f;
	// Use this for initialization
	void Start () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player")
        {
            gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < deadHeight)
        {
            Destroy(gameObject);
        }
	}
}
