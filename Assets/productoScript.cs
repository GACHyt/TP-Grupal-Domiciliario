using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class productoScript : MonoBehaviour
{
    public int precio;
    public GameObject[] productosGenerator;

    void Start()
    {
        productosGenerator[Random.Range(0, productosGenerator.Length)].SetActive(true);
        precio = Random.Range(1, 100);
    }

    void Update()
    {
        
    }
}