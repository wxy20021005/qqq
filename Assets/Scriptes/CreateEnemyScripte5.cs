using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemyScripte5 : MonoBehaviour
{
    public GameObject Enemy;
    public float CreateTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CreateTime += Time.deltaTime;
        if (CreateTime >= 1.0f)
        {
            CreateTime = 0.0f;
            float x = Random.Range(-4.0f, 4.0f);
            Instantiate(Enemy, new Vector3(x, 5, -2), Enemy.transform.rotation);
        }
    }
}