using UnityEngine;

public class MigraniaURLScript : MonoBehaviour
{
    [SerializeField] private Animator logoStarAnimation;

    public void GoToURL(string url)
    {
        Application.OpenURL(url);
    }

    public void StarLogoAnimation()
    {
        logoStarAnimation.SetTrigger("Spin");
    }
}
