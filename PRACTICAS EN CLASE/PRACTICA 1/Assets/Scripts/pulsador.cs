using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pulsador : MonoBehaviour
{
    float contador = 0.0f;
    float pulsacion = 0;

    [SerializeField]
    TextMeshProUGUI TiempoTexto;

    private void Update()
    {
        contador = contador + Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pulsacion++;
            if (pulsacion == 1)
            {
                contador = 0.0f;
            } else if (pulsacion == 2)
            {
                TiempoTexto.text = contador.ToString();
                pulsacion = 0;
            }
        }
    }
}
