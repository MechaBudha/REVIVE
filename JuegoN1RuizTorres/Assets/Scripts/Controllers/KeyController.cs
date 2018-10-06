using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour {

    //public GameObject triggerObject;
    //[SerializeField] int score;
    [SerializeField] private AudioSource keyPickup;
    //[SerializeField] private AudioSource enemyWalk;

    public void PickUp()
    {
        ScoreManager.Instance.Score += 50;
        keyPickup.Play();
        //enemyWalk.Play();
        Destroy(gameObject);
    }
}
