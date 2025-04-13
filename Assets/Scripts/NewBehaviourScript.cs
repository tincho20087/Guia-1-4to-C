using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int Año;
    public string nombreAlumno;
    public string orientacion;

   
    // Start is called before the first frame update
    void Start()
    {

       if (string.IsNullOrEmpty(nombreAlumno))
        {
            Debug.Log("Nombre no válido");
            return;
        }

        if (Año < 3 || Año > 5)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
            return;
        }

        if (orientacion == "G" || orientacion == "T" || orientacion == "H" || orientacion == "M" || orientacion == "D")
        {
            Debug.Log("Muchas gracias " + nombreAlumno);
        }
        else
        {
            Debug.Log("Orientación no válida");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
