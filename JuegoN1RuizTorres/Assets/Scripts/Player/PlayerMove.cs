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

		Vector3 moveDirSide = transform.worldToLocalMatrix.MultiplyVector (transform.right) * horiz * walkSpeed *-1;
		Vector3 moveDirForward = transform.worldToLocalMatrix.MultiplyVector (transform.forward) * vert * walkSpeed * -1;

        charControl.SimpleMove(moveDirSide);
        charControl.SimpleMove(moveDirForward);
    }
}
