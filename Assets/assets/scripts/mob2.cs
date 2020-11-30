using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mob2 : MonoBehaviour
{
    public int hp;
    private score sm;
    public GameObject effect;
    public Vector3 startPos;
    public Vector3 endPos;
    public float step;
    private float progressStart;
    private float progressEnd;
    public float timerstart, timerend, timerdes, cdstart, cdend, cddes;
    public GameObject shot;

    void Start()
    {
        
        sm = FindObjectOfType<score>();
        transform.position = startPos;
        timerstart = cdstart;
        timerend = cdend;
        timerdes = cddes;
    }

    void FixedUpdate()
    {
        if (timerstart > 0)
        {
            timerstart -= Time.deltaTime;

        }
        if (timerstart <= 0)
        {

            transform.position = Vector3.Lerp(startPos, endPos, progressStart);
           
            progressStart += step;
        }

        if (timerend > 0)
        {
            timerend -= Time.deltaTime;

        }
        if (timerend <= 0)
        {

            
            transform.position = Vector3.Lerp(endPos, startPos, progressEnd);
            progressEnd += step;
        }


        if (timerdes > 0)
        {
            timerdes -= Time.deltaTime;

        }
        if (timerdes <= 0)
        {

            Destroy(gameObject);

          
        }

    }


    private void OnTriggerEnter2D(Collider2D dmg)
    {
        if (dmg.CompareTag("Finish"))
        {

            Destroy(gameObject);

        }



    }

    private void OnMouseDown()
    {

        hp--;
        Instantiate(shot);

        Instantiate(effect, transform.position, Quaternion.identity);

    }

   



    private void Update()
    {
        


        if (hp == 0)
        {
            
            sm.kill();
            Destroy(gameObject);
            



        }
        
      

    }




    
    
}
