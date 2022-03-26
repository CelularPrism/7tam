using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    public void RestartScene()
    {
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indexScene);
    }
}
