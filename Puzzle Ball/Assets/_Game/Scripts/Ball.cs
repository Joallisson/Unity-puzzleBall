using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        float speedX = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector3(speed * speedX, speed * 1, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision otherObject) 
    {
        if(otherObject.gameObject.tag == "GameOver")
        {
            Destroy(this.gameObject);
        }
        else if(otherObject.gameObject.tag == "BlocoPoint")
        {
            Destroy(otherObject.gameObject);
        }
    }
}
