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

        //var movement = new Vector3(inputMG.GetDirection().y *-1, 0, inputMG.GetDirection().x) * walkSpeed;

        var movement = (inputMG.GetDirection().y  * vrCamera.right + inputMG.GetDirection().x * -1 * vrCamera.forward).normalized * walkSpeed;
        //Debug.Log(movement);
        charControl.Move(movement);

        if(inputMG.GetCameraReset()){ GvrCardboardHelpers.Recenter();}
	}

    
}
