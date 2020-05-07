using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : MonoBehaviour
{
  public void scenechange(string scenename)

    {
        SceneManager.LoadScene(scenename);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
