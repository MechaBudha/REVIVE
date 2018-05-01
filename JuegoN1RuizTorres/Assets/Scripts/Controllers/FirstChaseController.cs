using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstChaseController : MonoBehaviour {

    public GameObject enemy;
    public GameObject spawnBox;
    public GameObject button;
    public AudioSource ambientMusic;
    public AudioSource chaseMusic;
    private float counter = 0.1f;

    public bool triggerOn;

    private void Update()
    {
        if (triggerOn)
        {
            enemy.SetActive(true);
            counter++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerOn = true;
        if (counter < 1.1f)
            chaseMusic.Play();

        ambientMusic.enabled = false;
        StartCoroutine(DeleteThisBox());
    }

    IEnumerator DeleteThisBox()
    {
        yield return new WaitForSeconds(0.5f);

        spawnBox.SetActive(false);
        button.SetActive(false);
        spawnBox.GetComponent<FirstChaseController>().enabled = false;
        button.GetComponent<DoorController>().enabled = false;
    }
}
