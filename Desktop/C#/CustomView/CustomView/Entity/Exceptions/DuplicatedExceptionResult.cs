using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity.Exceptions
{
    public enum Reason { None, Duplicated, DuplicatedAndDeleted }
    public class DuplicatedExceptionResult<T>
    {
        private List<T> _DuplicatedItems;
        public List<T> DuplicatedItems
        {
            get
            {
                if (_DuplicatedItems == null)
                {
                    _DuplicatedItems = new List<T>();
                }
                return _DuplicatedItems;
            }
            set
            {
                _DuplicatedItems = value;
            }
        }
        public Reason Reason { get; set; }
        public String Message { get; set; }
    }
}
