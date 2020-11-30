using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mob : MonoBehaviour
{
    public int hp;
    private score sm;
    Animator slime;
    public GameObject effect;
    public GameObject shot;

    void Start()
    {
        slime = GetComponent<Animator>();
        sm = FindObjectOfType<score>();

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
        slime.SetBool("damage", true);
        Instantiate(shot);
        Instantiate(effect, transform.position, Quaternion.identity);

    }

    void OnMouseUp()
    {
       
        slime.SetBool("damage", false);



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
