using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Iecg.Bletools.RNReactNativeIecgBletools
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeIecgBletoolsModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeIecgBletoolsModule"/>.
        /// </summary>
        internal RNReactNativeIecgBletoolsModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeIecgBletools";
            }
        }
    }
}
