#pragma once

#include <memory>
#include <ximage.h>

class CTiffHolder {
	CMemFile m_tiffBlob;
	long m_numPages;

public:
	CTiffHolder() : m_numPages(0) {

	}

	long NumPages() const {
		return m_numPages;
	}
	void LoadFrom(CArchive& ar);
	std::unique_ptr<CxImage> ExtractImage(int pageIndex);
};
