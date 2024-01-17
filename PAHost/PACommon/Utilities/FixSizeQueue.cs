using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACommon.Utilities
{
    public class FixSizeQueue<T>
    {
        public int FixedSize { get; set; }
        private Queue<T> _innerQueue;
        private object _locker = new object();
        public int Count
        {
            get
            {
                lock (_locker)
                {
                    return _innerQueue.Count;
                }
            }
        }
        /// <summary>
        /// 先进先出集合工具
        /// </summary>
        /// <param name="size">集合最大值，超过后移除头对象</param>
        public FixSizeQueue(int size)
        {
            FixedSize = size;
            _innerQueue = new Queue<T>();
        }
        /// <summary>
        /// 添加尾对象
        /// </summary>
        /// <param name="obj"></param>
        public void Enqueue(T obj)
        {
            lock (_locker)
            {
                _innerQueue.Enqueue(obj);
                while (_innerQueue.Count > FixedSize)
                {
                    _innerQueue.Dequeue();
                }
            }
        }
        /// <summary>
        /// 获取并移除头对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool TryDequeue(out T obj)
        {
            lock (_locker)
            {
                obj = default(T);
                if (_innerQueue.Count > 0)
                {
                    obj = _innerQueue.Dequeue();
                    return true;
                }
                return false;
            }
        }
        /// <summary>
        /// 返回集合列表
        /// </summary>
        /// <returns></returns>
        public List<T> ToList()
        {
            lock (_locker)
            {
                return _innerQueue.ToList();
            }
        }
        public void Clear()
        {
            lock (_locker)
            {
                _innerQueue.Clear();
            }
        }
        /// <summary>
        /// 返回指定索引处对象
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T ElementAt(int index)
        {
            lock (_locker)
            {
                return _innerQueue.ElementAt(index);
            }
        }
        public bool IsEmpty()
        {
            lock (_locker)
            {
                return _innerQueue.Count == 0;
            }
        }
    }
}
