using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderHP : MonoBehaviour
{
    GameController gameController;

    private int hp;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        hp = 100;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void recibirDaño() 
    {
        hp -= 25;

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {

            Debug.Log("Pego una bala");

            Destroy(collision.gameObject);

            recibirDaño();
        }
    }
}
