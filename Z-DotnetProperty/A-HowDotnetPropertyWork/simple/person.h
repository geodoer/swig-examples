#pragma once
#include"config.h"

/**
 * @brief Person类
 */
class SIMPLE_EXPORT Person
{
public:
	Person(int guid);
	/**
	 * @brief 系统唯一ID
	 * @return string
	 */
	int Guid() const;
	/**
	 * @brief Get the Name object
	 * @return string
	 */
	char GetName() const;
	/**
	 * @brief Set the Name object
	 * @param  name
	 */
	void SetName(char name);
	/**
	 * @brief Print Person's Information
	 */
	void Print() const;
protected:
	int		m_guid;
	char	m_name;
};