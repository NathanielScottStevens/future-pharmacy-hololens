// MathLibrary.h - Contains declaration of Function class  
#pragma once  

#define MATHLIBRARY_API __declspec(dllexport)   

extern "C" {
        // Returns a + b  
        MATHLIBRARY_API double Add(double a, double b);  

        // Returns a * b  
        MATHLIBRARY_API double Multiply(double a, double b);  

        // Returns a + (a * b)  
        MATHLIBRARY_API double AddMultiply(double a, double b);  
} 