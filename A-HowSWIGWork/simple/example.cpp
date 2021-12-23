#include"example.h"

double Example::Foo = 0;

int Example::gcd(int x, int y) {
	int g;
	g = y;
	while (x > 0) {
		g = x;
		x = y % x;
		y = g;
	}
	return g;
}