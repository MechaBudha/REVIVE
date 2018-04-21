using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    private Animator anim;

    public float range = 100f;                                              //Distancia maxima del arma
    public int bulletsPerMag = 30;                                          //Balas en cada cargador
    public int bulletsLeft = 200;                                           //Todas las balas que tengo

    public int currentBullets;                                              //Las balas que tengo actualmente en el cargador

    public Transform shootPoint;                                            //El punto de donde salen las balas

    public float fireRate = 0.1f;                                           //El delay entre cada disparo

    float fireTimer;                                                        //Contador de tiempo para el delay

	void Start () {

        anim = GetComponent<Animator>();
        currentBullets = bulletsPerMag;
	}
	
	void Update () {
		
        if (Input.GetButton("Fire1"))
        {
            Fire();                                                         //Ejecuta la funcion fire si es que presionamos/mantenemos el click izquierdo del mouse
        }

        if (fireTimer < fireRate)
            fireTimer += Time.deltaTime;                                    //Add into time counter
	}

    private void FixedUpdate()
    {
        AnimatorStateInfo info = anim.GetCurrentAnimatorStateInfo(0);

        if (info.IsName("Fire")) anim.SetBool("Fire", false);               //Si estamos en el Fire State, reseteamos la variable
    }

    private void Fire() {                                                   //Este disparo va a estar hecho con raycast (castea un rayacst y no crea una bala cada vez que dispara)
        if (fireTimer < fireRate) return;                                   //Esto seria como el verificador que pregunta si podemos disparar, si el timer terminó

        RaycastHit hit;                                                     //Aca vamos a guardar los resultados de donde golpea el raycast

        if(Physics.Raycast(shootPoint.position, shootPoint.transform.forward, out hit, range)) //Este es el disparo en sí
        {
            Debug.Log(hit.transform.name + " found!");                      //Muestra el nombre del objeto al que golpea el raycast

        }

        anim.CrossFadeInFixedTime("Fire", 0.01f);                           //Ejecuta la animacion de disparo
        currentBullets--;
        fireTimer = 0.0f;                                                   //Resetea el fire timer
    }
}
