using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AriPlaneMove2 : MonoBehaviour
{
    private int speed = 3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        transform.position += new Vector3(hor, vert, 0) * speed * Time.deltaTime;
        if (transform.position.x >= 3.5f)
        {
            transform.position = new Vector3(3.5f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x <= -3.5f)
        {
            transform.position = new Vector3(-3.5f, transform.position.y, transform.position.z);
        }

       
        
    }
}