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

namespace RaysHotDogs
{
	[Register ("MainMenuViewController")]
	partial class MainMenuViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnTakeAPicture { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView ivPictureImage { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnTakeAPicture != null) {
				btnTakeAPicture.Dispose ();
				btnTakeAPicture = null;
			}
			if (ivPictureImage != null) {
				ivPictureImage.Dispose ();
				ivPictureImage = null;
			}
		}
	}
}
