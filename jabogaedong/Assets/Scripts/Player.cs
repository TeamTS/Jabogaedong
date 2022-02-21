using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] points;
    int currentPoint = 0;
    public int testValue = 0;

    void Start()
    {
        transform.position = points[0].transform.position;
    }

    void Update()
    {
        
    }

    public void Move(int value)
    {
        transform.position = points[currentPoint + value].transform.position;
        currentPoint += value;
    }
}
