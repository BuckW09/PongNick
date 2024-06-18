using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float VeloBola;
    public Rigidbody2D Rb;
    public AudioSource SomBola;

    
    // Start is called before the first frame update
    void Start()
    {
        MovimentarBola();
        
    }

    // Update is called once per frame
    void Update()
    {
        Respaw();
    }
    public void Respaw()
    {
        if (transform.position.x >= 9.55f || transform.position.x <= -9.55f)
        {
            Rb.velocity = new Vector2(VeloBola, VeloBola);
            transform.position = new Vector2(0, 0);
        }

    }
    public void MovimentarBola()
    {
        Rb.velocity = new Vector2(VeloBola, VeloBola);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //SomBola.Play();
    }
}
