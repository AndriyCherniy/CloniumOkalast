using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{

    Rigidbody projectile;
    public Transform prefab;
    public Vector3 pos;


    //public float runSpeed = 40f;
    public float speed = 20f;
    //float horizontalMove = 0f;
    private Rigidbody2D rb;
    public GameObject obj;
    float y = 0;
    public float timeleft = 0f;
    public Vector3 pos1;
    public int kol = 1;
    public float hp = 0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pos = transform.position;

    }
    void Update()
    {

        pos = transform.position;
        pos1.x = PlayerPrefs.GetFloat("x_CharacterSlot0");
        pos1.y = PlayerPrefs.GetFloat("y_CharacterSlot0");
        timeleft -= Time.deltaTime;
        //Debug.Log(timeleft);
        if (pos1.x - 1f <= pos.x && pos1.x + 1f >= pos.x && pos1.y - 1f <= pos.y && pos1.y + 1f >= pos.y)
        {
           Debug.Log(pos.x);
           Debug.Log(pos.y);
            Debug.Log(pos1.x);
            Debug.Log(pos1.y);
            //Destroy(this);
            Destroy(obj);
        }
    }

    

}
