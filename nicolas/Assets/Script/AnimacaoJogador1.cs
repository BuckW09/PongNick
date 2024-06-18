using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoJogador1 : MonoBehaviour
{
    Animator anim;
    public bool AnimJ1;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AnimJ1 == true)
        {
            anim.SetBool("TOQUE", true);

        }
        if (AnimJ1 == false)
        {
            anim.SetBool("TOQUE", false);

        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bola"))
        {

            AnimJ1 = true;
        }
    }

    public void FimAnimacao()
    {
        AnimJ1 = false;
    }

}
