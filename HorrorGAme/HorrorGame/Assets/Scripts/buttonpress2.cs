using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonpress2 : MonoBehaviour
{
    public GameObject Play;
    public void ButtonPress22()
    {
        Play.SetActive(true);
    }
    public void ButtonPress33()
    {
        Application.Quit();
    }
}
