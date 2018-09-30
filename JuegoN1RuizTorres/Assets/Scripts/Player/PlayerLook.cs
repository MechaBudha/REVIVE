using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private Transform playerBody;
    [SerializeField] private float mouseSensitivity;
	private InputManager InputMg;
    private float xAxisClamp = 0.0f;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
		InputMg = InputManager.Instance;
    }

    void Update()
    {
		
        RotateCamera();
    }

    void RotateCamera()
    {
		Vector3 rot = InputMg.GetRotation ();

		float rotAmountX = rot.x * mouseSensitivity;
		float rotAmountY = rot.y * mouseSensitivity;
		float rotAmountZ = rot.z;

        xAxisClamp -= rotAmountY;

        Vector3 targetRotCam = transform.rotation.eulerAngles;
        Vector3 targetRotBody = playerBody.rotation.eulerAngles;

        targetRotCam.x -= rotAmountY;
        targetRotCam.z += rotAmountZ;
        targetRotBody.y += rotAmountX;

        if (xAxisClamp > 90)
        {
            xAxisClamp = 90;
            targetRotCam.x = 90;
        }
        else if (xAxisClamp < -90)
        {
            xAxisClamp = -90;
            targetRotCam.x = 270;
        }

        transform.rotation = Quaternion.Euler(targetRotCam);
        playerBody.rotation = Quaternion.Euler(targetRotBody);
    }
}
