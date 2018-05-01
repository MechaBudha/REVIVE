using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] private float health = 100f;
    public AudioSource chaseMusic;
    public AudioSource ambientMusic;
    //public GameObject deactivateButton;

    public void ApplyDamage(float damage)
    {
        health -= damage;
        if (health <= 0f)
        {
            Destroy(gameObject);
            chaseMusic.enabled = false;
            ambientMusic.enabled = true;

            //deactivateButton.SetActive(false);
        }
    }
}
