using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    private Vector3 RandomVector(float lower, float upper)
    {
        float xRandom = Random.Range(lower, upper);
        float yRandom = Random.Range(lower, upper);
        float zRandom = Random.Range(lower, upper);
        
        return new Vector3(xRandom, yRandom, zRandom);
    }
}
