using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(HealthSystem))]
[RequireComponent(typeof(BombSpawner))]
public class Player : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;
    [SerializeField] private int countBomb;

    private GameObject[] bombs;
    private HealthSystem healthSystem;
    private BombSpawner bombSpawner;

    private void Start()
    {
        healthSystem = GetComponent<HealthSystem>();
        bombSpawner = GetComponent<BombSpawner>();
        bombs = new GameObject[countBomb];
    }

    private void FixedUpdate()
    {
        if (!healthSystem.isLive)
        {
            sceneController.EndGame();
        }
    }

    public void ChangeCountBomb(int count)
    {
        countBomb += count;
        bombs = new GameObject[countBomb];
    }

    public void ChangeDamageBomb(float damage)
    {
        bombSpawner.damage += damage;
    }

    public void ChangeSizeBomb(float point)
    {
        bombSpawner.sizePoint += point;
    }

    public void SpawnBomb()
    {
        for (int i = 0; i < bombs.Length; i++)
        {
            if (bombs[i] == null)
            {
                bombSpawner.SpawnBomb();
                return;
            }
        }
    }
}
