using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float countdown;
    [SerializeField] private GameObject spawnPoint;

    public Wave[] waves;

    public static int waveIndex;

    public static int waveLength;
    public int currentWave = -1;
    public bool readyToCountDown;

    private void Start(){
        readyToCountDown = false;
        waveLength = waves.Length;

        for(int i = 0; i < waves.Length; i++){
            waves[i].enemiesLeft = waves[i].enemies.Length;
        }
    }
    
    private void Update(){
        
        if(Input.GetKeyDown(KeyCode.G)){
            readyToCountDown = true;
            waveIndex = currentWave+1;
        }

        

        if(readyToCountDown){
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
                currentWave++;
            }

            if(waves[currentWave].enemiesLeft == 0){
                
            }
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
