using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public GameObject cam;

    private Rigidbody2D rb;


    void Start()
    {
        cam.transform.localScale = new Vector3(0.1f, 0.1f, 1f);
    }


    void Update()
    {



    }
}