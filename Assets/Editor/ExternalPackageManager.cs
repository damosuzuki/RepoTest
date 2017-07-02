using UnityEditor;
using UnityEngine;

public class ExternalPackageManager
{
	[MenuItem("Assets/External Package Manager/Export")]
	static void Export()
	{
        // Export all packages defined in package.json and upload them to S3
        Debug.Log("Export");
	}

    [MenuItem("Assets/External Package Manager/Install")]
    static void Install()
    {
        // Download and import all packages from package.json
        Debug.Log("Install");
    }

    [MenuItem("Assets/External Package Manager/Delete")]
	static void Delete()
	{
        // Delete all packages in ./Assets/External
        Debug.Log("Delete");
	}

	
}