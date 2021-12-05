/* 模块名 */
%module simple

/* 以下内容会被原封不动的，拷贝到*_wrap.cxx中 */
%{
//**************************************
//SWIG接口文件中拷贝过来的内容
extern int    gcd(int x, int y);
extern double Foo;
//**************************************
%}

/* 指定需要解析的头文件，并生成包装器的代码 */
%include"example.h"