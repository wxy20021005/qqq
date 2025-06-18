using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScilpte5 : MonoBehaviour
{
    public GameObject _GameObject;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.up * Time.deltaTime * 3;
        transform.Rotate(Vector3.forward*80 * Time.deltaTime,Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject,2f);
            Destroy(Instantiate(_GameObject,_GameObject.transform.position,Quaternion.identity),1);
        }
    }
}