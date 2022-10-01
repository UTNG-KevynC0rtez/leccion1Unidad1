/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Cortez Ramirez Jose Kevyn
* Fecha: 28 de septiembre del 2022
* Funcion de Script: El script es para que el carro se mueva y el usuario lo pueda controlar
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float velocidad = 30;

    public float giro = 20;

    private float girar;

    private float avanzar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        avanzar = Input.GetAxis("Vertical");
        girar = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanzar);
        transform.Rotate(Vector3.up, Time.deltaTime*giro*girar);
    }
}
