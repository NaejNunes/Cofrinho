﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaFase : MonoBehaviour
{   
    public string nomeFase;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TrocarFase()
    {
        SceneManager.LoadScene(nomeFase);
    }
   
}