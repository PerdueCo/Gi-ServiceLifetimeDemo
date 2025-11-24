//using System;

//namespace ServiceLifetimeDemo.Services
//{
//    public class SingletonGuidService : IGuidService
//    {
//        private readonly string _guid;

//        public SingletonGuidService()
//        {
//            _guid = Guid.NewGuid().ToString();
//        }

//        public string GetGuid() => _guid;
//    }
//}
namespace ServiceLifetimeDemo.Services;

// SINGLETON = One instance for the entire application
public class SingletonGuidService : IGuidService
{
    public Guid Guid { get; } = Guid.NewGuid();
}
