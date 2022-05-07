#pragma once

#include "TIFFView.h"

// CTIFFInnerFrame フレーム

class CTIFFInnerFrame : public CFrameWnd
{
	DECLARE_DYNCREATE(CTIFFInnerFrame)
protected:

public:
	CTIFFInnerFrame();           // 動的生成で使用される protected コンストラクタ
	virtual ~CTIFFInnerFrame();

	CTIFFView m_view;

protected:
	DECLARE_MESSAGE_MAP()
	virtual BOOL OnCreateClient(LPCREATESTRUCT lpcs, CCreateContext* pContext);
	virtual void PostNcDestroy();
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
public:
	afx_msg BOOL OnEraseBkgnd(CDC* pDC);
};


