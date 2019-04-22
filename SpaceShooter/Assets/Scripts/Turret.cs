using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    public GameObject barrel, support;
    GameObject target;
    public ParticleSystem weapon;
    bool work = false;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(work)
        { 
            //Arma segue o player
            barrel.transform.LookAt(target.transform);
            //Suporte pega a rotação da arma
            support.transform.rotation = Quaternion.Euler(-90, barrel.transform.rotation.eulerAngles.y, 0);
        }
    }
}
