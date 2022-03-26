using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(ManagerScene))]
public class SceneController : MonoBehaviour
{
    [SerializeField] private HealthSystem[] healthSystems;

    private ManagerScene sceneManager;

    private void Start()
    {
        sceneManager = GetComponent<ManagerScene>();
    }

    void FixedUpdate()
    {
        int countRip = 0;
        foreach (HealthSystem healthSystem in healthSystems)
        {
            if (!healthSystem.isLive)
            {
                countRip++;
            }
        }

        if (countRip == healthSystems.Length)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        sceneManager.RestartScene();
    }
}
