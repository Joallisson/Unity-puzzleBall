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
        SetMinAndMaxX(); 
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
