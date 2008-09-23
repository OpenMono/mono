// THIS FILE AUTOMATICALLY GENERATED BY xpidl2cs.pl
// EDITING IS PROBABLY UNWISE
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2007, 2008 Novell, Inc.
//
// Authors:
//	Andreia Gaita (avidigal@novell.com)
//

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mono.Mozilla {

	[Guid ("8bb35ed9-e332-462d-9155-4a002ab5c958")]
	[InterfaceType (ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport ()]
	internal interface nsIServiceManager {

#region nsIServiceManager
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IntPtr getService ([MarshalAs (UnmanagedType.LPStruct)]  Guid aClass,
				[MarshalAs (UnmanagedType.LPStruct)]  Guid aIID);

		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IntPtr getServiceByContractID ([MarshalAs (UnmanagedType.LPStr)]  string aContractID,
				[MarshalAs (UnmanagedType.LPStruct)]  Guid aIID);

		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool isServiceInstantiated ([MarshalAs (UnmanagedType.LPStruct)]  Guid aClass,
				[MarshalAs (UnmanagedType.LPStruct)]  Guid aIID);

		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool isServiceInstantiatedByContractID ([MarshalAs (UnmanagedType.LPStr)]  string aContractID,
				[MarshalAs (UnmanagedType.LPStruct)]  Guid aIID);

#endregion
	}


	internal class nsServiceManager {
		public static nsIServiceManager GetProxy (Mono.WebBrowser.IWebBrowser control, nsIServiceManager obj)
		{
			object o = Base.GetProxyForObject (control, typeof(nsIServiceManager).GUID, obj);
			return o as nsIServiceManager;
		}
	}
}
#if example

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

	internal class ServiceManager : nsIServiceManager {

#region nsIServiceManager
		[return: MarshalAs (UnmanagedType.Interface)] IntPtr nsIServiceManager.getService ([MarshalAs (UnmanagedType.LPStruct)]  Guid aClass,
				[MarshalAs (UnmanagedType.LPStruct)]  Guid aIID,
				out IntPtr result)
		{
			return ;
		}



		[return: MarshalAs (UnmanagedType.Interface)] IntPtr nsIServiceManager.getServiceByContractID ([MarshalAs (UnmanagedType.LPStr)]  string aContractID,
				[MarshalAs (UnmanagedType.LPStruct)]  Guid aIID,
				out IntPtr result)
		{
			return ;
		}



		bool nsIServiceManager.isServiceInstantiated ([MarshalAs (UnmanagedType.LPStruct)]  Guid aClass,
				[MarshalAs (UnmanagedType.LPStruct)]  Guid aIID)
		{
			return ;
		}



		bool nsIServiceManager.isServiceInstantiatedByContractID ([MarshalAs (UnmanagedType.LPStr)]  string aContractID,
				[MarshalAs (UnmanagedType.LPStruct)]  Guid aIID)
		{
			return ;
		}



#endregion
	}
#endif
