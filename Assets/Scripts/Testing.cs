using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] private Transform debugTextPrefab;

    private GridSystem gridSystem;

    private void Awake()
    {
        gridSystem = new GridSystem(10, 10, 2);

        gridSystem.CreateDebugText(debugTextPrefab);
    }

    private void Update()
    {
        Debug.Log(gridSystem.GetGridPosition(MouseWorld.Instance.GetMouseWorldPosition()));
    }
}
