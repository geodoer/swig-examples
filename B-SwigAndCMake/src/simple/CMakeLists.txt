##########################
#
# C++ simple模块的cmakelists文件
#
##########################
project(simple)

set(Simple_Include_Dir ${WORKSPACE_DIR}/include/simple)
set(Simple_Src_Dir ${WORKSPACE_DIR}/src/simple)

# 列出文件
file(GLOB_RECURSE SRC_FILES     ${Simple_Src_Dir}/*.cpp)                           #源代码
file(GLOB_RECURSE Headers_FILES ${Simple_Include_Dir}/*.h ${Simple_Include_Dir}/*.hpp)    #头文件
set(all_files ${SRC_FILES} ${Headers_FILES})

# 创建动态库
add_library(${PROJECT_NAME} SHARED
    ${all_files}
)

# 加入宏
target_compile_definitions(${PROJECT_NAME} PRIVATE SIMPLE) #标识此项目是SIMPLE模块