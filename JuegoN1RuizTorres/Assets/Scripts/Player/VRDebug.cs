using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VRDebug : MonoBehaviour {
    Text text;
	void Start () {
        text.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        var rot = transform.rotation.eulerAngles;
        text.text = "X:" + rot.x + " Y:" + rot.y + " Z:" + rot.z;
	}
}
