using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    private ButtonGiraPlataforma botaoGiraPlataforma;
    // Start is called before the first frame update
    void Start()
    {
        botaoGiraPlataforma = FindObjectOfType<ButtonGiraPlataforma>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonGiraPlataforma()
    {
        botaoGiraPlataforma.GiraPlataforma();
    }
}
