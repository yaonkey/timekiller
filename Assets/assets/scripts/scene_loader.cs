using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_loader : MonoBehaviour
{

    private ShowAd ad;

    void Start()
    {
        ad = FindObjectOfType<ShowAd>();



    }

    public void game()
    {
        ShowAd.AdShow(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);




    }
}
