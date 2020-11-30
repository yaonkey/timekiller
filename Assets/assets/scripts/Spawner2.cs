using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject spawnObj;
    public GameObject[] enemy;
    int rand;
    public int score;
    
    // Start is called before the first frame update
    void Start()
    {

        
        StartCoroutine(spawn());
       


    }

    
   
    void Update()
    {
        
        rand = Random.Range(0, enemy.Length);

       


    }
    IEnumerator spawn()
    {

        yield return new WaitForSeconds(6);
        StartCoroutine(spawn());
        Instantiate(enemy[rand], new Vector3(0, 7, -1), Quaternion.identity);
        score++;
        if (score == 6)
        {

            Instantiate(spawnObj);
            Destroy(gameObject);


        }

    }



   
}
