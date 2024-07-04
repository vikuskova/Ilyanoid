using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private bool ballIsActive;
    [SerializeField]
    private Vector2 ballInitialForce = new Vector2(100.0f, 300.0f);
    private Rigidbody2D rb;

    public GameObject playerObject;

    void Start()
    {
        ballIsActive = false;
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
    }

    void Update()
    {
        //запуск шарф
        if (Input.GetButtonDown("Jump") && !ballIsActive)
        {
            rb.isKinematic = false;
            rb.AddForce(ballInitialForce);
            ballIsActive = true;
        }
    }
}

