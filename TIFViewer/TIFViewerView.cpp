
// TIFViewerView.cpp : CTIFViewerView クラスの実装
//

#include "pch.h"
#include "framework.h"
// SHARED_HANDLERS は、プレビュー、縮小版、および検索フィルター ハンドラーを実装している ATL プロジェクトで定義でき、
// そのプロジェクトとのドキュメント コードの共有を可能にします。
#ifndef SHARED_HANDLERS
#include "TIFViewer.h"
#endif

#include "TIFViewerDoc.h"
#include "TIFViewerView.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CTIFViewerView

IMPLEMENT_DYNCREATE(CTIFViewerView, CView)

BEGIN_MESSAGE_MAP(CTIFViewerView, CView)
END_MESSAGE_MAP()

// CTIFViewerView コンストラクション/デストラクション

CTIFViewerView::CTIFViewerView() noexcept
{
	// TODO: 構築コードをここに追加します。

}

CTIFViewerView::~CTIFViewerView()
{
}

BOOL CTIFViewerView::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: この位置で CREATESTRUCT cs を修正して Window クラスまたはスタイルを
	//  修正してください。

	return CView::PreCreateWindow(cs);
}

// CTIFViewerView 描画

void CTIFViewerView::OnDraw(CDC* /*pDC*/)
{
	CTIFViewerDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	if (!pDoc)
		return;

	// TODO: この場所にネイティブ データ用の描画コードを追加します。
}


// CTIFViewerView の診断

#ifdef _DEBUG
void CTIFViewerView::AssertValid() const
{
	CView::AssertValid();
}

void CTIFViewerView::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CTIFViewerDoc* CTIFViewerView::GetDocument() const // デバッグ以外のバージョンはインラインです。
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CTIFViewerDoc)));
	return (CTIFViewerDoc*)m_pDocument;
}
#endif //_DEBUG


// CTIFViewerView メッセージ ハンドラー
