using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VersionText : MonoBehaviour {


	void Start () {
        var text = GetComponent<Text>();
        text.text = Application.version.ToString() + text.text;
        Destroy(this);
	}
}
