using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool isAndroid;
	private GameObject Player;
	[SerializeField] private GameObject PlayerPC;
	[SerializeField] private GameObject PlayerAndroid;
	[SerializeField] private Transform PlayerInitialPosition;

	public void Awake () {
		#if UNITY_ANDROID
		isAndroid = true;
		#else
		isAndroid = false;
		#endif
		if (isAndroid) {
			Player = Instantiate (PlayerAndroid);
			Debug.Log ("Android player instantiated");
		} else {
			Player = Instantiate (PlayerPC);
			Debug.Log ("PC player instantiated");
		}
		Player.transform.position = PlayerInitialPosition.position;
		Player.transform.rotation = PlayerInitialPosition.rotation;
	}

	public GameObject GetPlayer() {
		return Player;
	}
}
