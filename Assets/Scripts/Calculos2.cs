using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculos2 : MonoBehaviour
{
    public float num1;
    public float num2;
    public float resultado;

    // Start is called before the first frame update
    void Start()
    {   resultado = num1 + num2;
        Debug.Log("El resultado de la suma entre los numeros es: " + num1 + "y" + num2 + "es" + resultado);
        resultado = num1 - num2;
        Debug.Log("El resultado de la resta entre los numeros es: " + num1 + "y" + num2 + "es" + resultado);
        resultado = num1 * num2;
        Debug.Log("El resultado de la multiplicacion entre los numeros es: " + num1 + "y" + num2 + "es" + resultado);
        resultado = num1 / num2;
        Debug.Log("El resultado de la division entre los numeros es: " + num1 + "y" + num2 + "es" + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
