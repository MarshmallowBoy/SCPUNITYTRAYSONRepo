using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class NavMesh096 : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent Nav096;
    public int trig = 0;
    RaycastHit hit;
    public Collider FaceColl;
    public bool shyBoiTrig = false;
    public GameObject Sound1;
    public GameObject Sound2;
    public GameObject Sound3;
    public GameObject body1;
    public GameObject body2;
    public GameObject body3;
    [SerializeField]
    private float timeSCPBeforeTrigg = 20;
    public void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (FaceColl.Raycast(ray, out hit, 1000.0f))
        {
            if (shyBoiTrig == false)
            {
                StartCoroutine(SCPShyGuyIsTriggered());
            }
        }
        if (shyBoiTrig == true)
        {
            body3.transform.LookAt(Player.position);
            Nav096.SetDestination(Player.position);
        }
    }
    IEnumerator SCPShyGuyIsTriggered()
    {
        Sound1.SetActive(false);
        body1.SetActive(false);
        body2.SetActive(true);
        Sound3.SetActive(true);
        yield return new WaitForSecondsRealtime(timeSCPBeforeTrigg);
        
        Sound3.SetActive(false);
        body2.SetActive(false);
        body3.SetActive(true);
        Sound2.SetActive(true);
        shyBoiTrig = true;
    }
}
