using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SceneManage))]
public class SceneController : MonoBehaviour
{
    [SerializeField] private HealthSystem[] healthSystems;

    private SceneManage sceneManager;
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
