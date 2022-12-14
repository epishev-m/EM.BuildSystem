namespace EM.BuildSystem.Editor
{

using Foundation.Editor; 
using UnityEditor;

public sealed class AssistantWindowComponentBuildSystem : ScriptableObjectAssistantWindowComponent<VersionConfig>
{
	#region ScriptableObjectAssistantWindowComponent

	public override string Name => "BuildSystem";

	protected override string GetCreatePath()
	{
		var path = EditorUtility.SaveFilePanelInProject("Create Version Config", "VersionConfig.asset", "asset", "");

		return path;
	}

	protected override string GetSelectPath()
	{
		var path = EditorUtility.OpenFilePanel("Select Version Config", "Assets", "asset");

		return path;
	}

	protected override void OnGUIConfig()
	{
		OnGUIVersion();
		OnGUICode();
	}

	#endregion

	#region AssistantWindowComponentBuildSystem

	private void OnGUIVersion()
	{
		EditorGUILayout.LabelField("Version:");

		if (string.IsNullOrWhiteSpace(Config.Version))
		{
			EditorGUILayout.HelpBox("Version not set", MessageType.Warning);
		}

		Config.Version = EditorGUILayout.TextField(Config.Version);
	}

	private void OnGUICode()
	{
		EditorGUILayout.LabelField("Code:");

		if (Config.Code <= 0)
		{
			EditorGUILayout.HelpBox("Code not set", MessageType.Warning);
		}

		Config.Code = EditorGUILayout.IntField(Config.Code);
	}

	#endregion
}

}
