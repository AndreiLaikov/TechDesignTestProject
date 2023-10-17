using UnityEngine;

public class ShowUIButton : MonoBehaviour
{
    public GameObject UIButton;

    private void Start()
    {
        if (UIButton == null)
            Debug.LogError("No reference!");
    }

    private void OnMouseDown()
    {
        UIButton.SetActive(true);
    }
}
