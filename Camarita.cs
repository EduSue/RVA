using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camarita : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 2, -10);
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = player.position + offset;        
    }
}
