
// TestApp1.h : PROJECT_NAME アプリケーションのメイン ヘッダー ファイルです
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'pch.h' before including this file for PCH"
#endif

#include "resource.h"		// メイン シンボル


// xApp:
// このクラスの実装については、TestApp1.cpp を参照してください
//

class xApp : public CWinApp
{
public:
	xApp();

// オーバーライド
public:
	virtual BOOL InitInstance();

// 実装

	DECLARE_MESSAGE_MAP()
};

extern xApp theApp;
