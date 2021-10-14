using UnityEngine;
using UnityEngine.AI;

public class SCP : MonoBehaviour
{
    public GameObject black;
    public GameObject trigger;
    public GameObject SCP173;
    public Transform player;
    public float speed = 20;
    public bool isLooking;
    public bool upOrDown = false;
    public bool isVisible = true;
    public NavMeshAgent SCP173Nav;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            upOrDown = true;
            isLooking = false;
            black.SetActive(true);
            SCP173.GetComponent<MeshRenderer>().enabled = false;
            trigger.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            black.SetActive(false);
            upOrDown = false;
            SCP173.GetComponent<MeshRenderer>().enabled = true;
            trigger.SetActive(false);
        }

        if (isLooking == false)
        {
            SCP173Nav.SetDestination(player.position);
            SCP173.transform.LookAt(player.position);
            trigger.SetActive(true);
        }
        else{
            SCP173Nav.SetDestination(SCP173.transform.position);
            trigger.SetActive(false);
        }
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }
    private void OnBecameVisible()
    {
        isVisible = true;
        if (upOrDown == false)
        {
            isLooking = true;
        }
    }
    private void OnBecameInvisible()
    {
        isVisible = false;
        isLooking = false;
    }
}
