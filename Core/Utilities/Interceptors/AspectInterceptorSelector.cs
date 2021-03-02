using Castle.DynamicProxy;
using System;
using System.Linq;
using System.Reflection;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute> //class attributelarını oku
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name) //metod attributelarını oku
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes); //listeye ekle
            /*  classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger))); /*bu kod tüm olan ve eklenecek tüm metodlara 
                                                                               loglama özelliğini getirir, sürdürülebilirlik açısından mükemmel.*/

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }

}
