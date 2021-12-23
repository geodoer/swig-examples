#include"person.h"

#include<iostream>

Person::Person(int guid)
	: m_guid(guid)
	, m_name('0')
{
}

int Person::Guid() const
{
	return m_guid;
}

char Person::GetName() const
{
	return m_name;
}

void Person::SetName(char name)
{
	m_name = name;
}

void Person::Print() const
{
	std::cout << "Name:" << m_name << " Guid:" << m_guid << std::endl;
}
