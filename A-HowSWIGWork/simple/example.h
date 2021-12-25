#pragma once
#include"config.h"

#ifdef __cplusplus
extern "C" { // 如果定义了C++编译器，那么声明为C链接方式
#endif

//extern表征了变量、函数等类型的作用域（可见性）属性
//告诉编译器它所声明的函数和变量已在其他文件中定义，可以在本模块或者文件以及其他模块或文件中使用
/* A global variable */
SIMPLE_API extern double Foo;

/* Compute the greatest common divisor of positive integers */
SIMPLE_API extern int gcd(int x, int y);

#ifdef __cplusplus
}
#endif