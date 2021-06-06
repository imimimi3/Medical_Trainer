using UnityEngine;

namespace DialogueSystem
{
    /// <summary>
    /// Abstract base for trigger Handlers.
    /// Not an interface only because Unity's Inspector doesn't accept them.
    ///
    /// Абстрактная база для обработчиков триггеров.
    /// Не интерфейс только потому, что Инспектор Unity их не принимает.
    /// </summary>
    public abstract class TriggerHandler : MonoBehaviour
    {
        public abstract void Handle(string trigger);
    }
}
