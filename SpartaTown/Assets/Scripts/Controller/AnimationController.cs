using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected TownController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<TownController>();
    }
}
