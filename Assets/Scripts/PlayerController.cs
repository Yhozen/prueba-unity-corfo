using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B))
        {
            anim.SetTrigger("dance");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("walking", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("walking", false);
        }
    }
}
