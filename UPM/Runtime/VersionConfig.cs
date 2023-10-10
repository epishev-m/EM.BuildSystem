namespace EM.BuildSystem
{

using UnityEngine;

[CreateAssetMenu(fileName = nameof(VersionConfig), menuName = "Game/Version Config")]
public sealed class VersionConfig : ScriptableObject,
	IVersionConfig
{
	[SerializeField]
	private string _version = "0.0.1";

	[SerializeField]
	private int _code = 1;

	#region IVersion

	public string Version
	{
		get => _version;
#if UNITY_EDITOR
		set
		{
			_version = value;
		}
#endif
	}

	public int Code
	{
		get => _code;
#if UNITY_EDITOR
		set
		{
			_code = value;
		}
#endif
	}

	#endregion
}

}