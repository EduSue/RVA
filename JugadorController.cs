using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorController: MonoBehaviour
{

    public float speed = 0.5f * 10;

    // void Start(){

    // }

    void Update(){
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movHorizontal, 0.0f, movVertical);       

        transform.Translate(movimiento * speed * Time.deltaTime);


        if (Input.GetMouseButtonDown(0))
        {
            movimiento = new Vector3(0, 10f, 0);
            transform.Translate(movimiento * speed * Time.deltaTime);
        }
    }
}
