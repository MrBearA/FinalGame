using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    public bool locked;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        locked = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ChestKey"))
        {
            locked = false;

            animator.SetTrigger(AnimationString.isopen);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ChestKey"))
        {
            locked = true;
        }
    }
}
