using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontrigger2 : MonoBehaviour
{
    public bool hasEntered = false;
    public Animator door_Left2;
    public Animator door_Right2;
    public GameObject black;
    public GameObject SCPReal;
    public GameObject SCPFake;
    public bool toggleeyes;
    public GameObject player;
    public GameObject dclass1;
    public GameObject dclass2;
    public GameObject dclass12;
    public GameObject dclass22;
    public AudioSource Breath;
    public AudioSource NeckSnap;
    public AudioSource NeckSnap2;
    private void OnTriggerEnter(Collider other)
    {
        if (hasEntered == false)
        {
            hasEntered = true;
            door_Left2.Play("door_left2");
            door_Right2.Play("door_right2");
            StartCoroutine(WaitThing());
        }
    }
    IEnumerator WaitThing()
    {
        yield return new WaitForSecondsRealtime(2);
        door_Left2.Play("Sliding_Left");
        door_Right2.Play("Sliding_Right");
        yield return new WaitForSecondsRealtime(5);
        black.SetActive(true);
        NeckSnap.Play(0);
        SCPFake.transform.position = new Vector3(22, 0, 9);
        dclass1.SetActive(false);
        dclass12.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        black.SetActive(false);
        yield return new WaitForSecondsRealtime(3);
        black.SetActive(true);
        NeckSnap2.Play(0);
        dclass2.SetActive(false);
        dclass22.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        SCPFake.SetActive(false);
        SCPReal.SetActive(true);
        Breath.Play(0);
        SCPReal.transform.position = new Vector3(21, 0, 5);
        SCPReal.transform.LookAt(player.transform.position);
        black.SetActive(false);
    }
}
