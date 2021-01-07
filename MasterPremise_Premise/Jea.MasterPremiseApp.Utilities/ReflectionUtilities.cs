using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Jea.MasterPremiseApp.Utilities
{
    public static class ReflectionUtilities
    {
        public static IEnumerable<Type> GetTypesDerivedFrom<T>() where T : class =>
            Assembly.GetAssembly(typeof(T)).GetTypes()
                .Where(type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(T)));

        //public static IEnumerable<Type> GetImplementingInterfacesOfType<TClass, TInterface>() where T : class =>
        //    typeof(TClass).FindInterfaces((type, criteria) => type == typeof(TInterface), null);

        public static IEnumerable<(Type serviceType, Type implementationType)> GetTypesForRegistration<TBaseClass, TBaseInterface>()
        {
            //var v1 = from implementingType in Assembly.GetAssembly(typeof(TBaseClass)).GetTypes()
            //     .Where(type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(TBaseClass)))
            //     select implementingType;
            //var v2 = from implementingType in v1 
            //         from allInterface in implementingType.FindInterfaces((type, criteria) => typeof(TBaseInterface).IsAssignableFrom(type), null)
            //         select allInterface;
            //var v3 = from implementingType in v1
            //         from allInterface in v2
            //         from indirectInterface in allInterface.GetInterfaces().Concat(implementingType.BaseType?.GetInterfaces())
            //         select indirectInterface;
            //var v4 = from allInterface in v2
            //         join indirectInterface in v3 on allInterface.FullName equals "asdfasd" into gj
            //         from sub in gj.DefaultIfEmpty()
            //         //where allInterface == indirectInterface
            //         select new {allInterface.FullName, Sub = sub?.Name ?? String.Empty };
            var result = (from implementingType in Assembly.GetAssembly(typeof(TBaseClass)).GetTypes()
                .Where(type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(TBaseClass)))
                   from allInterface in implementingType.FindInterfaces((type, criteria) => typeof(TBaseInterface).IsAssignableFrom(type), null)
                   let indirectInterfaces = allInterface.GetInterfaces().Concat(implementingType.BaseType?.GetInterfaces())
                          //from indirectInterface in indirectInterfaces
                          where indirectInterfaces.Contains(allInterface) == false
                   select (allInterface, implementingType))
                   .Distinct();
            return result;
        }
    }
}
