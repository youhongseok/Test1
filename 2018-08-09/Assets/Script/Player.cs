using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}
public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public Boundary boundary;
    public GameObject shot;
    public Transform ShotSpawn;
    public float fireRate;
    private float nextFire;  
    //public int Score;
    //public Text ScoreText;
    public Bolt bolt;





    // Use this for initialization 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Score = 0;
        //SetScoreText();
        bolt = GetComponent<Bolt>();

    }
   
    
    
   

   
    private void Update()
    {


        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, ShotSpawn.transform.position, ShotSpawn.transform.rotation);
        }
    }
    private void FixedUpdate()
    {
        float dir1 = Input.GetAxis("Horizontal");
        float dir2 = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(dir1, 0, dir2) * speed;
        rb.position = new Vector3(Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
                                  0,
                                  Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
                                  );
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
          
            other.gameObject.SetActive(true);
            Destroy(gameObject);
            //Score = Score+1;
            //SetScoreText();
            
        }
    }
    //void SetScoreText()
    //{
    //    ScoreText.text = "Score:" + Score.ToString();
    //}

}
