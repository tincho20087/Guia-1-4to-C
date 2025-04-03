using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    public int EdadUsuario;
    public float EstaturaUsuario;
    public bool esDonante;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario + " Tengo " + EdadUsuario + " Mido " + EstaturaUsuario + " es " +  esDonante  + " que soy donante de organos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
