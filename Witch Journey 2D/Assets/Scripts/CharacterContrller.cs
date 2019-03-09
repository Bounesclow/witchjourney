using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterContrller : MonoBehaviour
{

    Vector2 posInicial;
    float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            //if (touch.phase == TouchPhase.Moved) Debug.Log("Moved " + touch.position);
            //if (touch.phase == TouchPhase.Began) Debug.Log(touch.position);
            //if (touch.phase == TouchPhase.Ended)
            //  Debug.Log(touch.position);
            //Debug.Log(touch.position);

            //Debug.Log("POS FINAL" +touch.position);
            //Debug.Log("POS INICIAL"+posInicial.x);
            //Debug.Log("RESTA" + (touch.position.x - posInicial.x));
            
            if (touch.phase == TouchPhase.Began)
            {
                posInicial = touch.position;
            }

            if (touch.position.x - posInicial.x >= 100)
            {
                Debug.Log("DERECHA");
             
                transform.Translate(Vector2.right * Time.deltaTime * velocidad);
            }
            else if(touch.position.x - posInicial.x <= -100)
            {
                Debug.Log("IZQUIERDA");
                
                transform.Translate(Vector2.left * Time.deltaTime * velocidad);
            }


            if (touch.position.y - posInicial.y >= 100)
            {
                Debug.Log("ARRIA");
                
                transform.Translate(Vector2.up * Time.deltaTime * velocidad);
            }
            else if (touch.position.y - posInicial.y <= -100)
            {
                Debug.Log("AAJO");
               
                transform.Translate(Vector2.down * Time.deltaTime * velocidad);

            }


        }
        //Debug.Log(posInicial);
        


    }
}
