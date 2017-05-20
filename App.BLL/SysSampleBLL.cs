using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.Models;
using App.DAL;
using App.IDAL;
using System.Data;

namespace App.BLL
{
    public class SysSampleBLL
    {
        DBContainer db = new DBContainer();

        ISysSampleRepository Rep = new SysSampleRepository();

        /// <summary>
        /// 获得列表
        /// </summary>
        /// <returns>列表</returns>
        public List<SysSample> GetList()
        {
            IQueryable<SysSample> queryData = Rep.GetList(db);
            return queryData.ToList();
        }

        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity">实体模型</param>
        /// <returns>是否成功</returns>
        public bool Create(SysSample entity)
        {
            try
            {
                if (Rep.Create(entity) == 1)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>是否成功</returns>
        public bool Delete(int id)
        {
            try
            {
                if (Rep.Delete(id) == 1)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 修复一个实体
        /// </summary>
        /// <param name="entity">实体模型</param>
        /// <returns>是否成功</returns>
        public bool Edit(SysSample entity)
        {
            try
            {
                if (Rep.Edit(entity) == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        /// <summary>
        /// 判断是否存在实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>是否存在</returns>
        public bool IsExists(int id)
        {
            if (db.SysSample.SingleOrDefault(a => a.Id == id) != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 根据ID获得一个实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>实体</returns>
        public SysSample GetById(int id)
        {
            if (IsExist(id))
            {
                SysSample entity = Rep.GetById(id);
                return entity;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 判断一个实体是否存在
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是否存在 true or false</returns>
        public bool IsExist(int id)
        {
            return Rep.IsExist(id);
        }
    }
}
