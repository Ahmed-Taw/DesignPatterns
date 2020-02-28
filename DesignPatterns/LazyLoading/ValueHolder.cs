using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LazyLoading
{
    public class ValueHolder<T>
    {
        private T _value;
        private readonly IValueLoader<T> valueLoader;

        public ValueHolder( IValueLoader<T> valueLoader)
        {
            this.valueLoader = valueLoader;
        }

        public T Value {
            get { if (_value == null)
                    _value = valueLoader.Load();
                return _value;
            }

        }
    }
}
