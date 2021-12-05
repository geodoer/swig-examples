#include"example.h"

#include<iostream>

/* 计算正整数的最大公约数 */
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