using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReset : MonoBehaviour
{
    private score sm;

    void Start()
    {

        sm = FindObjectOfType<score>();

    }


    public void reset()
    {

        sm.Reset();


    }











}
