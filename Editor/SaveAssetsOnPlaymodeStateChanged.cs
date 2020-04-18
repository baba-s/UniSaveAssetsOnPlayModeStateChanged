using UnityEditor;

namespace UniSaveAssetsOnPlayModeStateChanged
{
	[InitializeOnLoad]
	internal static class SaveAssetsOnPlayModeStateChanged
	{
		static SaveAssetsOnPlayModeStateChanged()
		{
			EditorApplication.playModeStateChanged += change =>
			{
				if ( change != PlayModeStateChange.ExitingEditMode ) return;

				AssetDatabase.SaveAssets();
			};
		}
	}
}