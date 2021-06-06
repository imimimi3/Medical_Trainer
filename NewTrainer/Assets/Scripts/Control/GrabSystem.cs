using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabSystem : MonoBehaviour
{
    // Ссылка на камеру персонажа.
    [SerializeField]
    private Camera characterCamera;

    // Ссылка на слот для хранения выбранного предмета.
    [SerializeField]
    private Transform slot;

    // Ссылка на текущий объект.
    private PickableItem pickedItem;

    /// <summary>
    /// Вызываем метод каждый кадр
    /// </summary>
    private void Update()
    {
        // Execute logic only on button pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Проверка, был ли взят предмет
            if (pickedItem)
            {
                // Если да, то выбрасывает выбранный предмет
                DropItem(pickedItem);
            }
            else
            {
                // Если нет, попробует подобрать предмет перед игроком
                // Создем луч из центра экрана
                var ray = characterCamera.ViewportPointToRay(Vector3.one * 0.5f);
                RaycastHit hit;
                // Стреляем лучом, чтобы найти объект для выбора
                if (Physics.Raycast(ray, out hit, 1.5f))
                {
                    //Проверить, доступен ли объект для выбора
                    var pickable = hit.transform.GetComponent<PickableItem>();

                    if (pickable)
                    {
                        PickItem(pickable);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Метод вщятия объекта
    /// </summary>
    /// <param name="item">Item.</param>
    private void PickItem(PickableItem item)
    {
        // Назначаем ссылку
        pickedItem = item;

        // Отключаем rigidbody и убераем скорость
        item.Rb.isKinematic = true;
        item.Rb.velocity = Vector3.zero;
        item.Rb.angularVelocity = Vector3.zero;

        // Устанавливаем слот как родительский
        item.transform.SetParent(slot);

        // Сбрасываем положение и вращение
        item.transform.localPosition = Vector3.zero;
        item.transform.localEulerAngles = Vector3.zero;

    }

    /// <summary>
    /// Метод выкидывания предмета
    /// </summary>
    /// <param name="item">Item.</param>
    private void DropItem(PickableItem item)
    {
        // Удаляем ссылку
        pickedItem = null;

        // Удаляем родителя
        item.transform.SetParent(null);

        // Включаем rigidbody
        item.Rb.isKinematic = false;

        // Прибавляем силу, чтобы бросить предмет
        //item.Rb.AddForce(item.transform.forward * 2, ForceMode.VelocityChange);
        item.transform.position = new Vector3(-0.392f, 1.190528f, -2.531f);
        item.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }
}
