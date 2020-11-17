﻿using CSharpFlink.Core.Calculate;
using CSharpFlink.Core.Model;
using CSharpFlink.Core.Task;

namespace CSharpFlink.Core.Window
{
    public interface IWindowTask : ITask
    {
        ///// <summary>
        ///// 聚合计算方式 
        ///// </summary>
        //AggregateCalculateType AggregateCalculateType { get; set; }

        /// <summary>
        /// 当前最新值
        /// </summary>
        IMetaData Current { get; set; }

        /// <summary>
        /// 延迟窗口个数
        /// </summary>
        int DelayWindowCount { get; set; }

        /// <summary>
        /// 窗口时间周期，秒
        /// </summary>
        int WindowInterval { get; set; }

        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="md"></param>
        void AddMeteData(IMetaData md);
    }
}