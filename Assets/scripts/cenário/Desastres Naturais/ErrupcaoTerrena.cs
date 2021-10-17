﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrupcaoTerrena : MonoBehaviour
{
    [SerializeField] private float dano;
    [SerializeField] private int qntdHits;
    [SerializeField] private float intervalo;
    [SerializeField] private float tempoStun;
    [SerializeField] private float forca;

    private void Start()
    {
        desastreManager.Instance.errupcoesEmCena.Add(this.gameObject);
    }
    private void ativarGaiser()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }
    private void DestruirObjeto()
    {
        desastreManager.Instance.errupcoesEmCena.Remove(this.gameObject);
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //StartCoroutine(jogadorScript.Instance.DanoContinuo(dano, intervalo, qntdHits));
            jogadorScript.Instance.mudancaRelogio(dano);
            //jogadorScript.Instance.Knockback(tempoStun, forca, this.transform);
            StartCoroutine(jogadorScript.Instance.Knockback(tempoStun, forca, this.transform));
        }
    }
}
