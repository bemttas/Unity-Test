using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class CameraMover : MonoBehaviour
{
    public float moveSpeed = 5.0f;  // Velocidade de movimento da mera
    public float limitX = 50.0f;    // Limite no eixo X
    public float limitZ = 50.0f;    // Limite no eixo Z

    private bool isMoving = true;

    void Update()
    {
        // Adiciona o FPS atual  lista de amostras
        float currentFPS = 1.0f / Time.deltaTime;
        Debug.Log($"FPS Atual: {currentFPS:F2}");
        // Move a cmera enquanto estiver dentro dos limites
        if (isMoving)
        {
            if (transform.position.x < limitX && transform.position.z < limitZ)
            {
                transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, moveSpeed * Time.deltaTime);
            }
            else
            {
                isMoving = false; // Para o movimento quando os limites so alcanados
            }
        }
    }

}
