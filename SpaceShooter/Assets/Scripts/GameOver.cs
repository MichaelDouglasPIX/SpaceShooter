using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public static bool perdeu = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<Image>().enabled = perdeu;
        
        

    }

    // Update is called once per frame
    void Update()
    {
        if (perdeu)
        {
            GetComponent<Image>().enabled = perdeu;
            
            

        }
    }
}
