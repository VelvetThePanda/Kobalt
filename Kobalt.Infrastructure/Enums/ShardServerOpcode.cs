namespace Kobalt.Infrastructure.Enums;

/// <summary>
/// An enum of op-codes the shard coordinator uses to communicate with the shard.
/// </summary>
public enum ShardServerOpcode : byte
{
    Dispatch,
    Hello,
    Identify,
    Ready
}
