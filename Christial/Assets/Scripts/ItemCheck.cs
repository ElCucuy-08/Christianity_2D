using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemCheck : MonoBehaviour
{
    // Переменная для хранения текущего счёта
    public int score;

    // Сюда в инспекторе перетащи объект Score (наш текст на Canvas)
    public GameObject scoreTextObject;

    // Внутренняя ссылка на компонент TMP_Text, чтобы потом менять текст
    private TMP_Text tmpText;

    // Поле для аудиофайла "ок"
    public AudioClip okSound;

    // Поле для аудиофайла "взрыв"
    public AudioClip boomSound;

    // Переменная для ссылки на аудиопроигрыватель
    private AudioSource audioSource;

    void Start()
    {
        // Находим компонент TMP_Text на объекте Score
        tmpText = scoreTextObject.GetComponent<TMP_Text>();

        // Находим компонент AudioSource на этом объекте
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        LoadMenu();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // Воспроизводим звук в зависимости от тега
        if (other.tag == "Bibl")
        {
            audioSource.PlayOneShot(okSound);
        }
        else if (other.tag == "Bomb")
        {
            audioSource.PlayOneShot(boomSound);
        }

        // Если поймали объект с тегом "Good", увеличиваем счёт на 10
        if (other.gameObject.tag == "Bibl")
        {
            score += 10;
            // Убираем предмет со сцены
            Destroy(other.gameObject);
        }

        // Если поймали объект с тегом "Bad", уменьшаем счёт на 10
        if (other.gameObject.tag == "Bomb")
        {
            score -= 10;
            // Убираем предмет со сцены
            Destroy(other.gameObject);
        }

        // Обновляем текст на Canvas, чтобы показать новый счёт
        tmpText.text = score.ToString();
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        if (score <= -1)
        {
            SceneManager.LoadScene("MainMenu");// Загрузка сцены меню
        }
    }
}
