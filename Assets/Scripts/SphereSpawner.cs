using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    public GameObject spherePrefab; // Prefab da esfera
    public int sphereCount = 0; // Número de esferas
    public float spawnInterval = 0.005f; // Intervalo entre cada esfera cair
    public float spawnHeight = 10.0f; // Altura inicial para as esferas
    public float spawnRangeX = 5; // Intervalo aleatório no eixo X
    public float spawnRangeZ = 5; // Intervalo aleatório no eixo Z

    private int spheresSpawned = 0;
    private float elapsedTime = 0.0f;

    void Update()
    {
        // Atualiza o tempo decorrido
        elapsedTime += Time.deltaTime;

        // Checa se deve instanciar uma nova esfera
        if (spheresSpawned < sphereCount && elapsedTime >= spawnInterval)
        {
            // Gera uma posição de spawn aleatória dentro do range definido
            float randomX = Random.Range(-spawnRangeX, spawnRangeX);
            float randomZ = Random.Range(-spawnRangeZ, spawnRangeZ);
            Vector3 spawnPosition = new Vector3(randomX, spawnHeight, randomZ);
            
            // Instancia a esfera na posição aleatória
            Instantiate(spherePrefab, spawnPosition, Quaternion.identity);

            // Incrementa o número de esferas geradas
            spheresSpawned++;
            
            // Reseta o tempo decorrido
            elapsedTime = 0.0f;
        }
    }
}
