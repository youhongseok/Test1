using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bolt : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.up * speed;
        
        
	}
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            
            other.gameObject.SetActive(false);
            Destroy(gameObject);
            
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
