using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = .1f;
    public float jumpHeight = .05f;
    public float smoothing = 0.1f;
    public Transform target;


	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void FixedUpdate ()
    {
        Move();

    }

    void Move()
    {
        bool horizontalPress = Input.GetButton("Horizontal");
        bool verticalPress = Input.GetButton("Vertical");
        bool jumpPress = Input.GetButtonDown("Jump");
        bool jumpLongPress = Input.GetButton("Jump");
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        if (horizontalPress)
        {
            transform.Translate(speed * horizontal, 0, 0);
        }

        if (verticalPress)
        {
            transform.Translate(0, 0, speed * vertical);
        }

        if (jumpPress)
        {
            transform.Translate(0, jumpHeight, 0);
            //StartCoroutine(JumpCoroutine(target));
        }
    }

    /*IEnumerator JumpCoroutine (Transform target)
    {
        while(Vector3.Distance(transform.position, target.position) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);

            yield return null;
        }
    }*/
}
