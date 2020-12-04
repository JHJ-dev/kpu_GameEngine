using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class EventManager : SingletonBehaviour<EventManager>
{
    private IDictionary<string, List<Action<object>>> _eventDatabase;

    private void Awake()
    {
        _eventDatabase = new Dictionary<string, List<Action<object>>>();
    }

    public static void On(string eventName, Action<object> subscriber)
    {
        if (Instance._eventDatabase.ContainsKey(eventName) == false)
            Instance._eventDatabase.Add(eventName, new List<Action<object>>());
        
        Instance._eventDatabase[eventName].Add(subscriber);
    }

    public static void Emit(string eventName, object parameter)
    {
        if (Instance._eventDatabase.ContainsKey(eventName) == false)
        {
            Debug.LogWarning($"{eventName} 존재하지 않습니다.");
            return;
        }

        foreach (var action in Instance._eventDatabase[eventName])
            action(parameter);
    }
}
