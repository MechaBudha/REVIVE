using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InputManager : MonoBehaviour {
	private static InputManager instance = null;
	public static InputManager Instance{
		get{
			instance = FindObjectOfType<InputManager> ();
			if (instance == null){
				GameObject go = new GameObject ("InputManager");
				instance = go.AddComponent<InputManager> ();
			}
			return instance;
		}
	}

	IInput input;
	void Awake ()
	{
		if(instance != this){
			Destroy (gameObject);
		}
		#if UNITY_ANDROID
		input = new InputAndroid();
		if (!Input.gyro.enabled) {
		    Input.gyro.enabled = true;
		}
		#else
		input = new InputPC();
		#endif
	}
	public Vector2 GetDirection()
	{
		return input.GetDir ();
	}
	public Vector3 GetRotation(){
		return input.GetRot ();
	}
	public bool GetAction(){
        return input.GetAct ();
	}
	public bool GetFlash(){
		return input.GetFlash ();
	}
	public bool GetCameraReset(){
		return input.GetCamReset ();
	}
	public bool GetPause(){
		return input.GetPause ();
	}
}
