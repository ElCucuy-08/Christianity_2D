using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    // Правая граница зоны появления объектов
    public GameObject RightSide;

    // Список префабов для спавна (например, рыба, бомба и т.д.)
    public GameObject[] items;

    // Задержка перед первым появлением и интервал между следующими
    public float startDelay, repeatRate;

    void Start()
    {
        // Периодически вызываем метод Spawn() с заданным интервалом
        InvokeRepeating("Spawn", startDelay, repeatRate);
    }

    void Spawn()
    {
        // Случайная позиция по X между текущим объектом (Spawner) и RightSide
        Vector3 pos = new Vector3(
            Random.Range(transform.position.x, RightSide.transform.position.x),
            transform.position.y,
            0
        );

        // Создаём случайный объект из списка на вычисленной позиции
        Instantiate(items[Random.Range(0, items.Length)], pos, transform.rotation);
    }
}
