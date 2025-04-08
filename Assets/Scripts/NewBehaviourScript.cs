using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float montoAconvertir;
    public string codmoneda;

    float montoconv;
    float cotizacion;
    // Start is called before the first frame update
    void Start()
    {
        if (montoAconvertir < 1000)
        {
            Debug.Log("El monto minimo es 1000");
            return;
        }

        if (codmoneda == "D")
        {
            cotizacion = 1134.5f;
        }

        else if (codmoneda == "R")
        {
            cotizacion = 211.1f;
        }

        else if (codmoneda == "E")
        {
            cotizacion = 1397.16f;
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }


        montoAconvertir = montoAconvertir / cotizacion;

        Debug.Log("Monto convertido " + montoAconvertir);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
