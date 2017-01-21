using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour {
    public GameObject shark;
    public GameObject blackSeagull;
    public GameObject whiteSeagull;
    public GameObject crazySeagull;
    public GameObject bible;
    public GameObject ship;

    public float period;
    float TimeInterval = 0.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TimeInterval += Time.deltaTime;
        if (TimeInterval >= 1 + Random.Range(0.2f, 1))
        {
            TimeInterval = 0;
            Vector3 savePosition = new Vector3(GetComponent<Transform>().position.x - 2, GetComponent<Transform>().position.y + 1, -1.6f);
            // Performance friendly code here
            int rnd = Random.Range(0, 14);
            if (rnd >= 12)
                Instantiate(ship, savePosition, Quaternion.identity);
            if (rnd >= 11)
                Instantiate(crazySeagull, GetComponent<Transform>().position, Quaternion.identity);
            else
                if (rnd >= 10)
                Instantiate(bible, GetComponent<Transform>().position, Quaternion.identity);
            else
                    if (rnd >= 8)
                Instantiate(whiteSeagull, GetComponent<Transform>().position, Quaternion.identity);
            else
                        if (rnd >= 6)
                Instantiate(blackSeagull, GetComponent<Transform>().position, Quaternion.identity);
            else if (rnd >= 4)
                Instantiate(shark, GetComponent<Transform>().position, Quaternion.identity);
        }
    }
}
