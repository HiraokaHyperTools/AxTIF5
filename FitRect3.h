#pragma once

class FitRect3 {
public:
	static CRect ZoomFit(CRect rcClip, CSize sizePic) {
		// �k��
		float fClip = (float)rcClip.Width() / (std::max)(1, rcClip.Height());
		float fPic = (float)sizePic.cx / (std::max)(1L, sizePic.cy);
		if (fClip <= fPic) {
			// �摜����
			int yc = (rcClip.top + rcClip.bottom) / 2;
			int yv = (int)(((double)sizePic.cy / sizePic.cx) * rcClip.Width());
			return CRect(
				rcClip.left,
				yc - yv / 2,
				rcClip.right,
				yc - yv / 2 + yv
			);
		}
		else {
			// �摜�c��
			int xc = (rcClip.left + rcClip.right) / 2;
			int xv = (int)(((double)sizePic.cx / sizePic.cy) * rcClip.Height());
			return CRect(
				xc - xv / 2,
				rcClip.top,
				xc - xv / 2 + xv,
				rcClip.bottom
			);
		}
	}

};