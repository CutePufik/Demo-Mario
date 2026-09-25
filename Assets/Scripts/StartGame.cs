using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
    }

    public void StartTheGame()
    {
        SceneManager.LoadScene(1);
    }
}
