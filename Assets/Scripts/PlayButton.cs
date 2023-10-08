using UnityEngine;

public class PlayButton : MonoBehaviour
{
    private Vector3 scaleDestination;
    public Vector2 destination = new Vector2(4.5f, 1.8f);
    private Vector3 defaultScale;

    private void Start()
    {
        defaultScale = transform.localScale;
        scaleDestination = defaultScale;
    }

    private void OnMouseOver()
    {
        scaleDestination = destination;
    }

    private void OnMouseExit()
    {
        scaleDestination = defaultScale;
    }

    private void Update()
    {
        Vector3 newScale = transform.localScale;
        newScale.x += (scaleDestination.x - newScale.x) / 0.2f * Time.deltaTime;
        newScale.y += (scaleDestination.y - newScale.y) / 0.2f * Time.deltaTime;
        transform.localScale = newScale;
    }
}
