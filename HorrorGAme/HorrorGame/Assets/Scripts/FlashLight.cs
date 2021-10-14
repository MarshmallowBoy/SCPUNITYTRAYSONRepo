using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public GameObject flashLight;
    public int flashLightInt = 1;
    public Animator Anim;
    public AudioSource Equip;
    public GameObject flash;
    public GameObject SCP;
    public GameObject Black2;
    public string scr = "Flash Light";
    public bool upOrDown2;
    private void Start()
    {
        SCP.GetComponent<SCP>().enabled = false;
        StartCoroutine(SCPEnabled());
        StartCoroutine(Black16());
    }

    IEnumerator SCPEnabled()
    {
        yield return new WaitForSeconds(3);
        SCP.GetComponent<SCP>().enabled = true;

    }
    IEnumerator Black16()
    {
        yield return new WaitForSeconds(10);
        Black2.SetActive(true);
        SCP.GetComponent<MeshRenderer>().enabled = false;
        SCP.GetComponent<SCP>().upOrDown = true;
        yield return new WaitForFixedUpdate();
        yield return new WaitForFixedUpdate();
        yield return new WaitForFixedUpdate();
        yield return new WaitForFixedUpdate();
        yield return new WaitForFixedUpdate();
        yield return new WaitForFixedUpdate();
        yield return new WaitForFixedUpdate();
        SCP.GetComponent<SCP>().upOrDown = false;
        SCP.GetComponent<MeshRenderer>().enabled = true;
        Black2.SetActive(false);
        StartCoroutine(Black16());
    }
    // Update is called once per frame
    void Update()
    {

        if (upOrDown2 == true)
        {
            Black2.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashLightInt = flashLightInt + 1;
            if (flashLightInt == 1)
            {
                Equip.Play(0);
                flashLight.SetActive(false);
                flash.SetActive(false);
            }
            if (flashLightInt == 2)
            {
                flashLightInt = 0;
                
                Equip.Play(0);
                flashLight.SetActive(true);
                flash.SetActive(true);
            }
        }
    }
}
