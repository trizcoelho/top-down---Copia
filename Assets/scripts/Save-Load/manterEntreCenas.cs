﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manterEntreCenas : MonoBehaviour
{
    //private void Start()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}
    private void OnLevelWasLoaded(int level)
    {
        string CaminhoCena = SceneUtility.GetScenePathByBuildIndex(level);//pega o caminho da cena na pasta de arquivos
        string cena = CaminhoCena.Substring(0, CaminhoCena.Length - 6).Substring(CaminhoCena.LastIndexOf('/') + 1);
        if (cena != "Menu")
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);
    }
}
