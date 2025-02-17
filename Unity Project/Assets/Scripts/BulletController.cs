﻿using UnityEngine;

public class BulletController : MonoBehaviour {

    public float bulletSpeed = 8f;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, GetComponent<Rigidbody2D>().velocity.x);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Zombie"))
        {
            other.gameObject.GetComponent<ZombieControllerScript>().TakeDamage();
			Destroy(gameObject);
        }
        else if (other.CompareTag("Bandit"))
        {
        }
    }


}
