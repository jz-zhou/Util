﻿using Util.Ui.Components;
using Util.Ui.Components.Internal;
using Util.Ui.Configs;
using Util.Ui.Operations;

namespace Util.Ui.Extensions {
    /// <summary>
    /// 表单扩展
    /// </summary>
    public static partial class Extensions {
        /// <summary>
        /// 禁用
        /// </summary>
        /// <typeparam name="TComponent">组件类型</typeparam>
        /// <param name="component">组件实例</param>
        /// <param name="disabled">禁用表达式</param>
        public static TComponent Disable<TComponent>( this TComponent component, string disabled ) where TComponent : IOption, IDisabled {
            var option = component as IOptionConfig;
            option?.Config<Config>( config => {
                config.SetAttribute( UiConst.Disabled, disabled );
            } );
            return component;
        }
    }
}
