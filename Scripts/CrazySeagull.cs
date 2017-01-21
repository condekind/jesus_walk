using System.Collections.Generic;
using UnityEngine;

public class CrazySeagull : MonoBehaviour {
    private bool movement=false;

    private float jump = 0;

    private bool muerto = false;

    private int higherPos;
    
    private float forceYMicro;

    private float velocityX;

    public GameObject explosion;

    public GameControler gc; 
	// Use this for initialization
	void Start () {
	  velocityX = Random.Range(-2.5f, -1);
        higherPos = Random.Range(7, 9);

        jump = 0;

        gc = GameObject.Find("Invoker").GetComponent<GameControler>();
	}
	
	// Update is called once per frame
	void Update () {
		if (jump == 0)
        {
            jump = Time.time;
        }
        if (Time.time - jump > 1/70f)
        {
            movement = false;
            jump = 0;
        }
        if (!movement)
        {
            Vector2 forceX = new Vector2(velocityX, 0);
            this.GetComponent<Rigidbody2D>().AddForce(forceX);
            movement = true;
            if (muerto)
            {
                Vector2 force = new Vector2(0, 5f);
                this.GetComponent<Rigidbody2D>().AddForce(force);
            }
            else
            {
                if (gameObject.transform.position.y < higherPos)
                {
                    float dist = 8 - gameObject.transform.position.y;
                    Vector2 force = new Vector2(0, 0.6f*(dist*dist));
                    this.GetComponent<Rigidbody2D>().AddForce(force);
                }
                
            }
             
            
        }
        if (gameObject.transform.position.x < -19 || gameObject.transform.position.x > 19)
        {
            Destroy(gameObject);
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Halo")
        {

            gc.addPoint(1);
            Vector3 pos = new Vector3(collision.gameObject.GetComponent<Rigidbody2D>().position.x + Random.Range(-1.5f, 0.5f), GetComponent<Rigidbody2D>().position.y + Random.Range(-0.5f, 0.5f), -2.0f);
            Instantiate(explosion, pos, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}