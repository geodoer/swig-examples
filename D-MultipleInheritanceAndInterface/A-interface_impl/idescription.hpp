#pragma once
#include<string>

class IDescription
{
public:
	IDescription(const std::string& name) :_mName(name) {}
	virtual ~IDescription() = default;

public:
	std::string name() const
	{
		return _mName;
	}
	IDescription& setName(const std::string& name)
	{
		_mName = name;
		return *this;
	}
	std::string description() const
	{
		return _mDescription;
	}
	IDescription& setDescription(const std::string& description)
	{
		_mDescription = description;
		return *this;
	}

protected:
	std::string		_mName; 		//<- 名称
	std::string		_mDescription;	//<- 详细说明
};