using Unity.VisualScripting;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    public void Awake()
    {
        gameObject.SetActive(false);
    }

    public void OnTargetLost()
    {
        gameObject.SetActive(false);
    }
}
