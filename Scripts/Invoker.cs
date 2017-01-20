using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour {
    public GameObject instantiable;
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
            Instantiate(instantiable, GetComponent<Transform>().position, Quaternion.identity);
        }
    }
}
