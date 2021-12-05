cmake_minimum_required(VERSION 3.4.1)
project(swigandcmake)

# 加载公共脚本
include(common.cmake)

# 工作空间目录
set(WORKSPACE_DIR ${CMAKE_CURRENT_SOURCE_DIR})

##########################
#
# 项目配置
#
##########################
# 编译类型
if(NOT CMAKE_BUILD_TYPE)
    # 1. 设置为RelWithDebInfo
    # 2. CACHE，即表示global。表明这个type对其他cmake，CMakeLists文件有效
    # 3. FORCE 如果CMAKE_BUILD_TYPE被其他调用该项目的项目设置过，这里则强制重新设置
    set(CMAKE_BUILD_TYPE RelWithDebInfo CACHE STRING "Choose the type of build." FORCE)
    # 在cmake-gui中设置可选项
    set(CMAKE_CONFIGURATION_TYPES "RelWithDebInfo" CACHE STRING "Configuration types." FORCE)
    set_property(CACHE CMAKE_BUILD_TYPE PROPERTY STRINGS  ${CMAKE_CONFIGURATION_TYPES})
endif()

# 平台类型
if(${CMAKE_CL_64})
    set(platform_type x64)
else()
    set(platform_type x86)
endif()

# 输出目录
set(OUTPUT_DIR ${WORKSPACE_DIR}/bin/${platform_type}/${CMAKE_BUILD_TYPE})
message(STATUS "[output directory] ${OUTPUT_DIR}")
##请不要使用EXECUTABLE_OUTPUT_PATH、LIBRARY_OUTPUT_PATH。因为VS环境与非VS环境不一样

# 生成目录（与输出目录一致）
if(MSVC)
    #在Win+VS环境下，会在EXECUTABLE_OUTPUT_PATH、EXECUTABLE_OUTPUT_PATH后面自动加一个${CMAKE_BUILD_TYPE}
    SET(EXECUTABLE_OUTPUT_PATH ${WORKSPACE_DIR}/bin/${platform_type}) #可执行文件输出目录
    set(LIBRARY_OUTPUT_PATH ${WORKSPACE_DIR}/bin/${platform_type})    #库文件输出目录
else()
    #在linux+gcc环境下，不会动，原来是什么就是什么
    SET(EXECUTABLE_OUTPUT_PATH ${WORKSPACE_DIR}/bin/${platform_type}/${CMAKE_BUILD_TYPE})
    set(LIBRARY_OUTPUT_PATH ${WORKSPACE_DIR}/bin/${platform_type}/${CMAKE_BUILD_TYPE})
endif()

##########################
#
# 路径设置
#
##########################
# 头文件路径（全局）
set(INCLUDE_DIR ${WORKSPACE_DIR}/include)
include_directories(${INCLUDE_DIR})

# lib目录（全局）
link_directories(${LIBRARY_OUTPUT_PATH}) 

##########################
#
# 添加子模块
#
##########################
add_subdirectory_custom() # 添加子模块（./common.cmake/下定义的宏）
# 采用不递归的方式添加子模块
# 好处：一层一层进去，有利于控制模块