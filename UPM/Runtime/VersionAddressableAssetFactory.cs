using EM.Foundation;

namespace EM.BuildSystem
{

public sealed class VersionAddressableAssetFactory : AddressableAssetFactory<VersionConfig>
{
	#region AddressableAssetFactory

	protected override string Path => nameof(VersionConfig);

	#endregion
}

}