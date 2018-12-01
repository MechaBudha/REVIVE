using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class VRPlayerMovement : MonoBehaviour {
	private CharacterController charControl;
	[SerializeField] private float walkSpeed;
    [SerializeField] private Transform vrCamera;
    private InputManager inputMG;


	void Start () {
        charControl = GetComponent<CharacterController>();
        inputMG = InputManager.Instance;
	}
	
	void Update () {
        transform.rotation = Quaternion.Euler(transform.rotation.x, GvrVRHelpers.GetHeadRotation().y,transform.rotation.z);
        Quaternion normalizedCamRotation = Quaternion.Euler(0, vrCamera.rotation.eulerAngles.y, 0);


        var movement = (inputMG.GetDirection().y  * (normalizedCamRotation * Vector3.right).normalized + inputMG.GetDirection().x * -1 * (normalizedCamRotation * Vector3.forward).normalized) * walkSpeed;
        //Debug.Log(movement);
        movement.y = 0;
        charControl.Move(movement);

        if(inputMG.GetCameraReset()){ GvrCardboardHelpers.Recenter();}
	}

    
}
