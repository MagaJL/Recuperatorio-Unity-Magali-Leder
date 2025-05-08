using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalabraSecreta : MonoBehaviour
{
    public string palabraSecreta;
    // Start is called before the first frame update
    void Start()
    {
        if (palabraSecreta == "domingo")
        {
            Debug.Log("Has adivinado la palabra.");
        }
        else
        {
            Debug.Log("Palabra incorrecta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
