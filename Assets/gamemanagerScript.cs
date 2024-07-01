using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Me borraron mis comits

public class gamemanagerScript : MonoBehaviour
{
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public GameObject[] productos;
    GameObject objeto1;
    GameObject objeto2;

    public int dinero=100;

    public Text presu;
    public Text precioUno;
    public Text precioDos;

    public GameObject panel;
    public GameObject boton;
    public Text result;

    private int sumaProductos;

    void Start()
    {
        juego(); 
    }

    void juego()
    {
        panel.SetActive(false);
        objeto1 = Instantiate(productos[Random.Range(0, productos.Length)], spawnPoint1.position, Quaternion.identity);// corregir bien el tema  de como crear/activar el objeto
        objeto2 = Instantiate(productos[Random.Range(0, productos.Length)], spawnPoint2.position, Quaternion.identity);

        int precio1 = objeto1.GetComponent<productoScript>().precio;
        int precio2 = objeto2.GetComponent<productoScript>().precio;

        sumaProductos = precio1 + precio2;
        dinero = Random.Range(10, 100);
        presu.text = $"Presupuesto: ${dinero}";
        precioUno.text = $"${precio1}";
        precioDos.text = $"${precio2}";
    }

    void chequeo(int a)
    { 
        panel.SetActive(true);
        if (a == 1)
        {
            if (dinero > sumaProductos)
            {
                ganaste();
            }
            else
            {
                perdiste();

            }
        }
        else if (a == 2)
        {
            if (dinero == sumaProductos)
            {
                ganaste();
            }
            else
            {
                perdiste();
            }
        }
        else if (a == 3)
        {
            if (dinero < sumaProductos)
            {
                ganaste();
            }
            else
            {
                perdiste();
            }
        }
    }

    public void alcanzaYsobra()
    {
        Debug.Log("Sobra");
        chequeo(1);
    }

    public void alcanza()
    {
        Debug.Log("eee");
        chequeo(2);
    }
    
    public void noAlcanza()
    {
        chequeo(3);
    }

    void perdiste()
    {
        result.color = Color.red;
        result.text = "Perdiste";
    }

    public void intentar2()
    {
        panel.SetActive(false);
    }

   public void salir()
    {
        SceneManager.LoadScene(1);
    }

    public void jugar2()
    {
        objeto1.SetActive(false);
        objeto2.SetActive(false);
        boton.SetActive(true);
        juego();
    }

    void ganaste()
    {
        boton.SetActive(false);
        result.text = "Ganaste";
        result.color = Color.green;
    }




}
