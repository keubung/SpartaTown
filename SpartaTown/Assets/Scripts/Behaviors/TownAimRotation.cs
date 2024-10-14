using System;
using UnityEngine;

public class TownAimRotation : MonoBehaviour
{
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    private TownController controller;

    private void Awake()
    {
        controller = GetComponent<TownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotz = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotz) > 90f;
        armPivot.rotation = Quaternion.Euler(0, 0, rotz);
    }
}
