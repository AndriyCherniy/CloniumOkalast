using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Threading;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 pos1;
    private Rigidbody2D rb;
    public Vector3 pos;
    public GameObject obj;
    public GameObject player;
    public GameObject player1;
    public float timeleft = 1f;
    public float kol = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        pos1.x = PlayerPrefs.GetFloat("x_CharacterSlot0");
        pos1.y = PlayerPrefs.GetFloat("y_CharacterSlot0");
        PlayerPrefs.SetFloat("x1_CharacterSlot0", pos.x);
        PlayerPrefs.SetFloat("y1_CharacterSlot0", pos.y);
        PlayerPrefs.Save();


        if (kol == 0)
            {
                if (pos1.x != pos.x)
                {
                    if (pos1.x < pos.x)
                    {
                        pos = transform.position;
                        pos.x -= 0.1f;

                        transform.position = pos;
                    }

                    else
                    {
                        pos = transform.position;
                        pos.x += 0.1f;

                        transform.position = pos;
                    }


                }
                if (pos.y > pos1.y)
                {
                    if (timeleft <= 0)
                    {
                        kol++;
                        timeleft = 1f;
                        Instantiate(obj, pos, Quaternion.identity);
                    }
                }
                if (pos1.x - 1f <= pos.x && pos1.x + 1f >= pos.x && pos1.y - 1f <= pos.y && pos1.y + 1f >= pos.y)
                {
                    kol--; 
                    Destroy(player1);
                    Destroy(player);
                }
            }
        }

    
}
