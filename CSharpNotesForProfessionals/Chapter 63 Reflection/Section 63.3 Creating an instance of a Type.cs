using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_63_Reflection_Section_63_3
{
    public class TestClass
    {
        public TestClass(string parameter)
        {
            Console.WriteLine(parameter);
        }


        public void TestMethod()
        {
            var factory = new GenericFactory<string, TestClass>();
            factory.Register("Key", typeof(string));
            TestClass newInstance = factory.Create("Key", "testParameter");
        }
    }

    public class GenericFactory<TKey, TType>
    {
        private readonly Dictionary<TKey, Func<object[], TType>> _registeredTypes; // dictionary, that holds constructor functions.

        private object _locker = new object();

        public GenericFactory()
        {
            _registeredTypes = new Dictionary<TKey, Func<object[], TType>>();
        }

        public void Register(TKey key, params Type[] parameters)
        {
            ConstructorInfo? ci = typeof(TType).GetConstructor(BindingFlags.Public |
            BindingFlags.Instance, null, CallingConventions.HasThis, parameters, new ParameterModifier[] { });

            if (ci == null)
            {
                throw new InvalidOperationException(string.Format("Construktor for type '{0}' was not found.", typeof(TType)));
            }

            Func<object[], TType> ctor;

            lock (_locker)
            {
                if (!_registeredTypes.TryGetValue(key, out ctor))
                {
                    var pExp = Expression.Parameter(typeof(object[]), "arguments"); // create parameter Expression 
                    var ctorParams = ci.GetParameters(); // get parameter info from constructor 
                    var argExpression = new Expression[ctorParams.Length];

                    for (var i = 0; i < parameters.Length; i++)
                    {
                        var indexedAccess = Expression.ArrayIndex(pExp, Expression.Constant(i));

                        if (!parameters[i].IsClass && !parameters[i].IsInterface)
                        {
                            // if so - we should create local variable that will store parameter value
                            var localVariable = Expression.Variable(parameters[i], "localVariable");
                            var block = Expression.Block(new[] { localVariable },
                            Expression.IfThenElse(Expression.Equal(indexedAccess,
                            Expression.Constant(null)),
                            Expression.Assign(localVariable,
                            Expression.Default(parameters[i])),
                            Expression.Assign(localVariable,
                            Expression.Convert(indexedAccess, parameters[i]))
                            ),
                            localVariable
                            );
                            argExpression[i] = block;
                        }
                        else
                        {
                            argExpression[i] = Expression.Convert(indexedAccess, parameters[i]);
                        }

                        var newExpr = Expression.New(ci, argExpression);
                        _registeredTypes.Add(key, Expression.Lambda(newExpr, new[] { pExp }).Compile()
as Func<object[], TType>);
                    }
                }
            }

        }
        public TType Create(TKey key, params object[] args)
        {
            Func<object[], TType> foo;
            if (_registeredTypes.TryGetValue(key, out foo))
            {
                return (TType)foo(args);
            }
            throw new ArgumentException("No type registered for this key.");
        }
    }
}
