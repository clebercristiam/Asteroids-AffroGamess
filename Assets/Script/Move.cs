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
            Debug.Log("Bot�o W foi pressionado");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Bot�o S foi pressionado");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Bot�o D foi pressionado");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Bot�o A foi pressionado");
        }
    }
}
