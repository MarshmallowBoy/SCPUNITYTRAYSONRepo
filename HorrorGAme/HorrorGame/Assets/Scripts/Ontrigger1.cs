using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontrigger1 : MonoBehaviour
{
    public bool HasEntered = false;
    public Animator animLeft;
    public Animator animRight;
    public Animator dclass1;
    public Animator dclass2;
    public AudioSource scp173encounter;
    private void OnTriggerEnter(Collider other)
    {
        if (HasEntered == false)
        {
            Sequence1();
            HasEntered = true;
        }
    }

    void Sequence1()
    {
        scp173encounter.Play(0);
        animLeft.Play("Sliding_Left");
        animRight.Play("Sliding_Right");
        dclass1.Play("D-Class1");
        dclass2.Play("D-Class2");
    }
}
