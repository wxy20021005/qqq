using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMove1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    private float a = 0f;

    // Update is called once per frame
    void Update()
    {
        a += Time.deltaTime;
        GetComponent<MeshRenderer>().material.mainTextureOffset = new Vector2(0, -a * 0.1f);
    }
}