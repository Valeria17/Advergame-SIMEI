using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovScript : MonoBehaviour
{

    public float speed = 4f;

    Animator anim;

    void Start()
    {

        anim = GetComponent<Animator>();

    }

    void Update()
    {

        Vector3 mov = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"),
            0
        );

        transform.position = Vector3.MoveTowards(
            transform.position,
            transform.position + mov,
            speed * Time.deltaTime
        );

        anim.SetFloat("MovX", mov.x);
        anim.SetFloat("MovY", mov.y);

    }

}
