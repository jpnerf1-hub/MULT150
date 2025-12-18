using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScene : MonoBehaviour
{
    // This function will be called by the button
    public void GoToMyGameScene()
    {
        // Use the name or index of the scene you want to load
        // Replace "GameSceneName" with the actual name of your destination scene
        SceneManager.LoadScene("JPaul_Final");
    }
}
