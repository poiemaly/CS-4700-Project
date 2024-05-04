using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform endPoint;
    public static int Health;
    public int initialHealth;
    public static int Damage;
    public int initialDamage;
    private NavMeshAgent agent;
    private Spawner spawner;
    private float countdown = 10f;

    void start(){
        
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;


        if(countdown <= 0){
            Destroy(gameObject);
            spawner.waves[spawner.currentWave].enemiesLeft--;
            GameStats.Lives -= initialDamage;
        }
        
    }

    private void Start(){
        agent = GetComponent<NavMeshAgent>();
        agent.destination = endPoint.position;
        spawner = GetComponentInParent<Spawner>();
        Health = initialHealth;
        Damage = initialDamage;
    }
}
