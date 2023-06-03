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
            if (GiantAnimationController.sayac <= 1 && GiantAnimationController.sayac != 0)
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
