using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class playerHP : MonoBehaviour
{
    public int hp;
    [SerializeField] private TextMeshProUGUI textLife;

    GameController gameController;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        hp = 200;

    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            RecibirDaño();
            textLife.text = "Life: " + hp.ToString();
        }
    }

    public void RecibirDaño()
    {
        hp -= 25;
        Debug.Log("recibiste un golpe");

        if (hp <= 0)
        {
            gameController.Perder();
        }
    }
}
