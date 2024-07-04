using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public int hitsToKill = 1;
    public int points;
    private int numberOfHits;

    void Start()
    {
        numberOfHits = 0;
    }

    //������� ���������� ����� ���� ������ ������������ � ������
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            numberOfHits++;

            if (numberOfHits == hitsToKill)
            {
               
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }
}