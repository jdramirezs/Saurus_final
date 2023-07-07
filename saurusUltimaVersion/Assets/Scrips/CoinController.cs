using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("coin");
        if (SceneManager.GetActiveScene().name == "Nivel1")
        {
            SceneManager.LoadScene("Nivel2");
        }
        if (SceneManager.GetActiveScene().name == "Nivel2")
        {
            SceneManager.LoadScene("Nivel3");
        }
        if (SceneManager.GetActiveScene().name == "Nivel3")
        {
            SceneManager.LoadScene("Menu_Inicio");
        }

    }
}
