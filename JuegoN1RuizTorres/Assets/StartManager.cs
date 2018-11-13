using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour {

    [HeaderAttribute ("PC prefabs")] 
	[SerializeField] GameObject PCCanvas;
    [SerializeField] GameObject PCCamera;

    [HeaderAttribute("VR prefabs")]
    [SerializeField] GameObject VRCanvas;
    [SerializeField] GameObject VRPlayer;

    private bool isAndroid;
    
	void Start () {

#if UNITY_ANDROID
        isAndroid = true;
#else
        isAndroid = false;
#endif

        PCCanvas.SetActive(!isAndroid);
        PCCamera.SetActive(!isAndroid);

        VRCanvas.SetActive(isAndroid);
        VRPlayer.SetActive(isAndroid);

    }
}
