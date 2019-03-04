using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, Input.GetAxis("Horizontal") * -30);
        transform.Translate(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"), 0, Space.World);
    }
}
