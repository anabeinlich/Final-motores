using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlGato : MonoBehaviour
{
    GameController gameController;

    private int gatoSalvado;


    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameController.ScoreUp();
            Destroy(gameObject);
        }
    }
}
