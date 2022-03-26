using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefabBomb;
    public float sizePoint;
    public float damage;

    public void SpawnBomb()
    {
        GameObject bomb = Instantiate(prefabBomb, transform.position, new Quaternion(0f, 0f, 0f, 0f));
        bomb.GetComponent<Bomb>().ChangeSize(sizePoint);
        bomb.GetComponent<Bomb>().damage += damage;
    }
}
