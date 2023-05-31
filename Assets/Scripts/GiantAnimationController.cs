using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantAnimationController : MonoBehaviour
{

    public static Animator animator;
    public AudioSource askinOlayim;
    public AudioClip clip;
    float sayac = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            animator.SetBool("isDancing", true);
            sayac++;
            if (sayac > 0 && sayac <= 1)
            {
                askinOlayim.PlayOneShot(clip);
            }

        }
        else
            animator.SetBool("isDancing", false);

    }
}
