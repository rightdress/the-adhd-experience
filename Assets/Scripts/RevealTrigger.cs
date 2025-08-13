using UnityEngine;

public class RevealTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _objectToBeRevealed;

    private void Start()
    {
        _objectToBeRevealed.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        _objectToBeRevealed.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        _objectToBeRevealed?.SetActive(false);
    }

}
