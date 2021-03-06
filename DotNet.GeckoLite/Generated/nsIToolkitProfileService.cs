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
// Generated by IDLImporter from file nsIToolkitProfileService.idl
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
	
	
	/// <summary>nsIToolkitProfileService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9b434f48-438c-4f85-89de-b7f321a45341")]
	public interface nsIToolkitProfileService
	{
		
		/// <summary>Member GetStartWithLastProfileAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetStartWithLastProfileAttribute();
		
		/// <summary>Member SetStartWithLastProfileAttribute </summary>
		/// <param name='aStartWithLastProfile'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartWithLastProfileAttribute([MarshalAs(UnmanagedType.U1)] bool aStartWithLastProfile);
		
		/// <summary>Member GetStartOfflineAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetStartOfflineAttribute();
		
		/// <summary>Member SetStartOfflineAttribute </summary>
		/// <param name='aStartOffline'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartOfflineAttribute([MarshalAs(UnmanagedType.U1)] bool aStartOffline);
		
		/// <summary>
        ///nsIToolkitProfile </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetProfilesAttribute();
		
		/// <summary>Member GetSelectedProfileAttribute </summary>
		/// <returns>A nsIToolkitProfile</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIToolkitProfile GetSelectedProfileAttribute();
		
		/// <summary>Member SetSelectedProfileAttribute </summary>
		/// <param name='aSelectedProfile'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectedProfileAttribute([MarshalAs(UnmanagedType.Interface)] nsIToolkitProfile aSelectedProfile);
		
		/// <summary>
        /// Get a profile by name. This is mainly for use by the -P
        /// commandline flag.
        ///
        /// @param aName The profile name to find.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIToolkitProfile GetProfileByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// Lock an arbitrary path as a profile. If the path does not exist, it
        /// will be created and the defaults copied from the application directory.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIProfileLock LockProfilePath([MarshalAs(UnmanagedType.Interface)] nsILocalFile aDirectory, [MarshalAs(UnmanagedType.Interface)] nsILocalFile aTempDirectory);
		
		/// <summary>
        /// Create a new profile.
        ///
        /// @param aRootDir
        /// The profile directory. May be null, in which case a suitable
        /// default will be chosen based on the profile name.
        /// @param aTempDir
        /// The profile temporary directory. May be null, in which case a
        /// suitable default will be chosen based either on the profile name
        /// if aRootDir is null or aRootDir itself.
        /// @param aName
        /// The profile name.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIToolkitProfile CreateProfile([MarshalAs(UnmanagedType.Interface)] nsILocalFile aRootDir, [MarshalAs(UnmanagedType.Interface)] nsILocalFile aTempDir, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>
        /// Returns the number of profiles.
        /// @return 0, 1, or 2. More than 2 profiles will always return 2.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetProfileCountAttribute();
		
		/// <summary>
        /// Flush the profiles list file.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Flush();
	}
}
