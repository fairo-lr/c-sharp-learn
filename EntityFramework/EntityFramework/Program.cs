using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;


namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new OAEntities())
            {
                //ctx.Configuration.ProxyCreationEnabled
                var studentEntity = ctx.OA_YS.FirstOrDefault<OA_YS>();
                Console.Write(ObjectContext.GetObjectType(studentEntity.GetType())); //动态代理的POCO类型

                // 添加
                ctx.OA_CG_SUPP.Add(new OA_CG_SUPP { CGS_NOTE="添加"});
                ctx.SaveChanges();

                // 查询 & 修改
                // 查询的时候其实是一个unchange的状态
                var studentEntity2 = ctx.OA_YS.FirstOrDefault<OA_YS>();//unchange
                studentEntity2.YS_CREATER = "刘瑞";//修改状态
                ctx.SaveChanges();//保存状态

                // 删除
                ctx.OA_YS.Remove(studentEntity2);
                ctx.SaveChanges();//只有保存状态, 才会对数据库进行操作.

                //最后, 什么是修改跟踪?  在Entity 没有SaveChangers的时候, 它处于修改跟踪状态.包含: 查询\修改\删除\添加, 此时数据库无改变.

            }


            // ICollection 一对多的关系
            // SSDL 存储模型--数据库模型
            // CSDL 概念模型--Object\Entity模型
            // C-S Mapping 上述二者的对应关系

        }
    }
}
