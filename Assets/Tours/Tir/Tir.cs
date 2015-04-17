﻿using UnityEngine;
using System.Collections;

//////////////////////////////////////////////////////////
//                                                      //
//  Cette classe est la classe parent de tout les tirs  //
//                                                      //
//////////////////////////////////////////////////////////

public class Tir : MonoBehaviour {

    // La cible fournit par la Tour
    public GameObject cible;

    // On accède au script de la cible
    private Ennemy cible_script;

    //Delay de tir
    public float delay;

    //Les dégâts qu'inflige ce tir
    public int degats;

    //L'accélération de la tour
    public float acceleration;

    public bool aoe;
 
    void OnTriggerEnter(Collider touch)
    {

        if (touch.gameObject == cible) //Si la chose que le projectile à touché est bien la cible
        {

            //On établi l'accès entre ce script et celui du GameObject cible
            cible_script = (Ennemy)cible.GetComponent(typeof(Ennemy));

            //On applique les dégâts à la cible
            cible_script.vie -= degats;

            if (aoe == true)
            {
                Debug.Log("explosiiooooon");
                //Add(SphereCollider);
                //void OnTriggerEnter(Collider touch);
                //cible_script.vie -= degats;
            }

            
            //Le tir se détruit à l'impact
            Destroy(this.gameObject);

        }
        
        //  /!\ Il faudra prog une alternative en cas d'aoe;

    
    }


	// Update is called once per frame
	void Update () 
    {
        if (cible != null) //Si la cible existe 
        {
            //On se déplace vers la cible
            transform.position = Vector3.Lerp(transform.position, cible.transform.position, delay * Time.deltaTime * acceleration);
            //On la regarde en avançant
            transform.LookAt(cible.transform);
        }
        else //Si la cible est détruite et que le tir est déjà lancé
        {
            Destroy(this.gameObject); //on détruit cet objet, il n'a plus d'utilité
        }
	}
}