using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPlayer : MonoBehaviour
{
    public float rapidezDesplazamiento = 10.0f;
    public float rapidezCorrer = 17.0f;
    public float dejarDeCorrer = 10.0f;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked; 
    }

    
    void Update()
    {
        float movimientoAdelanteAtras = Input.GetAxis("Vertical") * rapidezDesplazamiento;
        float movimientoCostados = Input.GetAxis("Horizontal") * rapidezDesplazamiento;

        movimientoAdelanteAtras *= Time.deltaTime;
        movimientoCostados *= Time.deltaTime;

        transform.Translate(movimientoCostados, 0, movimientoAdelanteAtras);

        if (Input.GetKey(KeyCode.W))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKey("left ctrl"))
        {
            rapidezDesplazamiento = rapidezCorrer;
        } 
        else
        {
            rapidezDesplazamiento = dejarDeCorrer;
        }

        
    }
}
