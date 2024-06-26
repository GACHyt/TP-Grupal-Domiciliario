using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class gamemanagerScript : MonoBehaviour
{
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public GameObject[] productos;
    public int dinero;

    public GameObject objeto1;
    public GameObject objeto2;

    public Text uno;
    public Text dos;

    private int sumaProductos;

    void Start()
    {

        objeto1 = Instantiate(productos[0], spawnPoint1.position, Quaternion.identity);
        objeto2 = Instantiate(productos[0], spawnPoint1.position, Quaternion.identity);

        int precio1=objeto1.GetComponent<>();
    }

    void Update()
    {
        
    }
}
