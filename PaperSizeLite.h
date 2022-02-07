#pragma once

class PaperSizeLite {
public:
	short dmOrientation;
	short dmPaperSize;
	short dmPaperLength;
	short dmPaperWidth;

	void Apply(LPCSTR name, int xHi, int yHi) {
		dmPaperSize = DMPAPER_USER;
		dmPaperWidth = (short)(xHi / 0.2539298669891173);
		dmPaperLength = (short)(yHi / 0.2539298669891173);
	}

	void CopyTo(DEVMODE &dm) {
		dm.dmOrientation = dmOrientation;
		dm.dmPaperSize = dmPaperSize;
		dm.dmPaperLength = dmPaperLength;
		dm.dmPaperWidth = dmPaperWidth;
	}
};
