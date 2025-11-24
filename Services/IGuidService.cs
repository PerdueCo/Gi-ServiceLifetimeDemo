namespace ServiceLifetimeDemo.Services;

// This interface exposes a single GUID value.
// All 3 lifetime services implement it.
public interface IGuidService
{
    Guid Guid { get; }
}
