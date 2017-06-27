using UnityEditor;
using UnityEngine;

public class ExternalAssetManager
{
	[MenuItem("Assets/External Asset Manager/Build")]
	static void Build()
	{
		Debug.Log("Build");
	}

	[MenuItem("Assets/External Asset Manager/Upload")]
	static void Upload()
	{
		Debug.Log("Upload");
	}

	[MenuItem("Assets/External Asset Manager/Delete")]
	static void Delete()
	{
		Debug.Log("Delete");
	}

	[MenuItem("Assets/External Asset Manager/Install")]
	static void Install()
	{
		Debug.Log("Install");
	}

	[MenuItem("Assets/External Asset Manager/Reload")]
	static void Reload()
	{
		Debug.Log("Reload");
	}
}