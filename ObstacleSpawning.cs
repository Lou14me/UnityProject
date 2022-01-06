using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawning : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] obstaclesPrefabs;
    public Transform[] spwanPoints;
    private float nextSpawnTime;

    public float timeBetweenToSpawn = 5f;
    public int numberOfEachSpwanObstacle = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>=nextSpawnTime){
            SpawnObstacle();
            nextSpawnTime = Time.time+timeBetweenToSpawn;
        }
    }
    public void SpawnObstacle(){
        foreach(int index in GetRandomObstalceSpawnPoints()){

            GameObject randomObstalceObject = obstaclesPrefabs[Random.Range(0,obstaclesPrefabs.Length)];
            Transform randomObstaclePoint = spwanPoints[index];
            Instantiate(randomObstalceObject,randomObstaclePoint.position,transform.rotation);
        }
    }
    public HashSet<int> GetRandomObstalceSpawnPoints(){
        HashSet<int> randomIndexs = new HashSet<int>();
        Transform[] randomObstalceSpawnPoints = new Transform[numberOfEachSpwanObstacle];
        for(int i =0;i<numberOfEachSpwanObstacle;i++){
            while (randomIndexs.Add(Random.Range(0,spwanPoints.Length))==false);
        }
        return randomIndexs;
    }
}
