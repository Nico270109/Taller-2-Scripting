using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static event Action OnButtonPressed;

    public void ButtonClicked()
    {
        Debug.Log("Botón presionado. Notificando observadores...");
        OnButtonPressed?.Invoke();
    }
}

public class ObserverExample : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnButtonPressed += RespondToEvent;
    }

    private void OnDisable()
    {
        EventManager.OnButtonPressed -= RespondToEvent;
    }

    private void RespondToEvent()
    {
        Debug.Log("El observador ha detectado el evento.");
    }
}
