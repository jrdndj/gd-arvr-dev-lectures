using UnityEngine;

public class Selectfeedback : MonoBehaviour
{
    private Vector3 originalScale;

    private void Awake()
    {
        originalScale = transform.localScale;
    }

    public void Normal()
    {
        transform.localScale = originalScale;
    }

    public void Hover()
    {
        transform.localScale = originalScale * 1.1f;
    }

    public void Selected()
    {
        transform.localScale = originalScale * 1.25f;
    }
}