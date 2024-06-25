using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class productoScript : MonoBehaviour
{
    public int precio;
    void Start()
    {
        precio = Random.Range(1, 100);
    }

    void Update()
    {
        
    }
}