
#include "pch.h"
#include "TiffHolder.h"
#include "MFCFileWrap.h"

void TIFFEH(const char*, const char*, va_list)
{

}

void CTiffHolder::LoadFrom(CArchive& ar) {
	{
		std::unique_ptr<BYTE[]> buf(new BYTE[1048576]);
		while (true) {
			UINT numRead = ar.Read(buf.get(), 1048576);
			if (numRead == 0) {
				break;
			}
			m_tiffBlob.Write(buf.get(), numRead);
		}
		m_tiffBlob.SeekToBegin();
	}

	{
		CMFCFileWrap xFile(m_tiffBlob);

		CxImageTIF loader;
		loader.SetEscape(-1);
		if (loader.Decode(&xFile)) {
			m_numPages = loader.GetNumFrames();
		}
		else {
			AfxThrowArchiveException(CArchiveException::badIndex);
		}
	}
}

std::unique_ptr<CxImage> CTiffHolder::ExtractImage(int pageIndex) {
	CMFCFileWrap xFile(m_tiffBlob);

	std::unique_ptr<CxImageTIF> image(new CxImageTIF());
	image->SetFrame(pageIndex);

	m_tiffBlob.SeekToBegin();

	if (!image->Decode(&xFile)) {
		image.reset();
	}
	return image;
}
