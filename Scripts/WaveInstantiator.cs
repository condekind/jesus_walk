using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveInstantiator : MonoBehaviour {
    public GameObject wave1;
    public GameObject wave2;
    public GameObject wave3;

    public float period;
    float TimeInterval = 0.0f;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        TimeInterval += Time.deltaTime;
        if (TimeInterval >= period)
        {
            TimeInterval = 0;
            Vector3 savePosition = new Vector3(GetComponent<Transform>().position.x - 2, GetComponent<Transform>().position.y + 1.27f, GetComponent<Transform>().position.z);
            int rnd = Random.Range(0, 4);
            if (rnd >= 3)
                Instantiate(wave1, savePosition, Quaternion.identity);
            else if (rnd >= 2)
                Instantiate(wave2, savePosition, Quaternion.identity);
            else
                Instantiate(wave3, savePosition, Quaternion.identity);
        }
    }
}
