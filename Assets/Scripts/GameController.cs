using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
  
    [SerializeField] private TextMeshProUGUI textCats;
    public GameObject panelWin;
    public GameObject panelLose;

    [SerializeField] private int rescuedCats;
    private int totalCats;

    
    void Start()
    {
        totalCats = GameObject.FindGameObjectsWithTag("gato").Length;
        UpdateUI();

        panelWin.SetActive(false);
        panelLose.SetActive(false);
    }

    
    void Update()
    {
        if (rescuedCats >= totalCats)
        {
            Time.timeScale = 0f;
            Ganar();
            
        }
    }

    private void UpdateUI()
    {
        textCats.text = "Cats: " + rescuedCats.ToString() + " / " + totalCats.ToString();
 
    }

    public void ScoreUp()
    {
        rescuedCats++;
        UpdateUI();
    }

    public void ComenzarJuego(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void Ganar()
    {
        panelWin.SetActive(true);
    }

    public void Perder()
    {
        Debug.Log("Perdiste");
        panelLose.SetActive(true);
        Time.timeScale = 0f;
    }

}
