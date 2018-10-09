using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour {

    [SerializeField] PauseMenu pauseMenuScript;

  	private HeadBob playerHB;
    private GameObject playerCamera;
    [SerializeField] private GameObject playerWeapon;
    [SerializeField] private AudioSource sound;
 	private GameObject player;

    void Start () {
        pauseMenuScript.OnPause.AddListener(DisablePlayer);
        pauseMenuScript.OnResume.AddListener(EnablePlayer);
		player = FindObjectOfType<GameManager> ().GetPlayer ();
		playerHB = player.GetComponentInChildren<HeadBob> ();
		playerCamera = player.GetComponentInChildren<Camera> ().gameObject;
    }
    void DisablePlayer()
    {
        player.GetComponent<PlayerMove>().enabled = false;
        playerHB.enabled = false;
        playerCamera.GetComponent<PlayerLook>().enabled = false;
        playerWeapon.GetComponent<Weapon>().enabled = false;

        sound.GetComponent<AudioSource>().enabled = false;
    }

    void EnablePlayer()
    {
        player.GetComponent<PlayerMove>().enabled = true;
        playerHB.GetComponent<HeadBob>().enabled = true;
        playerCamera.GetComponent<PlayerLook>().enabled = true;
        playerWeapon.GetComponent<Weapon>().enabled = true;

        sound.GetComponent<AudioSource>().enabled = true;
    }
}
