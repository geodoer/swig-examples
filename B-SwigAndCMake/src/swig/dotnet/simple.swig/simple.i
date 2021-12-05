//simple模块的SWIG 接口文件
%module(directors="1") simple_wrapper

/******************
 * 
 * 以下内容会被原封不动的，拷贝到*_wrap.cxx中
 * 
 ******************/
%{
#include"simple/hello.h"
//让*_wrap.cxx能够找到对应的头文件
%}

/******************
 * 
 * 其他信息与SWIG配置规则
 * 
 ******************/
%include "config.h" 
//引入整个工程的配置文件
//引入这个的目的是将SIMPLE_EXPORT宏置空

/******************
 * 
 * 指定导出内容（即添加要包装给C#的头文件）
 * 
 ******************/
%include"simple/hello.h"
//%include"simple/hello2.h" //如果simple模块还有别的.h也可以加入进来