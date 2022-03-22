using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;

namespace Bitboys.SuperPlaftormer2D {

public class UnityPack {

		[MenuItem("Create/Unity Package")]
		private static void Create()
		{

		string [] projectContent = AssetDatabase.GetAllAssetPaths();

			//AssetDatabase.ExportPackage (projectContent, "SP2D_Mobile", ExportPackageOptions.Recurse);
			AssetDatabase.ExportPackage (projectContent, "SP2D_Mobile",ExportPackageOptions.IncludeLibraryAssets);

		Debug.Log ("Project Exported");
}
}
}
