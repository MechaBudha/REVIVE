using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsManager : MonoBehaviour {

    [SerializeField] TriggerController[] tcScript;
    [SerializeField] ButtonController btScript;
    [SerializeField] BearController bearScript;

    [SerializeField] private GameObject[] lightsRed = null;
    [SerializeField] private GameObject[] boxRed = null;
    [SerializeField] private GameObject[] allLights = null;
    [SerializeField] private GameObject[] allBox = null;
    [SerializeField] private GameObject[] boxOff = null;
    private GameObject flashlight;
    [SerializeField] private Light lightOff;

    private void Awake()
    {
        //tcScript = tcScript.GetComponent<TriggerController>();
        
    }

    void Start () {
        //tcScript[0].TriggerFour.AddListener(LightRed);
        btScript.ButtonTwo.AddListener(LightRed);
        tcScript[1].TriggerSix.AddListener(LightOff);
        bearScript.Bear.AddListener(AllLightsOff);
        flashlight = FindObjectOfType<GameManager>().GetPlayer().GetComponentInChildren<Flashlight>().transform.gameObject;
        //tcScript[2].TriggerEight.AddListener(AllLightsOff);
    }
	
	void LightRed()
    {
        foreach (GameObject go in lightsRed)
        {
            Light light = go.GetComponent<Light>();
            light.color = Color.red;
        }

        foreach (GameObject go in boxRed)
        {
            Renderer renderer = go.GetComponent<Renderer>();
            Material mat = renderer.material;

            float emission = Mathf.PingPong(Time.time, 1f);
            Color baseColor = Color.red; //Replace this with whatever you want for your base color at emission level '1'

            Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);

            mat.SetColor("_EmissionColor", finalColor);
        }
    }

    void LightOff()
    {
        lightOff.intensity = 0f;

        foreach (GameObject go in boxOff)
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

    void AllLightsOff()
    {
        foreach (GameObject go in allLights)
        {
            Light light = go.GetComponent<Light>();
            light.intensity = 0f;
        }

        foreach (GameObject go in allBox)
        {
            Renderer renderer = go.GetComponent<Renderer>();
            Material mat = renderer.material;

            float emission = Mathf.PingPong(Time.time, 1f);
            Color baseColor = Color.black; //Replace this with whatever you want for your base color at emission level '1'

            Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);

            mat.SetColor("_EmissionColor", finalColor);
        }
    }
}
