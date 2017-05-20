using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.IDAL;
using App.Models;
using System.Data;
using System.Data.Entity;

namespace App.DAL
{
    public class SysSampleRepository: ISysSampleRepository
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>数据列表</returns>
        public IQueryable<SysSample> GetList(DBContainer db)
        {
            IQueryable<SysSample> list = db.SysSample.AsQueryable();
            return list;
        }

        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Create(SysSample entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.Set<SysSample>().Add(entity);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysSample entity = db.SysSample.SingleOrDefault(a => a.Id == id);
                db.Set<SysSample>().Remove(entity);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Edit(SysSample entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.Set<SysSample>().Attach(entity);
                db.Entry<SysSample>(entity).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 获得一个实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        public SysSample GetById(int id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysSample.SingleOrDefault(a => a.Id == id);
            }
        }

        /// <summary>
        /// 判断一个实体是否存在
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>是否存在 true or false</returns>
        public bool IsExist(int id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysSample entity = GetById(id);
                if (entity != null)
                    return true;
                return false;
            }
        }
    }
}
