using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

    CharacterController controller;
    private float verticalVelocity;
    [SerializeField] float gravity;
    [SerializeField] float jumpForce;
    
    void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	void Update () {
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
                verticalVelocity = jumpForce;
        }
        else verticalVelocity -= gravity * Time.deltaTime;

        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        controller.Move(moveVector * Time.deltaTime);
	}
}
