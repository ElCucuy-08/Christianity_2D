using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    float hor;
    Vector3 size/*, inversize*/;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        size  = transform.localScale;
        //inversize.x *= -1;
    }

    private void Update()
    {
        hor = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.transform.Translate(Vector2.right * Time.fixedDeltaTime * 5 * hor);
        //DoAnim();
    }
    //void DoAnim()
    //{
    //    if (hor > 0)
    //    {
    //        transform.localScale = size;
    //    }
    //    else if (hor < 0)
    //    {
    //        transform.localScale = inversize;
    //    }
       
    //}
}
