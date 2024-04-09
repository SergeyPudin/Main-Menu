using UnityEngine;

public class CreditsSwitcher : MonoBehaviour
{
    [SerializeField] private Transform _viewer;

    public void SwitchCredits()
    {
        if (_viewer.gameObject.activeSelf == false)
        {
            Debug.Log(_viewer.gameObject.activeSelf);
            _viewer.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log(_viewer.gameObject.activeSelf);
            _viewer.gameObject.SetActive(false);
        }
    }
}