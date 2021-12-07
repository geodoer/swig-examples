#pragma once
#include<string>

#include"idescription.hpp"

class BaseClass
{
public:
	virtual ~BaseClass() = default;
	virtual std::string className()
	{
    	return "BaseClass";
	}
};

class DerivedClass : public BaseClass, public IDescription
{
public:
	DerivedClass(const std::string& name) : IDescription(name){}
	std::string className() override
	{
    	return "DerivedClass";
	}
};