using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mob1 : MonoBehaviour
{
    public int hp;
    private score sm;
    Animator walker;
    public GameObject effect;
    public GameObject shot;
    public GameObject expl;
    void Start()
    {
        walker = GetComponent<Animator>();
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
        walker.SetBool("damage", true);
        Instantiate(shot);
        Instantiate(effect, transform.position, Quaternion.identity);

    }

    void OnMouseUp()
    {
        walker.SetBool("damage", false);



    }



    private void Update()
    {
        


        if (hp == 0)
        {
            Instantiate(expl, transform.position, Quaternion.identity);
            sm.kill();
            Destroy(gameObject);
            



        }
        
      

    }




    
    
}
