using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAndroid : IInput {
	public Vector2 GetDir(){
		Vector2 dir;
		dir.y = Input.GetAxis ("Horizontal") * -1;
		dir.x = Input.GetAxis ("Vertical");
		return dir;
	}
	public Vector3 GetRot(){
		Vector3 rot = Input.gyro.rotationRate;
		rot = new Vector3(rot.y *-1,rot.x,rot.z);
		return rot;
	}
}
