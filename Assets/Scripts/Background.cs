using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Background : MonoBehaviour 
{
    // We need to use int to work with the raw image data.  
    // However, a property of type int cannot be animated.
    // Hence, the awkward conversions.
    public float size = 128;
    public Color color;
    public float radius = 10;
    public float borderRadius = 5;

    RawImage image;

    private void Awake()
    {
        image = GetComponent<RawImage>();
    }

    private void Update()
    {
        Texture2D texture = new Texture2D((int)size, (int)size);
        Color[] colors = new Color[(int)size * (int)size];
        
        for (int x = 0; x < size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                colors[CoordToIndex(x, y)] = Color.clear;
                
                
                //Center Fill
                Vector2 center = new Vector2(
                    size / 2,
                    size / 2
                );

                if (IsInsideCircle(x, y, center, (int)radius))
                {
                    colors[CoordToIndex(x, y)] = color;
                }


                //Corners
                //Bottom Left
                center = new Vector2(
                    borderRadius,
                    borderRadius
                );

                if (x < center.x & y < center.y)
                {
                    ClearPixelsOutsideCorners(colors, x, y, center);
                }

                //Top Left
                center = new Vector2(
                    borderRadius,
                    size - borderRadius
                );

                if (x < center.x & y > center.y)
                {
                    ClearPixelsOutsideCorners(colors, x, y, center);
                }

                //Top Right
                center = new Vector2(
                    size - borderRadius,
                    size - borderRadius
                );

                if (x > center.x & y > center.y)
                {
                    ClearPixelsOutsideCorners(colors, x, y, center);
                }

                //Bottom Right
                center = new Vector2(
                    size - borderRadius,
                    borderRadius
                );

                if (x > center.x & y < center.y)
                {
                    ClearPixelsOutsideCorners(colors, x, y, center);
                }
            }
        }

        texture.SetPixels(colors);
        texture.Apply();
        image.texture = texture;     
    }

    void ClearPixelsOutsideCorners(Color[] colors, int x, int y, Vector2 center)
    {
        if (!IsInsideCircle(x, y, center, (int)borderRadius))
        {
            colors[CoordToIndex(x, y)] = Color.clear;
        }
    }

    bool IsInsideCircle(int x, int y, Vector2 center, int radius)
    {
        float lengthX = x - center.x;
        float lengthY = y - center.y;
        return lengthX * lengthX + lengthY * lengthY <= radius * radius;
    }

    int CoordToIndex(int x, int y)
    {
        return y*(int)size + x;
    }

}