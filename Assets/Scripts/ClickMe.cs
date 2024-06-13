using UnityEngine;

public class ClickMe : MonoBehaviour
{
    [SerializeField] private int _index = 0;

    private void OnMouseUpAsButton()
    {
        if (_index >= 0)
            FindObjectOfType<FadeToGray>().DoTheFade(_index);
    }
}
