// AxTIF3Doc.cpp : CTIFFDoc クラスの実装
//

#include "pch.h"

#include "TIFFDoc.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CTIFFDoc

IMPLEMENT_DYNCREATE(CTIFFDoc, CDocument)

BEGIN_MESSAGE_MAP(CTIFFDoc, CDocument)
END_MESSAGE_MAP()


// CTIFFDoc コンストラクション/デストラクション

CTIFFDoc::CTIFFDoc()
{
}

CTIFFDoc::~CTIFFDoc()
{
}

BOOL CTIFFDoc::OnNewDocument()
{
	if (!CDocument::OnNewDocument())
		return FALSE;

	m_tiff.reset(new CTiffHolder());

	return TRUE;
}

// CTIFFDoc シリアル化

void CTIFFDoc::Serialize(CArchive& ar)
{
	if (ar.IsStoring())
	{
		AfxThrowNotSupportedException();
	}
	else
	{
		m_tiff.reset(new CTiffHolder());

		m_tiff->LoadFrom(ar);

		UpdateAllViews(NULL, UPHINT_LOADED);
	}
}


// CTIFFDoc 診断

#ifdef _DEBUG
void CTIFFDoc::AssertValid() const
{
	CDocument::AssertValid();
}

void CTIFFDoc::Dump(CDumpContext& dc) const
{
	CDocument::Dump(dc);
}
#endif //_DEBUG


// CTIFFDoc コマンド
