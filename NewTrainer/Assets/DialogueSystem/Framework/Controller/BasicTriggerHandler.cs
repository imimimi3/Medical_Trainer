using System;
using UnityEngine;
using UnityEngine.UI;

using Anamn;
using TMPro;

namespace DialogueSystem
{

    /// <summary>
    /// This is a basic implementation of a trigger handler.
    /// Doesn't do much except for providing a way to read and filter triggers.
    /// You can either expand this or create your own handler.
    ///
    /// Это базовая реализация обработчика триггеров.
    /// Практически ничего не делает, кроме как читать и фильтровать триггеры.
    /// Вы можете либо расширить его, либо создать свой собственный обработчик.
    /// </summary>


    public class BasicTriggerHandler : TriggerHandler
    {
        public override void Handle(string trigger)
        {
            string[] split = trigger.Split(' ');
            
            if (split.Length <= 0)
            {
                Debug.LogError("Trigger is empty.");
                return;
            }
            else if (split.Length <= 1)
            {
                Debug.LogError("Trigger has no value.");
                return;
            }
            else
            {
                string key = split[0];
                string value = split[1];
                switch (key)
                {
                    case string k when k.Equals("anamnesis1") || k.Equals("a1"):
                        AnamnesisT.AnamnesisT_1(Convert.ToInt32(value));
                        break;
                    
                    case string k when k.Equals("anamnesis2") || k.Equals("a2"):
                        AnamnesisT.AnamnesisT_2(Convert.ToInt32(value));
                        break;
                    
                    default:
                        Debug.LogError($"Trigger key '{key}' not recognized.");
                        return;
                }
            }
        }

        

        
    }
}