using UnityEngine;

public class AnimationOnClick : MonoBehaviour
{
    [SerializeField]private Animator animator;

    private void Start()
    {
        if(animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    private void OnMouseDown()
    {
        animator.SetTrigger("Run");
    }

}
