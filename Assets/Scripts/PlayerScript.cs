using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerScript : MonoBehaviour
{
    public float boundary;
    public float playerVelocity;
    private Vector3 playerPosition;

    
    void Start()
    {
        //начальная позиция платформы
        playerPosition = gameObject.transform.position;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        //горизонтальное движение
        playerPosition.x += Input.GetAxis("Horizontal") * playerVelocity;

        //границы
        if (playerPosition.x < -boundary)
        {
            playerPosition = new Vector3(-boundary, playerPosition.y, playerPosition.z);
        }
        if (playerPosition.x > boundary)
        {
            playerPosition = new Vector3(boundary, playerPosition.y, playerPosition.z);
        }

        //обновиление позиции платформы
        transform.position = playerPosition;
    }
}




