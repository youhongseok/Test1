using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpawnerCar : MonoBehaviour {
    public GameObject PrefebCar1;
    private float nextTime = 0.0f;
    public float spawnRate = 0.3f;
    public BackController road;
    private Player player;
	// Use this for initialization
	void Start () {
        road = GameObject.Find("Road").GetComponent<BackController>();
	}
	
	// Update is called once per frame
	void Update () {
		  if(nextTime<Time.time)
        {
            SpawnCar1();
            nextTime = Time.time + spawnRate;
        }
	}
   

    void SpawnCar1()
    {
        float addXPos = Random.Range(-road.roadWidth, road.roadWidth);
        Vector3 spawnPos = transform.position + new Vector3(addXPos, 0, 0);
        Instantiate(PrefebCar1, spawnPos, Quaternion.identity);
    }
}
