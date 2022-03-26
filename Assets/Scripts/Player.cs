using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(HealthSystem))]
public class Player : MonoBehaviour
{
    [SerializeField] private GameObject prefabBomb;
    [SerializeField] private HealthSystem healthSystem;
    [SerializeField] private SceneController sceneController;
    [SerializeField] private int countBomb;

    private GameObject[] bombs;

    private void Start()
    {
        healthSystem = GetComponent<HealthSystem>();
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
    }

    public void SpawnBomb()
    {
        for (int i = 0; i < bombs.Length; i++)
        {
            if (bombs[i] == null)
            {
                bombs[i] = Instantiate(prefabBomb, transform.position, new Quaternion(0f, 0f, 0f, 0f));
                return;
            }
        }
    }
}
