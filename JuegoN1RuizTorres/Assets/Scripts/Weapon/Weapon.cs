using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    private Animator anim;
    private AudioSource _AudioSource;

    public float range = 100f;                                              //Distancia maxima del arma
    public int bulletsPerMag = 30;                                          //Balas en cada cargador
    public int bulletsLeft = 200;                                           //Todas las balas que tengo

    public int currentBullets;                                              //Las balas que tengo actualmente en el cargador

    public Transform shootPoint;                                            //El punto de donde salen las balas
    public ParticleSystem muzzleFlash;
    public AudioClip shootSound;

    public float fireRate = 0.1f;                                           //El delay entre cada disparo

    float fireTimer;                                                        //Contador de tiempo para el delay

    private bool isReloading;                                               //Ve si estamos en la animacion de Reload

    void Start()
    {
        anim = GetComponent<Animator>();
        _AudioSource = GetComponent<AudioSource>();
        currentBullets = bulletsPerMag;
    }

    void Update()
    {

        if (Input.GetButton("Fire1"))
        {
            if (currentBullets > 0)
                Fire();                                                     //Ejecuta la funcion fire si es que presionamos/mantenemos el click izquierdo del mouse
            else if(bulletsLeft > 0)
                DoReload();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (currentBullets < bulletsPerMag && bulletsLeft > 0)
                DoReload();
        }

        if (fireTimer < fireRate)
            fireTimer += Time.deltaTime;                                    //Add into time counter
    }

    private void FixedUpdate()
    {
        AnimatorStateInfo info = anim.GetCurrentAnimatorStateInfo(0);

        isReloading = info.IsName("Reload");                                //Si estamos en el Reload state, isReloading va a ser true por defercto

        //if (info.IsName("Fire")) anim.SetBool("Fire", false);             //Si estamos en el Fire State, reseteamos la variable
    }

    private void Fire()
    {                                                                       //Este disparo va a estar hecho con raycast (castea un rayacst y no crea una bala cada vez que dispara)
        if (fireTimer < fireRate || currentBullets <= 0 || isReloading) return; //Esto seria como el verificador que pregunta si podemos disparar, si el timer terminó, y si las balas llegan a 0 que pare.

        RaycastHit hit;                                                     //Aca vamos a guardar los resultados de donde golpea el raycast

        if (Physics.Raycast(shootPoint.position, shootPoint.transform.forward, out hit, range)) //Este es el disparo en sí
        {
            Debug.Log(hit.transform.name + " found!");                      //Muestra el nombre del objeto al que golpea el raycast

        }

        anim.CrossFadeInFixedTime("Fire", 0.01f);                           //Ejecuta la animacion de disparo
        muzzleFlash.Play();                                                 //Ejecuta el fogonazo del arma
        PlayShootSound();                                                   //Ejecuta el sonido del disparo

        currentBullets--;
        fireTimer = 0.0f;                                                   //Resetea el fire timer
    }

    public void Reload()
    {
        if (bulletsLeft <= 0) return;                                       //Si no te quedan mas balas no podes recargar

        int bulletsToLoad = bulletsPerMag - currentBullets;                 //Esto se fija cuantas balas hay que cargar en el cargador
        int bulletsToDeduct = (bulletsLeft >= bulletsToLoad) ? bulletsToLoad : bulletsLeft;

        bulletsLeft -= bulletsToDeduct;
        currentBullets += bulletsToDeduct;
    }

    private void DoReload()
    {
        AnimatorStateInfo info = anim.GetCurrentAnimatorStateInfo(0);

        if (isReloading) return;

        anim.CrossFadeInFixedTime("Reload", 0.01f);
    }

    private void PlayShootSound()
    {
        _AudioSource.PlayOneShot(shootSound);                               //Con este podemos reproducir muchos audios
        //_AudioSource.clip = shootSound;                                   //Con estos dos el audio se cortaba
        //_AudioSource.Play();
    }
}
