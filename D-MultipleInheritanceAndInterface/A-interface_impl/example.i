%module example

%{
#include "idescription.hpp"
#include "example.hpp"
%}

%include"std_string.i"

%include <swiginterface.i>
%interface_impl(IDescription); //这句话用于申明接口，申明要在include之前！
%include"idescription.hpp"

%include"example.hpp"