using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "AssetSearch")]
public class AssetSearch : ScriptableObject
{

	[MenuItem("GameObject/Create Material")]
	
	void OnEnable()
	{
		
		Material material = new Material(Shader.Find("Standard"));
		
		//AssetDatabase.CreateAsset(material, "Assets/Other.mat");
		//AssetDatabase.CreateFolder("Assets", "NewFolder");
		AssetDatabase.DeleteAsset("Assets/New.mat");
		AssetDatabase.SaveAssets();
		
		// Print the path of the created asset
		Debug.Log(AssetDatabase.GetAssetPath(material));
	}
}