#pragma once
#include<string>

namespace example{

	template <typename DerivedClassName>
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
		DerivedClassName& setName(const std::string& name)
		{
			_mName = name;
			return *(DerivedClassName*)this;
		}
		std::string description() const
		{
			return _mDescription;
		}
		DerivedClassName& setDescription(const std::string& description)
		{
			_mDescription = description;
			return *(DerivedClassName*)this;
		}

	protected:
		std::string		_mName; 		//<- 名称
		std::string		_mDescription;	//<- 详细说明
	};

};