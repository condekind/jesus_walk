using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour {
      private bool movement=false;

    private float jump = 0;

    private bool muerto = false;

    private float higherPos;
    
    private float velocityX;

	// Use this for initialization
	void Start () {
		 velocityX = 4.5f;
        higherPos =  0.5f;

        jump = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 jumpForceUp = new Vector2 (-0.2f, 0);
		this.GetComponent<Rigidbody2D> ().AddForce (jumpForceUp, ForceMode2D.Impulse);

        //Here starts the spring
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

            if (gameObject.transform.position.y < higherPos)
            {
                float dist = 8 - gameObject.transform.position.y;
                Vector2 force = new Vector2(0, 0.045f * dist);
                this.GetComponent<Rigidbody2D>().AddForce(force);
            }

        }
        //Here ends the spring

        if (gameObject.transform.position.x < -19 || gameObject.transform.position.x > 19)
        {
            Destroy(gameObject);
        }
	}
    }
