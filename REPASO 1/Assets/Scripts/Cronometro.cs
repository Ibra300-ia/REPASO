using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI cuenta;

    float tiempo = 0.0f;

    private void Update()
    {
        cuenta.text = tiempo.ToString(); 
    }
}
