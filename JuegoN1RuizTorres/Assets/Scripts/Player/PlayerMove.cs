using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController charControl;
    public float walkSpeed;
	private InputManager inputMg;

    void Awake()
    {
        charControl = GetComponent<CharacterController>();
		inputMg = InputManager.Instance;
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
		Vector2 move = inputMg.GetDirection ();
		float horiz = move.x;
		float vert = move.y;

		Vector3 moveDirSide = transform.right * horiz * walkSpeed;
		Vector3 moveDirForward = transform.forward * vert * walkSpeed;

        charControl.SimpleMove(moveDirSide + moveDirForward);
    }
}
