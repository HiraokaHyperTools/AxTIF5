// InnerFrame.cpp : 実装ファイル
//

#include "pch.h"
#include "TIFFInnerFrame.h"

#include "TIFFDoc.h"
#include "TIFFView.h"

// CTIFFInnerFrame

IMPLEMENT_DYNCREATE(CTIFFInnerFrame, CFrameWnd)

CTIFFInnerFrame::CTIFFInnerFrame()
{
	m_view.m_fAllowSelfDelete = false;
}

CTIFFInnerFrame::~CTIFFInnerFrame()
{
}


BEGIN_MESSAGE_MAP(CTIFFInnerFrame, CFrameWnd)
	ON_WM_ERASEBKGND()
END_MESSAGE_MAP()


// CTIFFInnerFrame メッセージ ハンドラ

BOOL CTIFFInnerFrame::OnCreateClient(LPCREATESTRUCT lpcs, CCreateContext* pContext) {
	if (m_view.Create(NULL, NULL, AFX_WS_DEFAULT_VIEW,CRect(0,0,0,0), this, AFX_IDW_PANE_FIRST, pContext))
		return true;

	return false;
//	return CFrameWnd::OnCreateClient(lpcs, pContext);
}

void CTIFFInnerFrame::PostNcDestroy() {
//	CFrameWnd::PostNcDestroy();
}

BOOL CTIFFInnerFrame::PreCreateWindow(CREATESTRUCT& cs)
{
	if (!CFrameWnd::PreCreateWindow(cs))
		return false;

	cs.style |= WS_CLIPCHILDREN|WS_CLIPSIBLINGS;
	cs.dwExStyle &= ~WS_EX_CLIENTEDGE;
	return true;
}

BOOL CTIFFInnerFrame::OnEraseBkgnd(CDC* pDC) {
	return 1;
//	return CFrameWnd::OnEraseBkgnd(pDC);
}
