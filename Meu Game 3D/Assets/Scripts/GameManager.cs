using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{


    public TextMeshProUGUI hud, MsgVitoria;
    public int restantes;
    
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;

        hud.text = $"Moedas Restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;

        if (restantes <= 0)
        {
            MsgVitoria.text = "VAPOOOO";
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
