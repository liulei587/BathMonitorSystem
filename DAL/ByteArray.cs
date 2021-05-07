using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 字节集合类
    /// </summary>
    public class ByteArray
    {
        List<byte> list;
        //构造函数
        public ByteArray()
        {
            list = new List<byte>();
        }
        public ByteArray(int size)
        {
            list = new List<byte>(size);
        }
        //属性
        public byte[] Array
        {
            get { return list.ToArray(); }
        }
        //添加方法
        public void Add(byte item)
        {
            list.Add(item);
        }
        public void Add(byte[] items)
        {
            list.AddRange(items);
        }
        //清空方法
        public void Clear()
        {
            list.Clear();
        }
    }
}
