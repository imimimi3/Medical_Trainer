using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Ссылка на контроллер персонажа
    [SerializeField]
    private CharacterController character;

    // Скорость передвижения персонажа
    [SerializeField]
    private float moveSpeed = 4;

    // Ссылка на камеру персонажа
    [SerializeField]
    private Camera characterCamera;

    // Скорость камеры
    [SerializeField]
    private float camSpeed = 40;


    /// <summary>
    /// Вызываем метод при старте
    /// </summary>
    private void Start()
    {
        // Блокируем и скрываем курсор
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    /// <summary>
    /// Метод вызывается каждый кадр
    /// </summary>
    private void Update()
    {
        // Получаем данные о перемещении персонажа
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");

        // Создайём вектор перемещения и поворачиваем его
        var move = new Vector3(h, 0, v);
        move = character.transform.rotation * move;

        // Если длина вектора перемещения больше 1, нормализуем его.
        if (move.magnitude > 1)
            move = move.normalized;

        // Перемещаем персонажа
        character.SimpleMove(move * moveSpeed);

        // Получаем ввод мыши игрока для поворота камеры и персонажа
        var mx = Input.GetAxisRaw("Mouse X");
        var my = Input.GetAxisRaw("Mouse Y");

        // Поворот игрока с помощью мыши по оси Х
        character.transform.Rotate(Vector3.up, mx * camSpeed);

        // Получаем поворот камеры по оси X
        var currentRotationX = characterCamera.transform.localEulerAngles.x;
        currentRotationX += -my * camSpeed;

        // Ограничиваем движения камеры (-60) - (60) градусов по оси X.
        if (currentRotationX < 180)
        {
            currentRotationX = Mathf.Min(currentRotationX, 60);
        }
        else if (currentRotationX > 180)
        {
            currentRotationX = Mathf.Max(currentRotationX, 300);
        }

        // Назначаем новый поворот камеры
        characterCamera.transform.localEulerAngles = new Vector3(currentRotationX, 0, 0);

    }
}
