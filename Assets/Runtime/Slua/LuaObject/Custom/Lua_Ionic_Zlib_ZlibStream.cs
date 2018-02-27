using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Ionic_Zlib_ZlibStream : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			Ionic.Zlib.ZlibStream o;
			if(argc==3){
				System.IO.Stream a1;
				checkType(l,2,out a1);
				Ionic.Zlib.CompressionMode a2;
				checkEnum(l,3,out a2);
				o=new Ionic.Zlib.ZlibStream(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.IO.Stream),typeof(Ionic.Zlib.CompressionMode),typeof(Ionic.Zlib.CompressionLevel))){
				System.IO.Stream a1;
				checkType(l,2,out a1);
				Ionic.Zlib.CompressionMode a2;
				checkEnum(l,3,out a2);
				Ionic.Zlib.CompressionLevel a3;
				checkEnum(l,4,out a3);
				o=new Ionic.Zlib.ZlibStream(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.IO.Stream),typeof(Ionic.Zlib.CompressionMode),typeof(bool))){
				System.IO.Stream a1;
				checkType(l,2,out a1);
				Ionic.Zlib.CompressionMode a2;
				checkEnum(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				o=new Ionic.Zlib.ZlibStream(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==5){
				System.IO.Stream a1;
				checkType(l,2,out a1);
				Ionic.Zlib.CompressionMode a2;
				checkEnum(l,3,out a2);
				Ionic.Zlib.CompressionLevel a3;
				checkEnum(l,4,out a3);
				System.Boolean a4;
				checkType(l,5,out a4);
				o=new Ionic.Zlib.ZlibStream(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Flush(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			self.Flush();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Read(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.Read(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Seek(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			System.Int64 a1;
			checkType(l,2,out a1);
			System.IO.SeekOrigin a2;
			checkEnum(l,3,out a2);
			var ret=self.Seek(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLength(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			System.Int64 a1;
			checkType(l,2,out a1);
			self.SetLength(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Write(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.Write(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CompressString_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=Ionic.Zlib.ZlibStream.CompressString(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CompressBuffer_s(IntPtr l) {
		try {
			System.Byte[] a1;
			checkArray(l,1,out a1);
			var ret=Ionic.Zlib.ZlibStream.CompressBuffer(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UncompressString_s(IntPtr l) {
		try {
			System.Byte[] a1;
			checkArray(l,1,out a1);
			var ret=Ionic.Zlib.ZlibStream.UncompressString(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UncompressBuffer_s(IntPtr l) {
		try {
			System.Byte[] a1;
			checkArray(l,1,out a1);
			var ret=Ionic.Zlib.ZlibStream.UncompressBuffer(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_FlushMode(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.FlushMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_FlushMode(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			Ionic.Zlib.FlushType v;
			checkEnum(l,2,out v);
			self.FlushMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_BufferSize(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.BufferSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_BufferSize(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.BufferSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_TotalIn(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.TotalIn);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_TotalOut(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.TotalOut);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_CanRead(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CanRead);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_CanSeek(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CanSeek);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_CanWrite(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CanWrite);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Length(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Length);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Position(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_Position(IntPtr l) {
		try {
			Ionic.Zlib.ZlibStream self=(Ionic.Zlib.ZlibStream)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.Position=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Ionic.Zlib.ZlibStream");
		addMember(l,Flush);
		addMember(l,Read);
		addMember(l,Seek);
		addMember(l,SetLength);
		addMember(l,Write);
		addMember(l,CompressString_s);
		addMember(l,CompressBuffer_s);
		addMember(l,UncompressString_s);
		addMember(l,UncompressBuffer_s);
		addMember(l,"FlushMode",get_FlushMode,set_FlushMode,true);
		addMember(l,"BufferSize",get_BufferSize,set_BufferSize,true);
		addMember(l,"TotalIn",get_TotalIn,null,true);
		addMember(l,"TotalOut",get_TotalOut,null,true);
		addMember(l,"CanRead",get_CanRead,null,true);
		addMember(l,"CanSeek",get_CanSeek,null,true);
		addMember(l,"CanWrite",get_CanWrite,null,true);
		addMember(l,"Length",get_Length,null,true);
		addMember(l,"Position",get_Position,set_Position,true);
		createTypeMetatable(l,constructor, typeof(Ionic.Zlib.ZlibStream),typeof(System.IO.Stream));
	}
}
