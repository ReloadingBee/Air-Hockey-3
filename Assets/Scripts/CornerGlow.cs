using UnityEngine;

public class CornerGlow : MonoBehaviour
{
    public float fadeDuration = 2.0f;
    private Material material;
    private Renderer rend;
    private float startTime;
    private bool fadingOut = false;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        material = rend.material;
        StartFadeIn();
    }

    private void Update()
    {
        float elapsedTime = Time.time - startTime;
        float t = elapsedTime / fadeDuration;

        if (fadingOut)
        {
            t = 1.0f - t;
        }

        Color color = material.color;
        color.a = Mathf.Lerp(0f, 1f, t);
        material.color = color;

        if (elapsedTime >= fadeDuration)
        {
            if (fadingOut)
            {
                StartFadeIn();
            }
            else
            {
                StartFadeOut();
            }
        }
    }

    private void StartFadeIn()
    {
        startTime = Time.time;
        fadingOut = false;
    }

    private void StartFadeOut()
    {
        startTime = Time.time;
        fadingOut = true;
    }
}
