%module example

%{
#include "idescription.hpp"
#include "example.hpp"
%}

%include"std_string.i"

%include"idescription.hpp"

%include <swiginterface.i>
%interface(example::BaseClass) //这句话用于申明接口，申明要在include之前
%include"example.hpp"