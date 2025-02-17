﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {

    public List<GameObject> zombiePrefab;
    public Transform zombieSpawner;
    public int zombieNumber;
    public System.Random rand = new System.Random();
    public int zombieSpawnRate;

    // Update is called once per frame
    void Update ()
    {
        if (Time.timeScale > 0)
        {
            zombieNumber = rand.Next(0, zombieSpawnRate);

            if (zombieNumber == 0 || zombieNumber == 2 || zombieNumber == 4)
            {
                GameObject zombie = UnityEngine.Object.Instantiate(zombiePrefab[zombieNumber], zombieSpawner.position, Quaternion.identity);
                UnityEngine.Object.Destroy(zombie, 15.0f);
            }
            else if (zombieNumber == 3 || zombieNumber == 1)
            {
                GameObject zombie = UnityEngine.Object.Instantiate(zombiePrefab[zombieNumber], zombieSpawner.position, Quaternion.identity);
                UnityEngine.Object.Destroy(zombie, 15.0f);
            }
        }
    }
}
