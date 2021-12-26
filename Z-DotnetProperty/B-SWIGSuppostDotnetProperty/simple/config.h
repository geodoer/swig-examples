#pragma once

#ifdef SWIG /* SWIG时，要把这个宏置空 */
#   define SIMPLE_EXPORT
#else /* 由于simple模块，要被simple_wrap C++模块引用，所以要添加dllimport */
#   ifdef SIMPLE_MODULE
#	    define SIMPLE_EXPORT __declspec(dllexport)	//如果是simple模块，则需要导出
#   else
#	    define SIMPLE_EXPORT __declspec(dllimport)	//如果不是simple模块，则需要导入
#   endif
#endif