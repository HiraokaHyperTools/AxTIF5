
// TIFViewerView.h : CTIFViewerView クラスのインターフェイス
//

#pragma once


class CTIFViewerView : public CView
{
protected: // シリアル化からのみ作成します。
	CTIFViewerView() noexcept;
	DECLARE_DYNCREATE(CTIFViewerView)

// 属性
public:
	CTIFViewerDoc* GetDocument() const;

// 操作
public:

// オーバーライド
public:
	virtual void OnDraw(CDC* pDC);  // このビューを描画するためにオーバーライドされます。
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:

// 実装
public:
	virtual ~CTIFViewerView();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// 生成された、メッセージ割り当て関数
protected:
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // TIFViewerView.cpp のデバッグ バージョン
inline CTIFViewerDoc* CTIFViewerView::GetDocument() const
   { return reinterpret_cast<CTIFViewerDoc*>(m_pDocument); }
#endif

