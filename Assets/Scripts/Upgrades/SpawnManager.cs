using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float timeNextSpawn;
    [SerializeField] private Transform[] points;
    [SerializeField] private GameObject[] upgrades;

    private float timeSpawn;
    // Start is called before the first frame update
    void Start()
    {
        timeSpawn = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSpawn + timeNextSpawn < Time.time)
        {
            int randNum = Random.Range(0, points.Length);
            Transform point = points[randNum];

            randNum = Random.Range(0, upgrades.Length);
            GameObject upgrade = upgrades[randNum];

            Instantiate(upgrade, point.position, point.rotation);
            timeSpawn = Time.time;
        }
    }
}
