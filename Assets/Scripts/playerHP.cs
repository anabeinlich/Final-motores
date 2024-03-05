using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHP : MonoBehaviour
{
    public int hp;

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
            recibirDa�o();
        }
    }

    public void recibirDa�o()
    {
        hp -= 1;
        Debug.Log("recibiste un golpe");

        if (hp <= 0)
        {
            gameController.Perder();
        }
    }
}
