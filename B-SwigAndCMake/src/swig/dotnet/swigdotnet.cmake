# 拼接csproj中依赖库的字符串
# references_string     返回值（csproj中依赖库的字符串）
# 其他参数              收集在dependlibs_path中
macro(join_references_string references_string)
    set(dependlibs_path "${ARGN}")  #依赖库的全路径

    # 处理一个依赖库
    foreach(dependlib_path ${dependlibs_path})
        #没有后缀名的文件名称
        get_filename_component(dependlib_name ${dependlib_path} NAME_WLE)

        # <Reference Include="simple_wrapper_dotnet">
        #     <HintPath>$(OutputPath)\simple_wrapper_dotnet.dll</HintPath>
        # </Reference>
        set(item_string
            "
        <Reference Include=\"${dependlib_name}\">
            <HintPath>${dependlib_path}</HintPath>
        </Reference>
            "
        )

        set(${references_string} 
            "${${references_string}}${item_string}"
        )
    endforeach()

endmacro()

# 创建一个dotnet工程
# 1. 可传入依赖库（但必须是全路径）
macro(create_dotnet_project)
    # list宏参数：依赖库全路径
    set(dependlibs_path "${ARGN}")
    
    set(references_string "")

    # 传入了依赖库，则拼接依赖库字符串
    list(LENGTH dependlibs_path dependlibs_path_size)
    if(dependlibs_path_size GREATER 0)
        join_references_string(references_string ${dependlibs_path})
        # message(STATUS "[debug] [csproj dependlib string] ${references_string}")
    endif()

    # 将CMake的变量传入，根据dotnet工程模板文件，创建dotnet工程
    configure_file(${DOTNET_PROJECT_TEMPLATE} ${CSHARP_OUTPUT_DIR}/${SWIG_CSHARP_NAME}.csproj @ONLY)
    # 添加自定义命令
    add_custom_command(
        TARGET                          #构建模式
        ${SWIG_MODULE_NAME} POST_BUILD  #等到cxx工程编译完成之后，执行此命令
        COMMAND
            ${DOTNET_EXECUTABLE} build ${CSHARP_OUTPUT_DIR}/${SWIG_CSHARP_NAME}.csproj
    )
endmacro()

# 创建一个dotnet工程
# 1. dependlib_dir  依赖库的目录
# 2. 多个依赖库的名字   如：assimp.dll zlib.dll
macro(create_dotnet_project_by_dependlibname dependlib_dir)
    set(dependlibs_name "${ARGN}")

    set(dependlibs_path)

    foreach(dependlib_name ${dependlibs_name})
        list(APPEND dependlibs_path ${dependlib_dir}/${dependlib_name})
    endforeach()
    
    create_dotnet_project(${dependlibs_path})
endmacro()