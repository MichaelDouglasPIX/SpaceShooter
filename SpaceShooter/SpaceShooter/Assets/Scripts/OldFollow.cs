using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldFollow : MonoBehaviour
{
    public GameObject way;
    Transform[] ways;
    public int index=1;
    public float velocity = 20;
    Vector3 oldpos;
    Quaternion oldrot;
    public static bool scripton = false;
    [SerializeField]public bool mostrar;
    
    // Start is called before the first frame update
    void Start()
    {

        ways = way.GetComponentsInChildren<Transform>();
        oldpos = transform.position;
        oldrot = transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards
            (transform.position, ways[index].transform.position, Time.deltaTime * velocity);

        Vector3 direction = ways[index].transform.position - transform.position;

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime);

        if(Vector3.Distance(transform.position, ways[index].transform.position) < 1)
        {
            index++;
            oldpos = transform.position;
            oldrot = transform.rotation;
        }
        if(scripton )
        {
            mostrar = scripton;
            //gameObject.SetActive (false);
            GetComponent<OldFollow>().enabled = false;
            GetComponent<FollowWay>().enabled = false;
            
        }
        
    }

}
