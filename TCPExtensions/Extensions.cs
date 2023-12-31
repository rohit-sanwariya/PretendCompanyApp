﻿ 

namespace TCPExtensions
{
    public static class Extensions
    {
        public static List<T> CoFilter<T>(this List<T> records,Func<T,bool> func)
        {
            List<T> filterList = new List<T>();
            foreach (T record in records)
            {
                if (func(record))
                {
                    filterList.Add(record);
                }
            }
            return filterList;
        }
    }
}
