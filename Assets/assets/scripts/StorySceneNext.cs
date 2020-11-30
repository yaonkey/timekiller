using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StorySceneNext : MonoBehaviour
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

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        }
    }
}
