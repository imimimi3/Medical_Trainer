using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    // Ссылка на rigidbody
    private Rigidbody rb;
    public Rigidbody Rb => rb;

    /// <summary>
    /// Метод вызывается при инициализации
    /// </summary>
    private void Awake()
    {
        // Получаем ссылку на твердое тело
        rb = GetComponent<Rigidbody>();
    }
}
