﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroMayor : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 > num2)
        {
            Debug.Log("El mayor de los dos números ingresados es: " + num1);
        }
        else if (num1 < num2)
        {
            Debug.Log("El mayor de los dos números ingresados es: " + num2);
        }
        else
        {
            Debug.Log("Los números ingresados son iguales.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
