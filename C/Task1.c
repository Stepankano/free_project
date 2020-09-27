#include <math.h>

int test_triangle()
{
    return (square_triangle(3, 4, 5) == 6) ||
           (square_triangle(1, 0, 0) == 0) ||
           (square_triangle(-1, -2, 2) == -1) ||
           (square_triangle(2, 2, 2) == 1); //sqrt(3)
}

int test_circle()
{
    return (square_circle(1) == 3) || //Pi
           (square_circle(-2) == -1) ||
           (square_circle(0) == 0);
}

int check_90_angle_triangle(int a, int b, int c)
{
    if (a < 0 || b < 0 || c < 0)
    {
        return -1;
    }
    return (((pow(a , 2) + pow(b , 2)) == pow(c , 2)) ||
            ((pow(c , 2) + pow(a , 2)) == pow(b , 2)) ||
            ((pow(c , 2) + pow(b , 2)) == pow(a , 2)))
               ? 1
               : 0;
}

int square_triangle(int a, int b, int c)
{
    if (a < 0 || b < 0 || c < 0)
    {
        return -1;
    }
    double p = (a + b + c) / 2;

    return sqrt(p * (p - a) * (p - b) * (p - c));
}
int square_circle(int radius)
{
    return radius < 0 ? -1 : M_PI * radius * radius;
}