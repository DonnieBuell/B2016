// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XBorgSupporter_iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnProfile { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSearch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UINavigationItem Home { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtProfile { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtSearch { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnProfile != null) {
				btnProfile.Dispose ();
				btnProfile = null;
			}
			if (btnSearch != null) {
				btnSearch.Dispose ();
				btnSearch = null;
			}
			if (Home != null) {
				Home.Dispose ();
				Home = null;
			}
			if (txtProfile != null) {
				txtProfile.Dispose ();
				txtProfile = null;
			}
			if (txtSearch != null) {
				txtSearch.Dispose ();
				txtSearch = null;
			}
		}
	}
}
