using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject _playerPrefab;
    private bool _isPlayerObjectSpawned = false;
    public bool _isPlayerAlive = false;
    public int _playerLives;
    public float _playerSpeed = 10.0f;
    public float _playerRotationSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPlayer();
        //Movement();
    }

    private void SpawnPlayer()
    {
        

        if (_isPlayerObjectSpawned == false)
        {
            
            if (_isPlayerAlive == false && _playerLives <=1)
            {
                Vector3 spawnPosition = new Vector3(0f, 0f, 0f);
                GameObject newPlayer = Instantiate(_playerPrefab, spawnPosition, Quaternion.identity);
                newPlayer.AddComponent<Player>();
                _isPlayerAlive = true;
                _isPlayerObjectSpawned = true;
                _playerLives = 100;
                Debug.Log("Player Spawned");
                if (_isPlayerAlive == false && _playerLives <= 0)
                {
                    Destroy(newPlayer);
                }
            }
        }
        if (_playerLives <= 0 && _isPlayerAlive == false)
        {
            ReturnToCheckpoint();
        }
        

    }

    public void ReturnToCheckpoint()
    {

    }

    public void Movement()
    {
        float translation = Input.GetAxis("Vertical") * _playerSpeed;
        float rotation = Input.GetAxis("Horizontal") * _playerRotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        
    }


}
