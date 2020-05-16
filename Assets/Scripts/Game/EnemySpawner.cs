using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> enemies;
    private float elapsed = 0;
    private float limitDerecha;
    private float limitIzquierda;
    void Start()
    {
        limitDerecha = UIManager.instance.limitDerecha;
        limitIzquierda = UIManager.instance.limitIzquierda;
    }

    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= 2f)
        {
            int index = Random.Range(0, enemies.Count);
            Instantiate(enemies[index], ReturnRandomPosition(), Quaternion.identity);
            elapsed = 0;
        }
    }

    Vector3 ReturnRandomPosition()
    {
        float posX = Random.Range(limitIzquierda, limitDerecha);
        Vector3 Position = transform.position;
        Position.x = posX;
        return Position;
    }
}

