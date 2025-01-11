using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiTool : MonoBehaviour
{
    

    public void loadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void QuitApp()
    {
        Application.Quit();
    }




}
