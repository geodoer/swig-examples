#include"example.h"

double Foo = 3.0;

int gcd(int x, int y) {
	int g;
	g = y;
	while (x > 0) {
		g = x;
		x = y % x;
		y = g;
	}
	return g;
}