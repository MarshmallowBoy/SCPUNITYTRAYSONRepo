using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnSCPtrigger : MonoBehaviour
{
    public Collider playerColl;
    private void OnTriggerEnter(Collider playerColl)
    {
        SceneManager.LoadScene(2);
    }
}
