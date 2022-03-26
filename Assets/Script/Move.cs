using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("Botão W foi pressionado");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Botão S foi pressionado");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Botão D foi pressionado");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Botão A foi pressionado");
        }
    }
}
