using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignTriggerIntor : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Sign Collision Triggered");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Sign Collision Triggered by player");

            //make the player bounce off the enemy aka jump
            other.gameObject.GetComponent<CharacterController2D>().FallDeath();
        }
    }
}