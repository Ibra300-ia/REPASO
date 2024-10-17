using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI cuenta;

    float horas = 00f;
    float minutos = 00f;
    float segundos = 00f;
    float milisegundos = 00f;

    public void Pausa()
    {
        
        cuenta.text = horas.ToString(); 
    }
}
