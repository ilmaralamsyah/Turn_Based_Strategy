using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWorld : MonoBehaviour
{
    public static MouseWorld Instance;

    [SerializeField] private LayerMask mouseWorldLayerMask;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        transform.position = GetMouseWorldPosition();
    }

    public Vector3 GetMouseWorldPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, mouseWorldLayerMask);
        return raycastHit.point;
    }
}
