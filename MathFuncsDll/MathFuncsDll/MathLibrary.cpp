// MathLibrary.cpp : Defines the exported functions for the DLL application.  
// Compile by using: cl /EHsc /DMATHLIBRARY_EXPORTS /LD MathLibrary.cpp  

#include "stdafx.h"  
#include "MathLibrary.h"  

extern "C" {
	double Add(double a, double b)
	{
		return a + b;
	}

	double Multiply(double a, double b)
	{
		return a * b;
	}

	double AddMultiply(double a, double b)
	{
		return a + (a * b);
	}
}
