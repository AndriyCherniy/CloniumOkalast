using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Rigidbody projectile;
    public Transform prefab;
    public Vector3 pos;
    

    //public float runSpeed = 40f;
    public float speed = 20f;
    //float horizontalMove = 0f;
    private Rigidbody2D rb;
    public GameObject player12;
    public GameObject player123;
    public GameObject obj;
    float y = 0;
    public float timeleft = 0f;
    public Vector3 pos1;
    public Vector3 pos2;
    public int kol = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        timeleft -= Time.deltaTime;
        //Debug.Log(timeleft);
        pos2.x = PlayerPrefs.GetFloat("x1_CharacterSlot0");
        pos2.y = PlayerPrefs.GetFloat("y1_CharacterSlot0");
        if (Input.GetKey(KeyCode.Space))
        {
            
            pos1.x = PlayerPrefs.GetFloat("x_CharacterSlot0");
            pos1.y = PlayerPrefs.GetFloat("y_CharacterSlot0");

            if (timeleft <= 0)
            {
                if (kol <= 1)
                {
                    timeleft = 0.5f;
                    Instantiate(obj, pos1, Quaternion.identity);
                    kol++;
                }
            }
        }
        pos = transform.position;
        if (pos.y >= 30f && kol > 1)
        {
            Destroy(obj);
            kol--;
        }
        if (pos2.x - 1f <= pos.x && pos2.x + 1f >= pos.x && pos2.y - 1f <= pos.y && pos2.y + 1f >= pos.y)
        {
            Destroy(player123);
            Destroy(obj);
        }

    }
    
}
