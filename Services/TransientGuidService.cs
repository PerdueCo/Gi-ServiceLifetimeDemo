//using System;

//namespace ServiceLifetimeDemo.Services
//{
//    public class TransientGuidService : IGuidService
//    {
//        private readonly string _guid;

//        public TransientGuidService()
//        {
//            _guid = Guid.NewGuid().ToString();
//        }

//        public string GetGuid() => _guid;
//    }
//}
namespace ServiceLifetimeDemo.Services;

// TRANSIENT = New instance every time it is requested
public class TransientGuidService : IGuidService
{
    public Guid Guid { get; } = Guid.NewGuid();
}

