using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveInstantiator : MonoBehaviour {
    public GameObject wave1;
    public GameObject wave2;
    public GameObject wave3;

    public float period;
    float TimeInterval = 0.0f;

    public float yPos = 0.0f;
    private int rnd;
	// Use this for initialization
	void Start () {
        Random.seed = (int)System.DateTime.Now.Ticks;
        this.rnd = Random.Range(0, 4);
		
	}

    // Update is called once per frame
    void Update()
    {
        TimeInterval += Time.deltaTime;
        if (TimeInterval >= period)
        {
            TimeInterval = 0;
            Vector3 savePosition = new Vector3(GetComponent<Transform>().position.x - 2, GetComponent<Transform>().position.y + yPos, GetComponent<Transform>().position.z);

            if (this.rnd >= 3)
            {
                Instantiate(wave1, savePosition, Quaternion.identity);
                this.wave1.GetComponent<Animator>().speed = 5.0f;
            }
            else if (this.rnd >= 2)
                Instantiate(wave2, savePosition, Quaternion.identity);
            else
                Instantiate(wave3, savePosition, Quaternion.identity);
        }
    }
}
