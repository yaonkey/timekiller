using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROYERRR : MonoBehaviour
{
    public float timer, cd;
    void Start()
    {
        timer = cd;
    }


    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;

        }
        if (timer <= 0)
        {

            Destroy(gameObject);


        }
    }
}
