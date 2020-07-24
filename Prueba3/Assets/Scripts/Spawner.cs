using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    public int timeToSpawn = 0;

    public float timer = 0;

    [Header("Settings for Random Timer")]

    public int minSeconds = 2;

    public int maxSeconds = 10;

    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = Random.Range(minSeconds, maxSeconds);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeToSpawn)
        {
            Instantiate(objectToSpawn, gameObject.transform);

            timer = 0;

            timeToSpawn = Random.Range(minSeconds, maxSeconds);
        }
    }
}
