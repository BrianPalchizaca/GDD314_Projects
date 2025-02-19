using UnityEngine;
using UnityEditor;

public class Ball_Spawner : MonoBehaviour
{

    public GameObject ballPrefab;
    //public Rigidbody rb;

    public Transform spawnPoint;
    float spawnTime = 3;
    float spawnCountdown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnCountdown = spawnTime;
    }

    // Update is called once per frame
    
    void Update()
    {
        if (spawnCountdown <= 0)
        {
            GameObject newball = Instantiate(ballPrefab);
            newball.transform.position = spawnPoint.position;
            spawnCountdown = spawnTime;
        }

        spawnCountdown -=Time.deltaTime;
    }
    
}
