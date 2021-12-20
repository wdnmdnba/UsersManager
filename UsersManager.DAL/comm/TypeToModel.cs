using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersManager.DAL.comm
{
    public static class TypeToModel
    {
        /// <summary>
        /// 将datarow 转换成 model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static T ToModel<T>(this DataRow dr)
        {
            Type type = typeof(T);
            T t = Activator.CreateInstance<T>();
            foreach (var prop in type.GetProperties())
            {
                prop.SetValue(t, dr[prop.Name]);
            }
            return t;
        }
    }
}
