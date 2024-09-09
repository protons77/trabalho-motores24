using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, MsgVitoria;
    public int moeda;
    void Start()
    {
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
        AtualizarHud();
        if (moeda <= 0)
        {
                MsgVitoria.text = "VAPOOOOOOOOO";
        }
        
    }
