project(SWIG_DOTNET)

#########################
# 配置
#########################
set(DotNet_Framework netstandard2.0)  #dotnet的框架版本

#########################
# 代码
#########################
set(SWIG_DOTNET_DIR ${CMAKE_CURRENT_LIST_DIR})                                      #SWIG dotnet目录
set(DOTNET_PROJECT_TEMPLATE ${SWIG_DOTNET_DIR}/dotnet_project_template.csproj.in)   #dotnet的工程模板

# 引入SWIG dotnet模块共同的脚本文件
include(swigdotnet.cmake)

# 找到dotnet.exe（需要安装dotnet）
find_program(DOTNET_EXECUTABLE NAMES dotnet)
if(NOT DOTNET_EXECUTABLE)
  message(FATAL_ERROR "Check for dotnet Program: not found")
else()
  message(STATUS "Found dotnet Program: ${DOTNET_EXECUTABLE}")
endif()

# 递归添加子模块
add_subdirectory_custom_rec()