using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityManager : MonoBehaviour {

    [SerializeField] TriggerController[] tcScript;
    [SerializeField] ButtonController[] btScript;

    [SerializeField] private GameObject et1;
    [SerializeField] private GameObject et2;
    [SerializeField] private GameObject et3;
    [SerializeField] private GameObject bt1;
    [SerializeField] private GameObject bt2;

    private void Awake()
    {
        //tcScript = tcScript.GetComponent<TriggerController>();
    }
    void Start () {
        
        tcScript[0].TriggerFive.AddListener(EntityOne);
        tcScript[1].TriggerSix.AddListener(EntityTwo);
        tcScript[2].TriggerNine.AddListener(EntityThree);
        btScript[0].ButtonOne.AddListener(ButtonOne);
        btScript[1].ButtonTwo.AddListener(ButtonTwo);
    }
	
	void EntityOne()
    {
        et1.SetActive(true);
        et2.SetActive(true);
    }

    void EntityTwo()
    {
        et2.SetActive(false);
    }

    void EntityThree()
    {
        et1.SetActive(false);
        et3.SetActive(true);
    }

    void ButtonOne()
    {
        StartCoroutine(DisableButton(bt1));
    }

    void ButtonTwo()
    {
        StartCoroutine(DisableButton(bt2));
    }

    IEnumerator DisableButton(GameObject bt)
    {
        yield return new WaitForSeconds(0.5f);

        bt.GetComponent<ButtonController>().enabled = false;
    }
}
