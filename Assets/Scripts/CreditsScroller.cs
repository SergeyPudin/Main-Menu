using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CreditsScroller : MonoBehaviour
{
    [SerializeField] private ScrollRect _scrollRect;
    [SerializeField] private float _speed;

    private Coroutine _coroutine;

    private void OnEnable()
    {
        _scrollRect.verticalNormalizedPosition = 1;
        _coroutine = StartCoroutine(ScrollUp());
    }

    private void OnDisable()
    {
        StopCoroutine(_coroutine);
    }

    private IEnumerator ScrollUp()
    {
        while (_scrollRect.normalizedPosition.y > 0)
        {
            _scrollRect.verticalNormalizedPosition -= Time.deltaTime * _speed;

            yield return null;
        }
    }
}