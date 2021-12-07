%module example

%{
#include "idescription.hpp"
#include "example.hpp"
%}

%include"std_string.i"

//自定义一个template_interface宏，完成对模板类的接口定义
%include <swiginterface.i>
%define %template_interface(CTYPE, TEMPLATE_IMPL, INTERFACE...)
%interface_custom(#TEMPLATE_IMPL, #INTERFACE, CTYPE);
%template(#TEMPLATE_IMPL) CTYPE;
%enddef

%include"idescription.hpp"

%template_interface(example::IDescription<example::DerivedClass>, DerivedClassDescription, IDerivedClassDescription); //这句话要在%include"example.hpp"之前，即在example::IDescription<example::DerivedClass>之前
%include"example.hpp"