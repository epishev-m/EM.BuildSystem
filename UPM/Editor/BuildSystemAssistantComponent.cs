using EM.Assistant.Editor;
using UnityEditor;
using UnityEngine.UIElements;

namespace EM.BuildSystem.Editor
{

public sealed class BuildSystemAssistantComponent : ScriptableObjectAssistantComponent<VersionConfig>
{
	private TextField _versionText;

	private IntegerField _codeInteger;

	#region ScriptableObjectAssistantComponent

	public override string Name => "BuildSystem";

	protected override string GetCreatePath()
	{
		var path = EditorUtility.SaveFilePanelInProject("Create Version Settings", "VersionConfig.asset", "asset", "");

		return path;
	}

	protected override string GetSelectPath()
	{
		var path = EditorUtility.OpenFilePanel("Select Version Config", "Assets", "asset");

		return path;
	}

	protected override void OnInitialized()
	{
		base.OnInitialized();
		CreateVersion();
		CreateCode();
	}

	protected override void OnComposed()
	{
		base.OnComposed();
		Root.AddChild(_versionText)
			.AddChild(_codeInteger);
	}

	protected override void SetConfig(VersionConfig config)
	{
		base.SetConfig(config);
		_versionText.value = Config.Version;
		_codeInteger.value = Config.Code;
	}

	#endregion

	#region BuildSystemAssistantComponent

	private void CreateVersion()
	{
		_versionText = new TextField("Version:")
			.AddValueChangedCallback<TextField, string>(value => Config.Version = value);

		if (Config != null)
		{
			_versionText.value = Config.Version;
		}
	}

	private void CreateCode()
	{
		_codeInteger = new IntegerField("Code:")
			.AddValueChangedCallback<IntegerField, int>(value => Config.Code = value);

		if (Config != null)
		{
			_codeInteger.value = Config.Code;
		}
	}

	#endregion
}

}