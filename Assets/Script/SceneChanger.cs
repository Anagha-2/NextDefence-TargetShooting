using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
   public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
    public void OnExitButtonClicked()
    {
        Application.Quit();
    }
}
