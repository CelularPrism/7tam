using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject prefabBomb;

    public void SpawnBomb()
    {
        Instantiate(prefabBomb, transform.position, new Quaternion(0f, 0f, 0f, 0f));
    }
}
