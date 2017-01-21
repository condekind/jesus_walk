using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour {
    public GameObject shark;
    public GameObject blackSeagull;
    public GameObject whiteSeagull;
    public GameObject crazySeagull;
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
            // Performance friendly code here
            int rnd = Random.Range(0, 11);
            if (rnd >= 10)
                Instantiate(crazySeagull, GetComponent<Transform>().position, Quaternion.identity);
            else
                if (rnd >= 8)
                Instantiate(blackSeagull, GetComponent<Transform>().position, Quaternion.identity);
            else
                    if (rnd >= 6)
                Instantiate(whiteSeagull, GetComponent<Transform>().position, Quaternion.identity);
            else
                Instantiate(shark, GetComponent<Transform>().position, Quaternion.identity);
        }
    }
}
