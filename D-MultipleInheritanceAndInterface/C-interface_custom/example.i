%module example

%{
#include "idescription.hpp"
#include "example.hpp"
%}

%include"std_string.i"

%include"idescription.hpp"

%include <swiginterface.i>
%interface_custom("BC", "IBC" ,example::BaseClass) //这句话用于申明接口，申明要在include之前
//第三个参数是，要包装成接口的C++类名
//第二个参数是：接口名称
//第一个参数是：代理类的名称，即接口实现类的名称
%include"example.hpp"