using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, MsgVitoria;
    public int moeda;
    public AudioClip clipMoeda, clipVitoria;

    private AudioSource Source;

    void Start()
    {
        TryGetComponent(out Source);
        moeda = FindObjectsOfType<Moeda>().Length;
        AtualizarHud();
    }

    public void AtualizarHud()
    {
        hud.text = $"Moedas Restantes: {moeda}";
    }


    public void SubtrairMoedas(int valor)
    {
        moeda -= valor;
        Source.PlayOneShot(clipMoeda);
        AtualizarHud();
        if (moeda <= 0)
            
        {
            MsgVitoria.text = "VAPOOOOOOOOO";
            Source.PlayOneShot(clipVitoria);
        }
    }
}    