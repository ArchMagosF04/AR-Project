using UnityEngine;

public class MigraniaURLScript : MonoBehaviour
{
    public void GoToURL(string url)
    {
        Application.OpenURL(url);
    }
}
