using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float speed;
    private float minX, maxX;
    public int maxDistancia, minDistacia;
    void Start()
    {
        //SetMinAndMaxX(); 
    }

    // Update is called once per frame
    void Update()
    {
        MovePlataforma();
    }

    private void SetMinAndMaxX(){
         //atribuindo limites do safeArea para o mundo da unity, para delimitar o limite o espaço que a plataforma pode percorrer horizontalmente
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f));
        maxX = bounds.y - maxDistancia;
        minX = -bounds.y + minDistacia;
    }

     private void VerificarMaxEMinDistacia()
    {
        
    }

    private void MovePlataforma()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) //se existir algum toque na tela e verifica se o tipo de toque na tela é do tipo movimento
        {
            Vector2 touchPosition = Input.GetTouch(0).deltaPosition;  //pegando as coordenadados do meu dedo na tela
            transform.Translate(touchPosition.x * speed * Time.deltaTime, 0f, 0f); //move a plataforma na horizontal com meu dedo
        }
    }
}
