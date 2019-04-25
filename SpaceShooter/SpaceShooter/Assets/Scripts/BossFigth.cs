using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFigth : MonoBehaviour
{
    public AudioSource source;
    public GameObject barrel, support;
    GameObject target;
    public ParticleSystem weapon;
    bool work = false;
    int life = 0;
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (work)
        {
            //Arma segue o player
            barrel.transform.LookAt(target.transform);
            //Suporte pega a rotação da arma
            support.transform.rotation = Quaternion.Euler(0, barrel.transform.rotation.eulerAngles.y, 0);
            source.Play();
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        life = life + 1;
        if (life >=10) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        work = true;
        weapon.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        work = false;
        weapon.Stop();
    }
}
