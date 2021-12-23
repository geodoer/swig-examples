#include"simple/person.h"
/* C++中间层
1. 代理了一下simple模块中的内容
2. 并将函数导出到动态链接库中，如此其他模块才能调用
3. 没有C++模块需要引用此模块，所以这里不需要像simple/config.h中一样，添加dllimport，只需dllexport即可
 */
#define EXPORT	__declspec(dllexport)
#define STDCALL __stdcall

extern "C" {
	EXPORT int STDCALL CSharp_Person_Guid(void * jarg1) {
		Person* arg1 = (Person *)jarg1;
		return ((Person const *)arg1)->Guid();
	}

	EXPORT char STDCALL CSharp_Person_GetName(void * jarg1) {
		Person *arg1 = (Person *)jarg1;
		return (char)((Person const *)arg1)->GetName();
	}

	EXPORT void STDCALL CSharp_Person_SetName(void * jarg1, char jarg2) {
		Person * arg1 = (Person *)jarg1;
		(arg1)->SetName(jarg2);
	}

	EXPORT void STDCALL CSharp_Person_Print(void * jarg1) {
		Person *arg1 = (Person *)jarg1;
		((Person const *)arg1)->Print();
	}

	EXPORT void * STDCALL CSharp_new_Person(int jarg1) {
		Person * result = (Person *)new Person(jarg1);
		return (void *)result;
	}

	EXPORT void STDCALL CSharp_delete_Person(void * jarg1) {
		Person *arg1 = (Person *)jarg1;
		delete arg1;
	}
}