// Demo_CPP_To_CSharp.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#import "..\DemoStackLib\bin\Debug\DemoStackLib.tlb" raw_interfaces_only

using namespace DemoStackLib;

int _tmain()
{
	HRESULT hr = CoInitialize(NULL);
	IStackPtr pIStack;
	
	static CComPtr<IStack> d_StackObj = NULL;

	//pIStack.CreateInstance(__uuidof(Stack));

	//d_StackObj.CoCreateInstance(__uuidof(Stack));

	if (d_StackObj != NULL)
	{
		pIStack->Push(10);
		long val;
		pIStack->TOS(&val);
		printf("Pop = %d\n", val);

		pIStack->Pop(&val);
		printf("Pop = %d\n", val);
		getchar();
	}
	
	CoUninitialize();
    return 0;
}

