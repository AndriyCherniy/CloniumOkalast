﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public GameObject go;

    //public float runSpeed = 40f;
    public float speed = 20f;
    //float horizontalMove = 0f;
    private Rigidbody2D rb;
    public Vector3 pos;
    public Main  Bullet;
    public float hp = 50f;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        pos = transform.position;
        PlayerPrefs.SetFloat("hp_CharacterSlot0", 100);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("x12_CharacterSlot0", hp);
        PlayerPrefs.Save();
        hp = PlayerPrefs.GetFloat("y_CharacterSlot0");
        Debug.Log(hp);
        if (hp <= 0)
        {
            Debug.Log("rfdhrfohifdghiotriohtrdhhio;fgkljf");
           
        }
        /*        if (Input.GetKey(KeyCode.UpArrow))
                {
                    pos = transform.position;
                    pos.y += 0.1f;

                    transform.position = pos;
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    pos = transform.position;
                    pos.y -= 0.1f;

                    transform.position = pos;
                    }
         */
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos = transform.position;
            pos.x += 0.1f;

            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos = transform.position;
            pos.x -= 0.1f;

            transform.position = pos;
        }

            PlayerPrefs.SetFloat("y_CharacterSlot0", pos.y);
            PlayerPrefs.SetFloat("x_CharacterSlot0", pos.x);
            PlayerPrefs.Save();


    }
}
    // Update is called once per frame
    //void Update()
    //{
    //    float h = Input.GetAxis("Horizontal");
    //    rb.MovePosition(rb.position + Vector2.right * h * speed * Time.deltaTime);
    //    if (Input.GetKeyDown(KeyCode.UpArrow))
    //    {
    //        while (Input.GetKeyDown(KeyCode.UpArrow))
    //        {
    //            rb.AddForce(Vector2.up * 100);
    //        }
    //    }
    //
    //





