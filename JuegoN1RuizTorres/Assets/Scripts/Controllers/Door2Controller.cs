using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2Controller : MonoBehaviour {

    [SerializeField] private Animator _animator;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private GameObject thisBox;

    [SerializeField] private bool doorIsOpening;
   
    void Update()
    {
        if (doorIsOpening == true)
        {
            _animator.SetBool("open", true);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (ScoreManager.Instance.Score >= 100)
        {
            doorIsOpening = true;
            _audioSource.Play();

            StartCoroutine(DeleteThisBox());
        }
        
    }

    IEnumerator DeleteThisBox()
    {
        yield return new WaitForSeconds(1f);

        thisBox.SetActive(false);

        thisBox.GetComponent<Door2Controller>().enabled = false;

    }
}
