using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlStartUp : MonoBehaviour {
	[SerializeField] Transform InitialTransform;
	[SerializeField] GameObject PcPlayer;
	[SerializeField] GameObject VrmPlayer;
	private GameObject Player;
	private bool IsAndroid;

	void Awake(){
		#if UNITY_ANDROID
		IsAndroid = true;
		#else
		IsAndroid = false;
		#endif
		if (IsAndroid) {
			Player = Instantiate (VrmPlayer);
			Debug.Log ("Android player instantiated");
		} else {
			Player = Instantiate (PcPlayer);
			Debug.Log ("PC player instantiated");
		}
		Player.transform.position = InitialTransform.position;
		Player.transform.rotation = InitialTransform.rotation;
	}

	void Start(){
		Disable D = FindObjectOfType<Disable> ();
		if (D != null) {D.SetPlayer (Player);}
	}

	void OnDestroy(){
		Destroy (Player);
	}
}
