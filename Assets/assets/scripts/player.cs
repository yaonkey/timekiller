using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class player : MonoBehaviour
{
    
    
    public Text hpDisplay;
    private Restart res;
    public GameObject Player;
    public int hp;
    
    public float timer, cd;
    public GameObject[] Damage;
    int rand;
    void Start()
    {
        
        res = FindObjectOfType<Restart>();
        
    }
    
   
    public void HP()
    {


        hp = 6;


    }
       private void OnTriggerEnter2D(Collider2D dmg)
    {
        if (dmg.CompareTag("enemy"))
        {

            hp--;
            Instantiate(Damage[rand]);
        }

        if (dmg.CompareTag("enemy2"))
        {
            Instantiate(Damage[rand]);
            hp--;
            hp--;
        }

    }


    


    public void time()
    {
        timer = cd;

        
        
    }




    void Update()
    {
        rand = Random.Range(0, Damage.Length);
        if (timer > 0)
        {
            timer -= Time.deltaTime;

        }
        if (timer <= 0)
        {
            


        }
        hpDisplay.text = "HP: " + hp.ToString();

        if (hp <= 0)
        {

            res.menu();

        }
    }
}
