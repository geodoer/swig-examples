project(SWIG)

option(BUILD_SWIG_DotNet "Build SWIG to dotnet..." ON)
option(BUILD_SWIG_Python "Build SWIG to python..." OFF) #还没有实现Python

set(BUILD_SWIG 
  BUILD_SWIG_DotNet or BUILD_SWIG_Python)
if(NOT BUILD_SWIG)
    return()
endif()

######################################################
# 引入SWIG
######################################################
# Apple: Don't modify install_name when touching RPATH.
if(POLICY CMP0068)
  cmake_policy(SET CMP0068 NEW)
endif()

# Define file(GENERATE) behavior for relative paths.
if(POLICY CMP0070)
  cmake_policy(SET CMP0070 NEW)
endif()

# target_sources: use absolute path for INTERFACE_SOURCES.
if(POLICY CMP0076)
  cmake_policy(SET CMP0076 NEW)
endif()

# option() honors normal variables.
# see: https://cmake.org/cmake/help/git-stage/policy/CMP0077.html
if(POLICY CMP0077)
  cmake_policy(SET CMP0077 NEW)
endif()

# SWIG: use standard target name.
if(POLICY CMP0078)
  cmake_policy(SET CMP0078 NEW)
endif()

# SWIG: use SWIG_MODULE_NAME property.
if(POLICY CMP0086)
  cmake_policy(SET CMP0086 NEW)
endif()

# 引入swig
find_package(SWIG REQUIRED)
include(${SWIG_USE_FILE})

######################################################
# 添加子模块
######################################################
if(BUILD_SWIG_DotNet)
  add_subdirectory(dotnet)
endif()

if(BUILD_SWIG_Python)
  add_subdirectory(python)
endif()