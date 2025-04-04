using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private IMoveStrategy moveStrategy;
    [SerializeField] private TMP_Text strategyText; // Texto para mostrar la estrategia actual

    private void Start()
    {
        moveStrategy = new WalkStrategy();
        UpdateStrategyText("Walk");
    }

    private void Update()
    {
        moveStrategy.Move(transform);
    }

    public void SetRun()
    {
        moveStrategy = new RunStrategy();
        UpdateStrategyText("Run");
        Debug.Log("🏃 Cambiado a correr.");
    }

    public void SetWalk()
    {
        moveStrategy = new WalkStrategy();
        UpdateStrategyText("Walk");
        Debug.Log("🚶 Cambiado a caminar.");
    }

    private void UpdateStrategyText(string strategy)
    {
        if (strategyText != null)
        {
            strategyText.text = "Current Strategy: " + strategy;
        }
    }
}
