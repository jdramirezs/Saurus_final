using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_2 : MonoBehaviour
{
    public float velocidad;
    public float multiplicador;
    public Rigidbody2D rb;
    private float minMax = 50f;
    public float fuerzaSalto;
    private bool saltando;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            saltando = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float entradaTeclado = Input.GetAxis("Horizontal");
        rb.AddForce(Vector2.right * velocidad * multiplicador * entradaTeclado);
        float limitador = Mathf.Clamp(rb.velocity.x, -minMax, minMax);
        rb.velocity = new Vector2(limitador, rb.velocity.y);
        if (saltando)
        {
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            saltando = false;
        }

    }
}
