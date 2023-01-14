using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    protected Rigidbody2D rb;
    

    void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

}
