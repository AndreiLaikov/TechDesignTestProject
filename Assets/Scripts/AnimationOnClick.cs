using UnityEngine;

public class AnimationOnClick : MonoBehaviour
{
    [SerializeField]private Animator[] animators;

    private void OnMouseDown()
    {
        foreach (var animator in animators)
        {
            animator.SetTrigger("Play");
        }
    }

}
