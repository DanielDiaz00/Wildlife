﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
    //Si el projectil colisiona con el animal, ambos se destruyen
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            Destroy(this.gameObject);//Destruye el animal
            Destroy(other.gameObject); //Destruye lo otro          
        }
    }
}
