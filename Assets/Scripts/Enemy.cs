using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private Spawner spawner;
    private float countdown = 150f;

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if(countdown <= 0){
            Destroy(gameObject);
            spawner.waves[spawner.currentWave].enemiesLeft--;
        }
    }

    private void Start(){
        spawner = GetComponentInParent<Spawner>();
    }
}
