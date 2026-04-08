using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_Wind : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Выход");
    }
}
