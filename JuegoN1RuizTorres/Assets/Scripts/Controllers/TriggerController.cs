using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerController : MonoBehaviour
{
    //[SerializeField] private int num;
    [SerializeField] GameObject trigger;
    [HideInInspector] public UnityEvent triggerZero;
    [HideInInspector] public UnityEvent triggerOne;
    [HideInInspector] public UnityEvent triggerTwo;
    [HideInInspector] public UnityEvent triggerThree;
    [HideInInspector] public UnityEvent triggerFour;
    [HideInInspector] public UnityEvent triggerFive;
    [HideInInspector] public UnityEvent triggerSix;
    [HideInInspector] public UnityEvent triggerSeven;
    [HideInInspector] public UnityEvent triggerEight;
    [HideInInspector] public UnityEvent triggerNine;

    //CON ESTO NO NECESITARIAMOS TENER TODO LO ANTERIOR, SINO QUE LO TENEMOS EN UNO, Y LO SEGUIMOS USANDO EN LOS OTROS SCRIPTS 
    //public Dictionary<string, UnityEvent> triggerEvents = new Dictionary<string, UnityEvent>();

    private int score;

    private void OnTriggerEnter(Collider other)
    {
        
        score = ScoreManager.Instance.Score;
        Debug.Log("Pase por un trigger");
        //string triggerName = null;
        switch (score)
        {
            case 0:
                if (trigger.CompareTag("TriggerZero"))
                {
                    //triggerName = trigger.tag;
                    Debug.Log("Hola 0");
                    triggerZero.Invoke();
                    StartCoroutine(DisableTrigger(this.trigger));
                }
                break;
            case 100:
                if (trigger.CompareTag("TriggerOne"))
                {
                    triggerOne.Invoke();
                    Debug.Log("Hola 100");
                    StartCoroutine(DisableTrigger(this.trigger));
                }
                break;
            case 200:
                if (trigger.CompareTag("TriggerTwo"))
                {
                    triggerTwo.Invoke();
                    StartCoroutine(DisableTrigger(this.trigger));
                }
                    break;
            case 300:
                if (trigger.CompareTag("TriggerThree"))
                {
                    triggerThree.Invoke();
                    StartCoroutine(DisableTrigger(this.trigger));
                }
                    break;
            case 400:
                if (trigger.CompareTag("TriggerFour"))
                {
                    triggerFour.Invoke();
                    StartCoroutine(DisableTrigger(this.trigger));
                }
                    break;
            case 500:
                if (trigger.CompareTag("TriggerFive"))
                {
                    triggerFive.Invoke();
                    StartCoroutine(DisableTrigger(this.trigger));
                }
                    break;
            case 600:
                if (trigger.CompareTag("TriggerSix"))
                {
                    triggerSix.Invoke();
                    StartCoroutine(DisableTrigger(this.trigger));
                }
                    break;
            case 650:
                if (trigger.CompareTag("TriggerSeven"))
                {
                    triggerSeven.Invoke();
                    StartCoroutine(DisableTrigger(this.trigger));
                }
                    break;
            case 700:
                if (trigger.CompareTag("TriggerEight"))
                {
                    triggerEight.Invoke();
                    StartCoroutine(DisableTrigger(this.trigger));
                }
                    break;
            case 800:
                if (trigger.CompareTag("TriggerNine"))
                {
                    triggerNine.Invoke();
                    StartCoroutine(DisableTrigger(this.trigger));
                }
                    break;
        }

        //SI EL TRIGGER NAME NO ES NULO, Y DEFINITIVAMENTE EXISTEN, LO INVOCA
        //if (triggerName != null && triggerEvents.ContainsKey(triggerName))
           // triggerEvents[triggerName].Invoke();
    }

    /*IEnumerator DisableTrigger(string triggerName)
    {
        //triggerEvents.Remove(triggerName);
        yield return new WaitForSeconds(0.5f);
        //trigger[num].SetActive(false);
    }*/

    IEnumerator DisableTrigger(GameObject tg)
    {
        yield return new WaitForSeconds(0.5f);
        tg.SetActive(false);
        yield break;
    }

    public UnityEvent TriggerZero { get { return triggerZero; } }
    public UnityEvent TriggerOne { get { return triggerOne; } }
    public UnityEvent TriggerTwo { get { return triggerTwo; } }
    public UnityEvent TriggerThree { get { return triggerThree; } }
    public UnityEvent TriggerFour { get { return triggerFour; } }
    public UnityEvent TriggerFive { get { return triggerFive; } }
    public UnityEvent TriggerSix { get { return triggerSix; } }
    public UnityEvent TriggerSeven { get { return triggerSeven; } }
    public UnityEvent TriggerEight { get { return triggerEight; } }
    public UnityEvent TriggerNine { get { return triggerNine; } }

}