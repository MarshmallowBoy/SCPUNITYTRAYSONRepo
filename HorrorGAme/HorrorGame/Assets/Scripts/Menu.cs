using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    int key = 0;
    public GameObject Cam;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            key = key + 1;
        }


        switch (key)
        {
            case 0:
                Cursor.lockState = CursorLockMode.Locked;
                break;
            case 1:
                Cursor.lockState = CursorLockMode.None;
              //  Cam.GetComponent<FirstPersonLook>().enabled = false;
                break;
            case 2:
                key = 0;
              //  Cam.GetComponent<FirstPersonLook>().enabled = true;
                break;
        }
    }
}
