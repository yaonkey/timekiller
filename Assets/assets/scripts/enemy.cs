using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public float speed;
   


   

    private void Update()
    {

        transform.Translate(Vector2.down * speed * Time.deltaTime);
        Destroy(gameObject, 40f);

    }
}
