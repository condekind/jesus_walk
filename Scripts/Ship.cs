using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    private int lifes = 5;

    private GameControler gc;
    public GameObject explosion;
    public float period;
    float TimeInterval = 0.0f;

    public GameObject rocket;
    // Use this for initialization
    void Start()
    {
        Vector2 jumpForceUp = new Vector2(-11.0f, 0.0f);
        this.GetComponent<Rigidbody2D>().AddForce(jumpForceUp, ForceMode2D.Impulse);

        gc = GameObject.Find("Invoker").GetComponent<GameControler>();
    }

    // Update is called once per frame
    void Update()
    {
        TimeInterval += Time.deltaTime;
        if (TimeInterval >= period)
        {
            TimeInterval = 0;
            Vector3 betterPosition = new Vector3(gameObject.GetComponent<Transform>().position.x, gameObject.GetComponent<Transform>().position.y - 0.5f, gameObject.GetComponent<Transform>().position.z);
            Instantiate(rocket, betterPosition,  Quaternion.Euler(new Vector3(0, 0, 90)));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Halo")
        {
            Vector3 pos = new Vector3(collision.gameObject.GetComponent<Rigidbody2D>().position.x + Random.Range(-1.5f, 0.5f), GetComponent<Rigidbody2D>().position.y + Random.Range(-0.5f, 0.5f), -2.0f);
            Instantiate(explosion, pos, Quaternion.identity);

            lifes--;
            if (lifes == 0)
            {
                gc.addPoint(2);
                Destroy(this.gameObject);
            }
        }
    }
}
