﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.18020.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class LEVEL
{

    private LEVELROZMERY rOZMERYField;

    private LEVELSPAWN sPAWNField;

    private LEVELOBJEKTY oBJEKTYField;

    /// <remarks/>
    public LEVELROZMERY ROZMERY
    {
        get
        {
            return this.rOZMERYField;
        }
        set
        {
            this.rOZMERYField = value;
        }
    }

    /// <remarks/>
    public LEVELSPAWN SPAWN
    {
        get
        {
            return this.sPAWNField;
        }
        set
        {
            this.sPAWNField = value;
        }
    }

    /// <remarks/>
    public LEVELOBJEKTY OBJEKTY
    {
        get
        {
            return this.oBJEKTYField;
        }
        set
        {
            this.oBJEKTYField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELROZMERY
{

    private int sIRKAField;

    private int vYSKAField;

    /// <remarks/>
    public int SIRKA
    {
        get
        {
            return this.sIRKAField;
        }
        set
        {
            this.sIRKAField = value;
        }
    }

    /// <remarks/>
    public int VYSKA
    {
        get
        {
            return this.vYSKAField;
        }
        set
        {
            this.vYSKAField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELSPAWN
{

    private int xField;
    private int xField2;

    private int yField;
    private int yField2;

    /// <remarks/>
    public int X1
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }
    public int X2
    {
        get
        {
            return this.xField2;
        }
        set
        {
            this.xField2 = value;
        }
    }

    /// <remarks/>
    public int Y1
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }
    public int Y2
    {
        get
        {
            return this.yField2;
        }
        set
        {
            this.yField2 = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTY
{

    private LEVELOBJEKTYBALVAN[] bALVANField;

    private LEVELOBJEKTYREBRIK[] rEBRIKField;

    private LEVELOBJEKTYSTENA[] sTENAField;

    private LEVELOBJEKTYSTENY[] sTENYField;

    private LEVELOBJEKTYVYCHOD[] vYCHODField;

    private LEVELOBJEKTYPICHLIACE[] pICHLIACEField;

    private LEVELOBJEKTYPREPINAC[] pREPINACField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BALVAN")]
    public LEVELOBJEKTYBALVAN[] BALVAN
    {
        get
        {
            return this.bALVANField;
        }
        set
        {
            this.bALVANField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("REBRIK")]
    public LEVELOBJEKTYREBRIK[] REBRIK
    {
        get
        {
            return this.rEBRIKField;
        }
        set
        {
            this.rEBRIKField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("STENA")]
    public LEVELOBJEKTYSTENA[] STENA
    {
        get
        {
            return this.sTENAField;
        }
        set
        {
            this.sTENAField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("STENY")]
    public LEVELOBJEKTYSTENY[] STENY
    {
        get
        {
            return this.sTENYField;
        }
        set
        {
            this.sTENYField = value;
        }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("VYCHOD")]
    public LEVELOBJEKTYVYCHOD[] VYCHOD
    {
        get
        {
            return this.vYCHODField;
        }
        set
        {
            this.vYCHODField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PICHLIACE")]
    public LEVELOBJEKTYPICHLIACE[] PICHLIACE
    {
        get
        {
            return this.pICHLIACEField;
        }
        set
        {
            this.pICHLIACEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PREPINAC")]
    public LEVELOBJEKTYPREPINAC[] PREPINAC
    {
        get
        {
            return this.pREPINACField;
        }
        set
        {
            this.pREPINACField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYBALVAN
{

    private LEVELOBJEKTYBALVANSURADNICE sURADNICEField;

    private bool sOLIDField;

    private int wEIGHTField;

    /// <remarks/>
    public LEVELOBJEKTYBALVANSURADNICE SURADNICE
    {
        get
        {
            return this.sURADNICEField;
        }
        set
        {
            this.sURADNICEField = value;
        }
    }

    /// <remarks/>
    public bool SOLID
    {
        get
        {
            return this.sOLIDField;
        }
        set
        {
            this.sOLIDField = value;
        }
    }

    /// <remarks/>
    public int WEIGHT
    {
        get
        {
            return this.wEIGHTField;
        }
        set
        {
            this.wEIGHTField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYBALVANSURADNICE
{

    private int xField;

    private int yField;

    /// <remarks/>
    public int X
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    public int Y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYREBRIK
{

    private LEVELOBJEKTYREBRIKSURADNICE sURADNICEField;

    private LEVELOBJEKTYREBRIKVELKOST vELKOSTField;

    private bool sOLIDField;

    private int wEIGHTField;

    /// <remarks/>
    public LEVELOBJEKTYREBRIKSURADNICE SURADNICE
    {
        get
        {
            return this.sURADNICEField;
        }
        set
        {
            this.sURADNICEField = value;
        }
    }

    /// <remarks/>

    public LEVELOBJEKTYREBRIKVELKOST VELKOST
    {
        get
        {
            return this.vELKOSTField;
        }
        set
        {
            this.vELKOSTField = value;
        }
    }

    /// <remarks/>
    public bool SOLID
    {
        get
        {
            return this.sOLIDField;
        }
        set
        {
            this.sOLIDField = value;
        }
    }

    /// <remarks/>
    public int WEIGHT
    {
        get
        {
            return this.wEIGHTField;
        }
        set
        {
            this.wEIGHTField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYSTENY
{

    private LEVELOBJEKTYSTENYSURADNICE sURADNICEField;

    private LEVELOBJEKTYSTENYVELKOST vELKOSTField;

    private bool sOLIDField;

    private int wEIGHTField;

    /// <remarks/>
    public LEVELOBJEKTYSTENYSURADNICE SURADNICE
    {
        get
        {
            return this.sURADNICEField;
        }
        set
        {
            this.sURADNICEField = value;
        }
    }

    /// <remarks/>

    public LEVELOBJEKTYSTENYVELKOST VELKOST
    {
        get
        {
            return this.vELKOSTField;
        }
        set
        {
            this.vELKOSTField = value;
        }
    }

    /// <remarks/>
    public bool SOLID
    {
        get
        {
            return this.sOLIDField;
        }
        set
        {
            this.sOLIDField = value;
        }
    }

    /// <remarks/>
    public int WEIGHT
    {
        get
        {
            return this.wEIGHTField;
        }
        set
        {
            this.wEIGHTField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYSTENYSURADNICE
{

    private int xField;

    private int yField;

    /// <remarks/>
    public int X
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    public int Y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYSTENYVELKOST
{

    private int vYSKAField;

    private int sIRKAField;

    /// <remarks/>
    public int VYSKA
    {
        get
        {
            return this.vYSKAField;
        }
        set
        {
            this.vYSKAField = value;
        }
    }
    public int SIRKA
    {
        get
        {
            return this.sIRKAField;
        }
        set
        {
            this.sIRKAField = value;
        }
    }
}
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYREBRIKSURADNICE
{

    private int xField;

    private int yField;

    /// <remarks/>
    public int X
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    public int Y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYREBRIKVELKOST
{

    private int vYSKAField;

    /// <remarks/>
    public int VYSKA
    {
        get
        {
            return this.vYSKAField;
        }
        set
        {
            this.vYSKAField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYSTENA
{

    private LEVELOBJEKTYSTENASURADNICE sURADNICEField;

    private bool sOLIDField;

    private int wEIGHTField;

    /// <remarks/>
    public LEVELOBJEKTYSTENASURADNICE SURADNICE
    {
        get
        {
            return this.sURADNICEField;
        }
        set
        {
            this.sURADNICEField = value;
        }
    }

    /// <remarks/>
    public bool SOLID
    {
        get
        {
            return this.sOLIDField;
        }
        set
        {
            this.sOLIDField = value;
        }
    }

    /// <remarks/>
    public int WEIGHT
    {
        get
        {
            return this.wEIGHTField;
        }
        set
        {
            this.wEIGHTField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYSTENASURADNICE
{

    private int xField;

    private int yField;

    /// <remarks/>
    public int X
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    public int Y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYVYCHOD
{

    private LEVELOBJEKTYVYCHODSURADNICE sURADNICEField;

    private bool sOLIDField;

    private int wEIGHTField;

    /// <remarks/>
    public LEVELOBJEKTYVYCHODSURADNICE SURADNICE
    {
        get
        {
            return this.sURADNICEField;
        }
        set
        {
            this.sURADNICEField = value;
        }
    }

    /// <remarks/>
    public bool SOLID
    {
        get
        {
            return this.sOLIDField;
        }
        set
        {
            this.sOLIDField = value;
        }
    }

    /// <remarks/>
    public int WEIGHT
    {
        get
        {
            return this.wEIGHTField;
        }
        set
        {
            this.wEIGHTField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYVYCHODSURADNICE
{

    private int xField;

    private int yField;

    /// <remarks/>
    public int X
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    public int Y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYPICHLIACE
{

    private LEVELOBJEKTYPICHLIACESURADNICE sURADNICEField;

    private bool sOLIDField;

    private int wEIGHTField;

    /// <remarks/>
    public LEVELOBJEKTYPICHLIACESURADNICE SURADNICE
    {
        get
        {
            return this.sURADNICEField;
        }
        set
        {
            this.sURADNICEField = value;
        }
    }

    /// <remarks/>
    public bool SOLID
    {
        get
        {
            return this.sOLIDField;
        }
        set
        {
            this.sOLIDField = value;
        }
    }

    /// <remarks/>
    public int WEIGHT
    {
        get
        {
            return this.wEIGHTField;
        }
        set
        {
            this.wEIGHTField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYPICHLIACESURADNICE
{

    private int xField;

    private int yField;

    /// <remarks/>
    public int X
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    public int Y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYPREPINAC
{

    private LEVELOBJEKTYPREPINACSURADNICE sURADNICEField;

    private bool sOLIDField;

    private LEVELOBJEKTYPREPINACOVLADA oVLADAField;

    private int wEIGHTField;

    /// <remarks/>
    public LEVELOBJEKTYPREPINACSURADNICE SURADNICE
    {
        get
        {
            return this.sURADNICEField;
        }
        set
        {
            this.sURADNICEField = value;
        }
    }

    /// <remarks/>
    public LEVELOBJEKTYPREPINACOVLADA OVLADA
    {
        get
        {
            return this.oVLADAField;
        }
        set
        {
            this.oVLADAField = value;
        }
    }
    /// <remarks/>
    public bool SOLID
    {
        get
        {
            return this.sOLIDField;
        }
        set
        {
            this.sOLIDField = value;
        }
    }

    /// <remarks/>
    public int WEIGHT
    {
        get
        {
            return this.wEIGHTField;
        }
        set
        {
            this.wEIGHTField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYPREPINACSURADNICE
{

    private int xField;

    private int yField;

    /// <remarks/>
    public int X
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    public int Y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class LEVELOBJEKTYPREPINACOVLADA
{

    private int xJEDNAField;

    private int yJEDNAField;

    private int xDVAField;

    private int yDVAField;

    /// <remarks/>
    public int XJEDNA
    {
        get
        {
            return this.xJEDNAField;
        }
        set
        {
            this.xJEDNAField = value;
        }
    }

    /// <remarks/>
    public int YJEDNA
    {
        get
        {
            return this.yJEDNAField;
        }
        set
        {
            this.yJEDNAField = value;
        }
    }
    public int XDVA
    {
        get
        {
            return this.xDVAField;
        }
        set
        {
            this.xDVAField = value;
        }
    }

    /// <remarks/>
    public int YDVA
    {
        get
        {
            return this.yDVAField;
        }
        set
        {
            this.yDVAField = value;
        }
    }
}
