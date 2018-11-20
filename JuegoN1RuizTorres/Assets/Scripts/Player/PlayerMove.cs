using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController charControl;
    public float walkSpeed;
	private InputManager InputMg;

    void Awake()
    {
        charControl = GetComponent<CharacterController>();
		InputMg = InputManager.Instance;
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
		Vector2 move = InputMg.GetDirection ();
		float horiz = move.x;
		float vert = move.y;

		Vector3 moveDirSide = transform.forward * horiz * walkSpeed;
		Vector3 moveDirForward = transform.forward * vert * walkSpeed;

        charControl.SimpleMove(moveDirSide + moveDirForward);
    }
}
