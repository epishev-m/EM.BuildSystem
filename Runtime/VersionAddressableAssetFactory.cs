namespace EM.BuildSystem
{

using Foundation;

public sealed class VersionAddressableAssetFactory : AddressableAssetFactory<VersionConfig>
{
	#region AddressableAssetFactory

	protected override string Path => nameof(VersionConfig);

	#endregion
}

}