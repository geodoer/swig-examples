#pragma once

#ifdef SWIG //如果是SWIG模块（如果在SWIG环境下，SWIG会提供这个宏，不需要人为添加）
    //把以下宏置空
    #define SIMPLE_EXPORT

#else //如果是C++模块
    #ifdef SIMPLE   //如果是simple模块
        #define SIMPLE_EXPORT __declspec(dllexport) //则导出
    #else
        #define SIMPLE_EXPORT __declspec(dllimport) //则导入
    #endif

#endif