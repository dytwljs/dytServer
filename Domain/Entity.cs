using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace dytServer.Domain
{
    /// <summary>
    /// 泛型实体基类
    /// </summary>
    /// <typeparam name="TPrimaryKey">主键类型</typeparam>
    public abstract class Entity<TPrimaryKey>
    {
        
        /// <summary>
        /// 主键
        /// </summary> 
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual TPrimaryKey Id { get; set; }
    }

    /// <summary>
    /// 定义默认主键类型为int的实体基类
    /// </summary>
    public abstract class Entity : Entity<int>
    {

    }
    //TIdentity
    public abstract class EntityIdentity<TIdentity>{
        
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual TIdentity Id { get; set; }
    }

    public abstract class EntityIdentity:EntityIdentity<int>
    {
    }
    ///// <summary>
    ///// 定义默认主键类型为Guid的实体基类
    ///// </summary>
    //public abstract class Entity : Entity<Guid>
    //{

    //}
}
