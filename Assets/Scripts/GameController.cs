using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ComenzarJuego(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void Perder()
    {
        Debug.Log("Perdiste");
    }

}
