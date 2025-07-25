#pragma once

#define WIN32_LEAN_AND_MEAN

#define _ATL_CSTRING_EXPLICIT_CONSTRUCTORS	// 一部の CString コンストラクタは明示的です。

#include <afxctl.h>         // MFC の ActiveX  コントロール
#include <afxext.h>         // MFC の拡張部分
#ifndef _AFX_NO_OLE_SUPPORT
#include <afxdtctl.h>		// MFC の Internet Explorer 4 コモン コントロール サポート
#endif
#ifndef _AFX_NO_AFXCMN_SUPPORT
#include <afxcmn.h>			// MFC の Windows コモン コントロール サポート
#endif // _AFX_NO_AFXCMN_SUPPORT

// MFC のデータベース クラスを使用しない場合は、以下の 2 行のインクルード
//  ファイルの記述を削除してください。
#ifndef _WIN64

#ifndef _AFX_NO_DB_SUPPORT
#include <afxdb.h>			// MFC ODBC データベース クラス
#endif // _AFX_NO_DB_SUPPORT

#ifndef _AFX_NO_DAO_SUPPORT
#include <afxdao.h>			// MFC DAO データベース クラス
#endif // _AFX_NO_DAO_SUPPORT

#endif // _WIN64

#include <objsafe.h>

#include <atlbase.h>
#include <atlcom.h>

#include <ximage.h>
#include <ximatif.h>
#include <ximabmp.h>
#include <algorithm>
#include <atlcoll.h>
#include <afxwin.h>

#include <urlmon.h>
#include <memory>
#include <afxwin.h>
