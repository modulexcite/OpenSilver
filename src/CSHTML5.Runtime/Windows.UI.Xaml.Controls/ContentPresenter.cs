﻿

/*===================================================================================
* 
*   Copyright (c) Userware/OpenSilver.net
*      
*   This file is part of the OpenSilver Runtime (https://opensilver.net), which is
*   licensed under the MIT license: https://opensource.org/licenses/MIT
*   
*   As stated in the MIT license, "the above copyright notice and this permission
*   notice shall be included in all copies or substantial portions of the Software."
*  
\*====================================================================================*/


using System.Windows.Markup;
#if MIGRATION
using System.Windows.Media;
using System.Windows.Media.Animation;
#else

#endif

#if MIGRATION
namespace System.Windows.Controls
#else
namespace Windows.UI.Xaml.Controls
#endif
{
    /// <summary>
    /// Displays the content of a ContentControl.
    /// </summary>
    [ContentProperty("Content")]
    public partial class ContentPresenter : ContentControl
    {
        //--------------------------------------------------
        // In our simple implementation, a ContentPresenter
        // is like a ContentControl but with automatic
        // TemplateBindings defined for the "Content"
        // and "ContentTemplate" properties (those bindings
        // are added at compile-time).
        //--------------------------------------------------
    }
}

