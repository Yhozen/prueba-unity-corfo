using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rigidbody;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        applyMovement();

    }

    void applyMovement()
    {
        float horizontalDelta = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float verticalDelta = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(horizontalDelta, 0, verticalDelta);

    }

    private void OnCollisionEnter(Collision collison)
    {
        Debug.Log(collison.gameObject.tag);

    }
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.gameObject.tag);

    }
}
