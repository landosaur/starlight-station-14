using System.Linq;
using Content.Shared.Administration;
using Robust.Shared.Player;

namespace Content.Shared.Starlight;

public interface ISharedPlayersRoleManager
{

    PlayerData? GetPlayerData(EntityUid uid);
    PlayerData? GetPlayerData(ICommonSession session);
    bool IsAllRolesAvailable(ICommonSession session);

    bool HasPlayerFlag(EntityUid player, PlayerFlags flag)
    {
        var data = GetPlayerData(player);
        return data != null && data.HasFlag(flag);
    }
    bool HasPlayerFlag(ICommonSession player, PlayerFlags flag)
    {
        var data = GetPlayerData(player);
        return data != null && data.HasFlag(flag);
    }
    bool HasAnyPlayerFlags(EntityUid player, List<PlayerFlags> flags)
    {
        var data = GetPlayerData(player);
        return data != null && flags.Any(data.HasFlag);
    }
    bool HasAnyPlayerFlags(ICommonSession player, List<PlayerFlags> flags)
    {
        var data = GetPlayerData(player);
        return data != null && flags.Any(data.HasFlag);
    }
}
