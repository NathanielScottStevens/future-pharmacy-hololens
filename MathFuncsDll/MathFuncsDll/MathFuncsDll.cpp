// MathFuncsDll.cpp : Defines the exported functions for the DLL application.
//

#include "MathFuncsDll.h"

#include "stdafx.h"

using namespace std;

namespace MathFuncs
{
	float MyMathFuncs::Add(float a, float b) {
		return a + b;
	}

	float MyMathFuncs::Subtract(float a, float b) {
		return a - b;
	}

	float MyMathFuncs::Multiply(float a, float b) {
		return a * b;
	}

	float MyMathFuncs::Divide(float a, float b) {
		return a / b;
	}
}


