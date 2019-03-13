using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterContrller : MonoBehaviour
{

    public Vector2 posicionInicial;
    public float posicionAnteriorX;
    public float posicionAnteriorY;
    public float posicionFinalX;
    public float posicionFinalY;
    public int valorOperacionX;
    public int valorOperacionY;

    public float velocidad;


    // Start is called before the first frame update
    void Start()
    {
        posicionAnteriorX = 0.0f;
        posicionAnteriorY = 0.0f;
        velocidad = 6.0f;
        valorOperacionX = 1;
        valorOperacionY = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                posicionInicial = touch.position;
                posicionAnteriorX = 0.0f;
                posicionAnteriorY = 0.0f;
            }

            if(touch.phase == TouchPhase.Moved)
            {
                posicionFinalX = touch.position.x - posicionInicial.x;
                Debug.Log("Posicion X : " + posicionFinalX);
                posicionFinalY = touch.position.y - posicionInicial.y;
                if(posicionFinalX >= 1)
                {
                    Debug.Log("DERECHA");
                    this.transform.Translate(Vector2.right * Time.deltaTime * velocidad);
                }
                else if(posicionFinalX <= -1)
                {
                    Debug.Log("IZQUIERDA");
                    this.transform.Translate(Vector2.left * Time.deltaTime * velocidad);
                }
                if(posicionFinalY >= 1)
                {
                    Debug.Log("ARRIBA");
                    this.transform.Translate(Vector2.up * Time.deltaTime * velocidad);
                }
                else if(posicionFinalY <= -1)
                {
                    Debug.Log("ABAJO");
                    this.transform.Translate(Vector2.down * Time.deltaTime * velocidad);
                }

                if(posicionAnteriorX - touch.position.x > 0)
                {
                    valorOperacionX = 1;
                }
                else if(posicionAnteriorX - touch.position.x < 0)
                {
                    valorOperacionX = -1;
                }

                if(posicionAnteriorY - touch.position.y > 0)
                {
                    valorOperacionY = 1;
                }
                if(posicionAnteriorY - touch.position.y < 0)
                {
                    valorOperacionY = -1;
                }

                if(valorOperacionX * 1 > 0)
                {
                    posicionAnteriorX = touch.position.x;
                }
                else if(valorOperacionX * 1 < 0)
                {
                    posicionInicial = touch.position;
                    valorOperacionX = 1;
                    valorOperacionY = 1;
                    posicionAnteriorX = 0.0f;
                    posicionAnteriorY = 0.0f;
                }

                if(valorOperacionY * 1 > 0)
                {
                    posicionAnteriorY = touch.position.y;
                }
                else if(valorOperacionY * 1 < 0)
                {
                    posicionInicial = touch.position;
                    valorOperacionX = 1;
                    valorOperacionY = 1;
                    posicionAnteriorX = 0.0f;
                    posicionAnteriorY = 0.0f;
                }

                /*
              Debug.Log("Me muevo");
              if (touch.position.x - posInicial.x >= 100)
              {
                  Debug.Log("DERECHA");

                  transform.Translate(Vector2.right * Time.deltaTime * velocidad);
              }
              else if (touch.position.x - posInicial.x <= -100)
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

      }
      */
            }
        }
    }
}
