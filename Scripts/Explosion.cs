using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public float shakeAmount;
    private Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!AnimatorIsPlaying())
        {
            Destroy(this.gameObject);
        }

        float xShake = (float)Random.insideUnitSphere.x * shakeAmount;
        float yShake = (float)Random.insideUnitSphere.y * shakeAmount;
        Camera.main.transform.localPosition = new Vector3(xShake, yShake, -10);

    }

    bool AnimatorIsPlaying()
    {
        return animator.GetCurrentAnimatorStateInfo(0).length >
               animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
    }
}
