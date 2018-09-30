using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPC : IInput{
	public Vector2 GetDir(){
		Vector2 dir;
		dir.x = Input.GetAxis ("Horizontal");
		dir.y = Input.GetAxis ("Vertical");
		return dir;
	}
	public Vector3 GetRot(){
		Vector3 rot;
		rot.x = Input.GetAxis ("Mouse X");
		rot.y = Input.GetAxis ("Mouse Y");
		rot.z = 0;
		return rot;
	}
}