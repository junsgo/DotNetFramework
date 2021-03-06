// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsISample.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// The uuid is a unique number identifying the interface normally
    /// called IID. It can be generated as follows:
    ///
    /// Windows: guidgen.exe
    /// Unix: uuidgen which comes with e2fsprogs package
    /// Mac: ???
    /// All platform: Using irc, connect to irc.mozilla.org and type in
    /// /join #mozilla
    /// /msg mozbot uuid
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7CB5B7A1-07D7-11d3-BDE2-000064657374")]
	public interface nsISample
	{
		
		/// <summary>
        /// The uuid is a unique number identifying the interface normally
        /// called IID. It can be generated as follows:
        ///
        /// Windows: guidgen.exe
        /// Unix: uuidgen which comes with e2fsprogs package
        /// Mac: ???
        /// All platform: Using irc, connect to irc.mozilla.org and type in
        /// /join #mozilla
        /// /msg mozbot uuid
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetValueAttribute();
		
		/// <summary>
        /// The uuid is a unique number identifying the interface normally
        /// called IID. It can be generated as follows:
        ///
        /// Windows: guidgen.exe
        /// Unix: uuidgen which comes with e2fsprogs package
        /// Mac: ???
        /// All platform: Using irc, connect to irc.mozilla.org and type in
        /// /join #mozilla
        /// /msg mozbot uuid
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValueAttribute([MarshalAs(UnmanagedType.LPStr)] string aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WriteValue([MarshalAs(UnmanagedType.LPStr)] string aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Poke([MarshalAs(UnmanagedType.LPStr)] string aValue);
	}
}
