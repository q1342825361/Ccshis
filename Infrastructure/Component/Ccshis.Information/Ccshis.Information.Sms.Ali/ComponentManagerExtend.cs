﻿using ECommon.Configurations;

namespace Ccshis.Information.Sms.Ali
{
    /// <summary>
    /// 注册使用阿里云短信
    /// </summary>
    /// <remarks>
    /// author:catdemon
    /// data:2019-05-15
    /// opt:create
    /// </remarks> 
    /// <example>
    /// componentManager.UseAliSms(aliSmsSetting);
    /// </example>
    public static class ComponentManagerExtend
    {
        /// <summary>
        /// 注册使用阿里云短信组件
        /// </summary>
        /// <param name="IComponentManager">IComponentManager</param>
        /// <param name="aliSmsSetting">阿里云配置<see cref="Ccshis.Information.Sms.Ali.AliSmsSetting"/></param>
        /// <returns></returns>
        public static IComponentManager UseAliSms(this IComponentManager componentManager, AliSmsSetting aliSmsSetting)
        {
            componentManager.RegisterAssembly(typeof(ComponentManagerExtend).Assembly);
            return componentManager;
        }
    }
}
