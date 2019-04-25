using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public AudioSource source;
    public GameObject barrel, support;
    GameObject target;
    public ParticleSystem weapon;
    bool work = false;
    public int attackDamage = 10;
    // Start is called before the first frame update


   // GameObject player;
    //PlayerHealth playerHealth;

    
    //float timer;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        //playerHealth = player.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(work)
        {
            
            //Arma segue o player
            barrel.transform.LookAt(target.transform);
            //Suporte pega a rotação da arma
            support.transform.rotation = Quaternion.Euler(0, barrel.transform.rotation.eulerAngles.y, 0);

            /*if (playerHealth.currentHealth > 0)
            {
                playerHealth.TakeDamage(attackDamage);
            }*/
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.tag != this.gameObject.tag)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        

            work = true;
            weapon.Play();
            source.Play();
            
        
        
        
    }
    private void OnTriggerExit(Collider other)
    {

        
            work = false;
            weapon.Stop();
            source.Stop();

    }
}
