using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Monedas2 : MonoBehaviour
{
    public int Contador;
    public Text Puntuacion;
    public GameObject win;

    Rigidbody rb;




    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Contador = Contador + 1;
        Puntuacion.text = " " + Contador;
        actualizarmarcador();
        if (Contador >= 8)
        {
            win.gameObject.SetActive(true);
        }

    }

    private void actualizarmarcador()
    {
        Puntuacion.text = " " + Contador;
    }

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Contador = 0;
        actualizarmarcador();
        win.gameObject.SetActive(false);
    }

}