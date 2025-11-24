//using System;

//namespace ServiceLifetimeDemo.Services
//{
//    public class ScopedGuidService : IGuidService
//    {
//        private readonly string _guid;

//        public ScopedGuidService()
//        {
//            _guid = Guid.NewGuid().ToString();
//        }

//        public string GetGuid() => _guid;
//    }
//}
namespace ServiceLifetimeDemo.Services;

// SCOPED = One instance per HTTP request
public class ScopedGuidService : IGuidService
{
    public Guid Guid { get; } = Guid.NewGuid();
}
