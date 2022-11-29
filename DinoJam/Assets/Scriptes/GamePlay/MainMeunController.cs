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
}
