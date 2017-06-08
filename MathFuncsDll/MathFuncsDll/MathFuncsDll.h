#pragma once

namespace MathFuncs
{
	class MyMathFuncs
	{
	public:
		static __declspec(dllexport) float Add(float a, float b);

		static __declspec(dllexport) float Subtract(float a, float b);

		static __declspec(dllexport) float Multiply(float a, float b);

		static __declspec(dllexport) float Divide(float a, float b);
	};
}