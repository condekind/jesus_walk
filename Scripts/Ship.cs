using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    private int lifes = 5;

    private GameControler gc;
    public GameObject explosion;
    // Use this for initialization
    void Start()
    {
        Vector2 jumpForceUp = new Vector2(-14.0f, 0.1f);
        this.GetComponent<Rigidbody2D>().AddForce(jumpForceUp, ForceMode2D.Impulse);

        gc = GameObject.Find("Invoker").GetComponent<GameControler>();
    }

    // Update is called once per frame
    void Update()
    {

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
