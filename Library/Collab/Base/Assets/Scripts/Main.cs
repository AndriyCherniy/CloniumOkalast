using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public GameObject go;

    //public float runSpeed = 40f;
    public float speed = 20f;
    //float horizontalMove = 0f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Vector3 pos = transform.position;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    float h = Input.GetAxis("Horizontal");
    //    rb.MovePosition(rb.position + Vector2.right * h * speed * Time.deltaTime);
    //    if (Input.GetKeyDown(KeyCode.UpArrow))
    //    {
    //        pos.y += 3f;
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * h * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            while (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.AddForce(Vector2.up * 100);
            }
        }

    }

}




