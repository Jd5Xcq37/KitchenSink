// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "SortableList.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
#pragma warning disable 0108
#pragma warning disable 1591

namespace KitchenSink {
using __Sortable__ = global::KitchenSink.SortableList;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __SoSchema__ = global::KitchenSink.SortableList.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __Sortable1__ = global::KitchenSink.SortableList.JsonByExample;
using __Sortable2__ = global::KitchenSink.SortableList.Input;
using __SoHtml__ = global::KitchenSink.SortableList.Input.Html;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;

#line hidden
public partial class SortableList : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __SoSchema__ DefaultTemplate = new __SoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SortableList() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SortableList(__SoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __SoSchema__ Template { get { return (__SoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Sortable__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/SortableListPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Sortable__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Sortable__)_p_).__bf__Html__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Sortable__(this) { Parent = parent }; }
            public __TString__ Html;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "SortableList.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "SortableList.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Sortable__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class SortableList_json : s::TemplateAttribute {
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
