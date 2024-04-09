using UnityEngine;

public class ExitSwitcher : MonoBehaviour
{
    [SerializeField] private Transform _exitPlate;

    public void OpenExitPlate()
    {
        _exitPlate.gameObject.SetActive(true);
    }
}