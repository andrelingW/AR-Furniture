using UnityEngine;

public class UrlOpener : MonoBehaviour
{
    public string Url;

    public void HyperLink()
    {
        
        Application.OpenURL(Url);
    }

}
