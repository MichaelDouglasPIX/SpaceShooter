using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipControl : MonoBehaviour
{
    Vector3 movement, rotation;
    [SerializeField] float speed = 40f, rotSpeed = 30f;
    public GameObject meshship;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0);

        rotation = new Vector3(-movement.y, movement.x, -movement.z);
        meshship.transform.localRotation = Quaternion.Euler(rotation*rotSpeed);

        transform.Translate(movement * Time.deltaTime * speed);

        transform.localPosition = Vector3.Lerp(transform.localPosition, Vector3.zero, Time.deltaTime);

    }
}
