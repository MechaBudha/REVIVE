using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor2Controller : MonoBehaviour {

    //public GameObject triggerObject;
    [SerializeField] int score;

    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void PickUp()
    {

        ScoreManager.Instance.Score += score;
        Destroy(gameObject);


    }
}
