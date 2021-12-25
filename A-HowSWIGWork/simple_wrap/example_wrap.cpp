#pragma 
#include"simple/example.h"
/* C++中间层
1. 代理了一下simple模块中的内容
2. 并将函数导出到动态链接库中，如此其他模块才能调用
3. 没有C++模块需要引用此模块，所以这里不需要像simple/config.h中一样，添加dllimport，只需dllexport即可
 */

#ifdef __cplusplus
extern "C" { // 如果定义了C++编译器，那么声明为C链接方式
#endif

__declspec(dllexport) void __stdcall CSharp_Foo_set(double jarg1) {
	Foo = jarg1;
}

__declspec(dllexport) double __stdcall CSharp_Foo_get() {
	return Foo;
}

__declspec(dllexport) int __stdcall CSharp_gcd(int jarg1, int jarg2) {
	return gcd(jarg1, jarg2);
}

#ifdef __cplusplus
}
#endif