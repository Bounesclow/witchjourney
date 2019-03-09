using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 posInicial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
           Touch touch = Input.GetTouch(0);
            //if (touch.phase == TouchPhase.Moved) Debug.Log("Moved " + touch.position);
            //if (touch.phase == TouchPhase.Began) Debug.Log(touch.position);
            //if(touch.phase == TouchPhase.Ended)
            //Debug.Log(touch.position);

            if(touch.phase == TouchPhase.Began){
                posInicial = touch.position;
            }

            Debug.Log(posInicial);

            
        }
        

    }
}       
