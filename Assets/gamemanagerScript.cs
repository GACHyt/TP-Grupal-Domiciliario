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

    public GameObject[] productos;
   

    GameObject objeto1;
    GameObject objeto2;

    public Text presu;
    public Text precioUno;
    public Text precioDos;

    private int sumaProductos;

    void Start()
    {
        objeto1 = Instantiate(productos[Random.Range(0, productos.Length)], spawnPoint1.position, Quaternion.identity);// corregir bien el tema  de como crear/activar el objeto
        objeto2 = Instantiate(productos[Random.Range(0, productos.Length)], spawnPoint2.position, Quaternion.identity);
       
        int precio1= objeto1.GetComponent<productoScript>().precio;
        int precio2 = objeto2.GetComponent<productoScript>().precio;

        sumaProductos = precio1 + precio2;
        dinero = Random.Range(10, 100);
        presu.text = $"Presupuesto: ${dinero}";
        precioUno.text = $"${precio1}";
        precioDos.text = $"${precio2}";
    }

    
}
