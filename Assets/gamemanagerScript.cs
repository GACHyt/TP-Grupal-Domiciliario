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

    public GameObject[] productosGenerator1;
    public GameObject[] productosGenerator2;

    GameObject obj1, obj2;

    GameObject objeto1;
    GameObject objeto2;

    public Text presu;
    public Text precioUno;
    public Text precioDos;

    private int sumaProductos;

    void Start()
    {
        //productosGenerator2[Random.Range(0, productosGenerator2.Length)].SetActive(true);
        obj1 = productosGenerator1[Random.Range(0, productosGenerator1.Length)];
        obj1.SetActive(true);
        obj2 = productosGenerator2[Random.Range(0, productosGenerator2.Length)];
        obj2.SetActive(true);
       
        objeto1 = Instantiate(obj1, spawnPoint1.position, Quaternion.identity);// corregir bien el tema  de como crear/activar el objeto
        objeto1.transform.localScale = new Vector3(10, 10, 10);

        objeto2 = Instantiate(obj2, spawnPoint2.position, Quaternion.identity);
        objeto2.transform.localScale = new Vector3(10, 10, 10);

        int precio1= objeto1.GetComponent<productoScript>().precio;
        int precio2 = objeto2.GetComponent<productoScript>().precio;

        presu.text += $"Presupuesto: ${dinero}";
        precioUno.text += $"${precio1}";
        precioDos.text += $"${precio2}";
    }

    void Update()
    {
        
    }
}
