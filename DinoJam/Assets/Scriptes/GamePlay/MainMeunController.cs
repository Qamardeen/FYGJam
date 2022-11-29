using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMeunController : MonoBehaviour
{
    public void OnButtonPlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnButtonQuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif 
    }
}
