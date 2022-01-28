using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public GameObject self;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        self = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    // Update is called once per frame
    void Update()
    {
        applyMovement();
        handleAnimations();

    }

    void applyMovement()
    {
        float horizontalDelta = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float verticalDelta = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(horizontalDelta, 0, verticalDelta);

    }
    void handleAnimations()
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
