// AxTIF3Doc.h : CTIFFDoc クラスのインターフェイス
//


#pragma once

#include "TiffHolder.h"

#define UPHINT_LOADED 1

class CAxTIF3SrvrItem;

class CTIFFDoc : public CDocument
{
protected: // シリアル化からのみ作成します。
	CTIFFDoc();
	DECLARE_DYNCREATE(CTIFFDoc)

// 属性
public:

// 操作
public:

// オーバーライド
protected:
public:
	virtual BOOL OnNewDocument();
	virtual void Serialize(CArchive& ar);

// 実装
public:
	virtual ~CTIFFDoc();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// 生成された、メッセージ割り当て関数
protected:
	DECLARE_MESSAGE_MAP()

public:
	std::shared_ptr<CTiffHolder> m_tiff;
};
