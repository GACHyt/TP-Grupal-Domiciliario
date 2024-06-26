using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class gamemanagerScript : MonoBehaviour
{
    public Transform spawnPoint1;
    public Transform spawnPoint2;

    //pase el array de productos para productoScript

    public int dinero=100;

    public GameObject objeto1;
    public GameObject objeto2;

    public Text presu;
    public Text precioUno;
    public Text precioDos;

    private int sumaProductos;

    void Start()
    {

        objeto1 = Instantiate(gameObject, spawnPoint1.position, Quaternion.identity);// corregir bien el tema  de como crear/activar el objeto
        objeto2 = Instantiate(gameObject, spawnPoint1.position, Quaternion.identity);

        int precio1= objeto1.GetComponent<productoScript>().precio;
        int precio2 = objeto1.GetComponent<productoScript>().precio;

        presu.text = $"Presupuesto: ${dinero}";
        precioUno.text = $"${precio1}";
        precioDos.text = $"${precio2}";
    }

    void Update()
    {
        
    }
}
