using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateRockAnimator : MonoBehaviour
{
    public static Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("isTurning", true);
        }
        else
            anim.SetBool("isTurning", false);

    }
    void Update()
    {
    }


}
