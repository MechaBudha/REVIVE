using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour {

    [SerializeField] PauseMenu pauseMenuScript;

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject playerHB;
    [SerializeField] private GameObject playerCamera;
    [SerializeField] private GameObject playerWeapon;
    [SerializeField] private AudioSource sound;

    void Start () {
        pauseMenuScript.OnPause.AddListener(DisablePlayer);
        pauseMenuScript.OnResume.AddListener(EnablePlayer);
    }
	
    void DisablePlayer()
    {
        player.GetComponent<PlayerMove>().enabled = false;
        playerHB.GetComponent<HeadBob>().enabled = false;
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
