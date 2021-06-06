using System;
using UnityEngine;

namespace DialogueSystem
{
    /// <summary>
    /// This class represents a possible expression of an actor.
    /// These are set up in the Actor object.
    ///
    /// Этот класс представляет возможное выражение актера.
    /// Они настраиваются в объекте Actor.
    /// </summary>
    [Serializable]
    public class Expression
    {
        [Tooltip("The expression's name / short description")]
        [SerializeField]
        private string _title;
        public string Title
        {
            get => _title;
            set => _title = value;
        }

        [Tooltip("Sprite of the actor with this expression")]
        [SerializeField]
        private Sprite _sprite;
        public Sprite Sprite
        {
            get => _sprite;
            set => _sprite = value;
        }
    }
}