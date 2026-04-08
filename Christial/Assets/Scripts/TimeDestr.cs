using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestr : MonoBehaviour
{
    // Сколько секунд объект будет жить
    public float aliveTimer = 5f;

    // Вызывается при запуске
    void Start()
    {
        Destroy(gameObject, aliveTimer);
    }
}
