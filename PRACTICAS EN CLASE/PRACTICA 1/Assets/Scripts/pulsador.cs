using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pulsador : MonoBehaviour
{
    float contador = 0.0f;
    bool Tiempo = true;
    float pulsacion = 0;

    [SerializeField]
    TextMeshProUGUI TiempoTexto;

    private void Update()
    {
        contador = contador + Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (Tiempo == true)
            {
                TiempoTexto.text = contador.ToString();
                
            }
            
        }
    }
}
