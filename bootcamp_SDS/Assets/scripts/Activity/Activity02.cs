using UnityEngine;

public class Activity02 : MonoBehaviour
{
    public void Teleport()
    {
        float x = Random.Range(-5f, 5f);
        float y = Random.Range(-3f, 3f);

        transform.position = new Vector2(x, y);
    }
}
