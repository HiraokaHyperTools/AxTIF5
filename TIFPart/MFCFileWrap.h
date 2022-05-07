#pragma once

class CMFCFileWrap : public CxFile {
	CFile& r;
public:

	CMFCFileWrap(CFile& r) : r(r), errn(0) { }

	int errn;

	virtual bool	Close()
	{
		r.Close();
		return true;
	}
	virtual size_t	Read(void* buffer, size_t size, size_t count)
	{
		if (size != 0)
			return r.Read(buffer, size * count) / size;
		return 0;
	}
	virtual size_t	Write(const void* buffer, size_t size, size_t count)
	{
		errn = 1;
		return 0;
	}
	virtual bool	Seek(long offset, int origin)
	{
		if (r.Seek(offset, origin) == offset)
			return true;
		return false;
	}
	virtual long	Tell()
	{
		return r.Seek(0, CFile::current);
	}
	virtual long	Size()
	{
		return r.GetLength();
	}
	virtual bool	Flush()
	{
		r.Flush();
		return true;
	}
	virtual bool	Eof()
	{
		return r.GetPosition() >= r.GetLength();
	}
	virtual long	Error()
	{
		return errn;
	}
	virtual bool	PutC(unsigned char c)
	{
		// Default implementation
		size_t nWrote = Write(&c, 1, 1);
		return (bool)(nWrote == 1);
	}
	virtual long	GetC()
	{
		BYTE b;
		if (1 == Read(&b, 1, 1))
			return b;
		return -1;
	}
	virtual char* GetS(char* string, int n)
	{
		ASSERT(false);
		errn = 1;
		return NULL;
	}
	virtual long	Scanf(const char* format, void* output)
	{
		ASSERT(false);
		return 0;
	}
};
