using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // hola compañero estos es la funcion start
    void Start()
    {
        Debug.Log("aca es el start");
        
        gameObject.transform.position = new Vector3(-7, 4.62f, 0);
    }


    // esto es la funcion update
    void Update()
    {
        Debug.Log("aca es el update");
        //gameObject.transform.position = new Vector3(gameObject.transform.position.x + 2f * Time.deltaTime, 3.62f, 0);

        

            if (Input.GetKey("right") && (gameObject.transform.position.x < 11.82))
        {
            gameObject.transform.Translate(3.5f * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("left") && (gameObject.transform.position.x >= -11.82))
        {
            gameObject.transform.Translate(-3.5f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("up") && gameObject.transform.position.y < 4)
        {
            gameObject.transform.Translate(0, 8.5f * Time.deltaTime, 0);
        }
    }
}

