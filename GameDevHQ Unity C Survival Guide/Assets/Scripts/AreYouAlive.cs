using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreYouAlive : MonoBehaviour
{
    public GameObject Player;
    public int _health;
    public Vector3[] positions;
    private int _randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        _randomIndex = GetRandom();
        _health = 10000;
        Debug.Log("Random Index: " + _randomIndex);

    }

    int GetRandom()
    {
        return Random.Range(0, positions.Length);
    }

    Vector3 GetPosition(int index)
    {
        return positions[index];

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsDead() == false)
        {
            _randomIndex = GetRandom();
            Player.GetComponent<Transform>().transform.position = GetPosition(_randomIndex);
            Damage(Random.Range(1, 10));
        }
    }

    private void Damage(int damageAmount)
    {
        _health -= damageAmount;
        Debug.Log("Player HP: " + _health);
        if (IsDead() == true) 
        {
            _health = 0;
            Debug.Log("The player has died");
        }
    }
    public bool IsDead()
    {
        return _health < 1;
    }

    





}
