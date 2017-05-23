using UnityEngine;

public class Circle : MonoBehaviour 
{
    public int segments = 20;
    public float radius = 2;
    public float start = 0;
    public float speed = 0.5f;
    public AnimationCurve curve;

    LineRenderer line;
    float t;

    private void Awake()
    {
        line = GetComponent<LineRenderer>();
        t = start;
    }

    private void Update()
    {
        t += Time.deltaTime * speed;

        if (t > 1) t = 0;

        float currentRadius = curve.Evaluate(t) * radius;
        Vector3[] positions = new Vector3[segments + 1];

        for (int i = 0; i <= segments; i++)
        {
            float x = Mathf.Cos(((2 * Mathf.PI) / segments) * i) * currentRadius;
            float y = Mathf.Sin(((2 * Mathf.PI) / segments) * i) * currentRadius;
            positions[i] = new Vector3(x, y);
        }

        line.numPositions = segments + 1;
        line.SetPositions(positions);
        line.startWidth = curve.Evaluate(t) * 0.5f;
        line.endWidth = curve.Evaluate(t) * 0.5f;
    }


}