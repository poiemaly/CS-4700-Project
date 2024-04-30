using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float countdown;
    [SerializeField] private GameObject spawnPoint;

    public Wave[] waves;
    public int currentWave = 0;
    private bool readyToCountDown;

    private void Start(){
        readyToCountDown = true;

        for(int i = 0; i < waves.Length; i++){
            waves[i].enemiesLeft = waves[i].enemies.Length;
        }
    }
    
    private void Update(){
        if(currentWave >=waves.Length){
            Debug.Log("Wave Clear");
            return;
        }

        if(readyToCountDown == true){
            countdown -= Time.deltaTime;
        }
        
        if(countdown <= 0){
            readyToCountDown = false;

            countdown = waves[currentWave].timeToNextWave;

            StartCoroutine(SpawnWave());
        }

        if(waves[currentWave].enemiesLeft == 0){
            readyToCountDown = true;
            currentWave++;
        }
    }

    private IEnumerator SpawnWave(){
        if(currentWave < waves.Length){
            for (int i = 0; i < waves[currentWave].enemies.Length; i++){
                Enemy enemy = Instantiate(waves[currentWave].enemies[i], spawnPoint.transform);

                enemy.transform.SetParent(spawnPoint.transform);

                yield return new WaitForSeconds(waves[currentWave].timeToNextEnemy);
            }
        }
    }
}

[System.Serializable]
public class Wave{
    public Enemy[] enemies;
    public float timeToNextEnemy;
    public float timeToNextWave;
    [HideInInspector] public int enemiesLeft;
}
