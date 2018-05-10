using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnemyController : MonoBehaviour {

    public GameObject enemy;
    public GameObject thisBox;
    public Light lights;
    public GameObject[] box = null;
    public GameObject flashlight;
    //public GameObject button;
    [SerializeField]private AudioSource lightsOff;

    public bool triggerOn;

    private void Update()
    {
        if (triggerOn)
        {
            enemy.SetActive(false);

            foreach (GameObject go in box)
            {

                Renderer renderer = go.GetComponent<Renderer>();
                Material mat = renderer.material;

                float emission = Mathf.PingPong(Time.time, 1f);
                Color baseColor = Color.black; //Replace this with whatever you want for your base color at emission level '1'

                Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);

                mat.SetColor("_EmissionColor", finalColor);

            }

            flashlight.GetComponent<Flashlight>().flashLight.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerOn = true;

        lightsOff.Play();

        lights.intensity = 0f;

        StartCoroutine(DeleteThisBox());
    }

    IEnumerator DeleteThisBox()
    {
        yield return new WaitForSeconds(0.5f);

        thisBox.SetActive(false);
        thisBox.GetComponent<DisableEnemyController>().enabled = false;
    }
}
