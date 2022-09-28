using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGiraPlataforma : MonoBehaviour
{
    public string giraBotao;
    private Plataforma plataforma;
    // Start is called before the first frame update
    void Start()
    {
        plataforma = FindObjectOfType<Plataforma>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GiraPlataforma()
    {
         Debug.Log(giraBotao);
        if (giraBotao == "direita")
        {
           //plataforma.transform.Rotate(0, 0, -45);
           Debug.Log("direita");
        }
        // else if(giraBotao == "esquerda")
        // {
        //      //plataforma.transform.Rotate(0, 0, 45);
        //      Debug.Log("esquerda");
        // }
    }
}
