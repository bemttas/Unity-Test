using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject3D : MonoBehaviour
{
    public float rotationSpeed = 25f; // Velocidade de rotação

    void Update()
    {
        // Rotaciona em torno do eixo Y no tempo baseado em deltaTime
        transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
    }
}

