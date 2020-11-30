using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    
    private Canvas endMenu;
    private ShowAd ad;
    private player pl;
    public GameObject restartON;
    public GameObject DESTROYERRRRRR;
    private openmenu menuScript;


    void Start()
    {

        menuScript = FindObjectOfType<openmenu>();
        pl = FindObjectOfType<player>();
        ad = FindObjectOfType<ShowAd>();
        Time.timeScale = 1f;
        endMenu = GetComponent<Canvas>();
        if(Advertisement.isSupported)
        {

            Advertisement.Initialize("3914935", false);


        }
    }

    

    public void Heal()

    {
        
        pl.HP();
        menuScript.closeM();
        if (Advertisement.IsReady())
        {

            ShowAd.AdShow();
            
        }

        Instantiate(DESTROYERRRRRR);
        Time.timeScale = 1f;
        endMenu.enabled = false;


        


    }

    

    public void menu()
    {
        pl.time();


        Time.timeScale = 0f;
        endMenu.enabled = true;
        


    }

   

    public void Rest()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }



}
