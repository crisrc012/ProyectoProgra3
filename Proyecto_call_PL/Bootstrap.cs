using System;
using System.IO;
using System.Linq;
using System.Reflection;
using StructureMap;

namespace Proyecto_call_PL
{
    public static class Bootstrap
    {
        private static Container Container { get; set; }

        public static void Init()
        {
            const string filter = "*Proyecto*.dll";
            Container = new Container();

            foreach (var assembly in Directory.EnumerateFiles(AppDomain.CurrentDomain.RelativeSearchPath ?? AppDomain.CurrentDomain.BaseDirectory, filter).Select(Assembly.LoadFrom))
            {
                foreach (var type in assembly.GetTypes().Where(x => x.IsClass && x.IsSealed))
                {
                    Container.Configure(x =>
                        {
                            foreach (var interfaces in type.GetInterfaces().Where(w => w != typeof(IDisposable)))
                            {
                                var instance = x.For(interfaces).Use(type).Named(type.FullName);
                                instance.Singleton();
                            }
                        }
                    );
                }
            }
        }

        public static T GetInstance<T>()
        {
            if (Container != null)
                return Container.GetInstance<T>();

            Container = new Container();
            Init();

            return Container.GetInstance<T>();
        }
    }
}