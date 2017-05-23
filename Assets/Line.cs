using UnityEngine;

public class Line : MonoBehaviour 
{
    public float radius = 2;
    public float start = 0;
    public float speed = 0.5f;

    LineRenderer line;
    float t;

    private void Awake()
    {
        line = GetComponent<LineRenderer>();
        t = start;
        line.positionCount = 2;
    }

    private void Update()
    {
        t = Mathf.Repeat(t + Time.deltaTime * speed, 1);

        float x = Mathf.Cos((2 * Mathf.PI) * t) * radius;
        float y = Mathf.Sin((2 * Mathf.PI) * t) * radius;
        line.SetPosition(1, new Vector3(x, y, -5));
    }
}