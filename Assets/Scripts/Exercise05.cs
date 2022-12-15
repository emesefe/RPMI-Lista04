using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise05 : MonoBehaviour
{
    private bool IsOutOfBounds(float limX, float limY, float limZ)
    {
        Vector3 pos = transform.position;
        if (pos.x < -limX || pos.x > limX ||
            pos.y < -limY || pos.y > limY ||
            pos.z < -limZ || pos.z > limZ)
        {
            // Si entramos aquí es porque nos salimos de los límites en x, y o z
            return false;
        }
        
        // Si llegamos aquí es porque estamos dentro de los límites
        return true;
    }
}
