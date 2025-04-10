using UnityEngine;

public class CharacterClimb : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
#if UNITY_EDITOR
        // Use mouse click when testing in the Unity Editor
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Climb");
        }
#else
        // Use touch input on phone
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            animator.SetTrigger("Climb");
        }
#endif
    }
}