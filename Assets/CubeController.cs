﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -0.2f;

    // 消滅位置
    private float deadLine = -10;

    public AudioSource sound1;

    private GameObject unitychan;

    // Use this for initialization
    void Start()
    {
        this.unitychan = GameObject.Find("UnityChan2D");

        sound1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "cubetag")
        {

            sound1.PlayOneShot(sound1.clip);


        }
    }
}

