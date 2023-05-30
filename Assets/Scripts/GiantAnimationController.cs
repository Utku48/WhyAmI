using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantAnimationController : MonoBehaviour
{

    Animator animator;
    public AudioSource askinOlayim;
    public AudioClip clip;
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            animator.SetBool("isDancing", true);
            askinOlayim.PlayOneShot(clip);



        }
        else
            animator.SetBool("isDancing", false);

    }
}
