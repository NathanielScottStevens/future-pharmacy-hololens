using UnityEngine;
using System.Runtime.InteropServices;

public class TestDLL : MonoBehaviour 
{
    [DllImport("MathFuncsDll")]
    private static extern double Add(double a, double b);

    [DllImport("MathFuncsDll")]
    private static extern double Multiply(double a, double b);

    [DllImport("MathFuncsDll")]
    private static extern double AddMultiply(double a, double b);

    private void Awake()
    {
        Debug.Log(Add(2.0, 3.0));
        Debug.Log(Multiply(2.0, 3.0));
        Debug.Log(AddMultiply(2.0, 3.0));
    }
}