
// TIFViewer.h : TIFViewer アプリケーションのメイン ヘッダー ファイル
//
#pragma once

#ifndef __AFXWIN_H__
	#error "PCH に対してこのファイルをインクルードする前に 'pch.h' をインクルードしてください"
#endif

#include "resource.h"       // メイン シンボル


// CTIFViewerApp:
// このクラスの実装については、TIFViewer.cpp を参照してください
//

class CTIFViewerApp : public CWinApp
{
public:
	CTIFViewerApp() noexcept;


// オーバーライド
public:
	virtual BOOL InitInstance();

// 実装
	afx_msg void OnAppAbout();
	DECLARE_MESSAGE_MAP()
};

extern CTIFViewerApp theApp;
