# 添加子目录（非递归版）
macro(add_subdirectory_custom)
    file(GLOB cmakelists_files ${CMAKE_CURRENT_SOURCE_DIR}/*/CMakeLists\.txt)

    foreach(file ${cmakelists_files})
        get_filename_component(subdir ${file} DIRECTORY)
        
        message(STATUS "===== [Add submodule] ${subdir}")  
        add_subdirectory(${subdir})
    endforeach()
endmacro()

# 添加子模块（递归版）
macro(add_subdirectory_custom_rec)
    file(GLOB_RECURSE cmakelists_files ${CMAKE_CURRENT_SOURCE_DIR}/*/CMakeLists\.txt)
    foreach(file ${cmakelists_files})
        get_filename_component(subdir ${file} DIRECTORY)
        
        message(STATUS "===== [Add submodule] ${subdir}")  
        add_subdirectory(${subdir})
    endforeach()
endmacro()
