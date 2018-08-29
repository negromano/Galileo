using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public CharacterController2D controller;
    public float speed = 80;
    private float horizontalMove;
    public Animator animator;
    bool jump;
	
	// Update is called once per frame
	void Update () {
        horizontalMove = Input.GetAxisRaw("Horizontal")*speed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if (Input.GetKey(KeyCode.W)) {
            jump = true;
        }
	}

    void FixedUpdate() {
        controller.Move(horizontalMove*Time.fixedDeltaTime,false, jump);
        animator.SetBool("Jump", jump);
        jump = false;
    }
}
