using UnityEngine;

public class Activity01 : MonoBehaviour
{
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void ChangeColor()
    {
        sr.color = new Color(Random.value, Random.value, Random.value);
    }
}
