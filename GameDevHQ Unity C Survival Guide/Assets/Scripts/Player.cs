using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject _PlayerPrefab;
    private int _score;
    [SerializeField]
    private float _speed;
    private int _speedState;

    //create a program that let's you increment the speed when you git the s key
    // a key decrements the speed 
    // when the speed is great than 20 you need to print out "slow down"
    // when the speed is 0 print out you need to speed up!
    // you can't go below zero.




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        Accelerate();
        ScoreCounter();
        CubeColor();
    }


    void Accelerate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _speed += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _speed -= 1;
        }
        if (_speed < 0)
        {
            _speed = 0;
        }
        if (_speed > 20)
        {
            Debug.Log("SLOW DOWN!");
        }
        if (_speed == 0)
        {
            Debug.Log("SPEED UP");
        }
    }



    void ScoreCounter()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _score = _score + 10;
        }
    }

    void CubeColor()
    {
        if (_score >= 50)
        {
            _PlayerPrefab.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if (_score <50)
        {
            _PlayerPrefab.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

}
