// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "SortableListPage.json"
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
using System.Linq;
#pragma warning disable 0108
#pragma warning disable 1591

namespace KitchenSink {
using __SSoLastName__ = global::KitchenSink.SortableListPage.SortableListPagePeople.Input.LastName;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __SoHtml__ = global::KitchenSink.SortableListPage.Input.Html;
using __Sortable2__ = global::KitchenSink.SortableListPage.Input;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.SortableListPage.SortableListPagePeople>;
using __Sortable1__ = global::KitchenSink.SortableListPage.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.SortableListPage.SortableListPagePeople>;
using __SSoOrderDow1__ = global::KitchenSink.SortableListPage.SortableListPagePeople.Input.OrderDownButtonDisabled;
using __SSoOrderUpB__ = global::KitchenSink.SortableListPage.SortableListPagePeople.Input.OrderUpButtonDisabled;
using __SSoOrderDow__ = global::KitchenSink.SortableListPage.SortableListPagePeople.Input.OrderDownTrigger;
using __SSoOrderUpT__ = global::KitchenSink.SortableListPage.SortableListPagePeople.Input.OrderUpTrigger;
using __SSoOrderNo__ = global::KitchenSink.SortableListPage.SortableListPagePeople.Input.OrderNo;
using __SSoFullName__ = global::KitchenSink.SortableListPage.SortableListPagePeople.Input.FullName;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __SSoFirstNam__ = global::KitchenSink.SortableListPage.SortableListPagePeople.Input.FirstName;
using __SoSortable2__ = global::KitchenSink.SortableListPage.SortableListPagePeople.Input;
using __SoSortable1__ = global::KitchenSink.SortableListPage.SortableListPagePeople.JsonByExample;
using __TBool__ = global::Starcounter.Templates.TBool;
using __TLong__ = global::Starcounter.Templates.TLong;
using __SSoSchema__ = global::KitchenSink.SortableListPage.SortableListPagePeople.JsonByExample.Schema;
using __SoSortable__ = global::KitchenSink.SortableListPage.SortableListPagePeople;
using __TString__ = global::Starcounter.Templates.TString;
using __SoSchema__ = global::KitchenSink.SortableListPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Sortable__ = global::KitchenSink.SortableListPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class SortableListPage_json : s::TemplateAttribute {
    
    #line hidden
    public class People : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class SortableListPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __SoSchema__ DefaultTemplate = new __SoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SortableListPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SortableListPage(__SoSchema__ template) { Template = template; }
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
                People = Add<__TArray__>("People");
                People.SetCustomGetElementType((arr) => { return __SoSortable__.DefaultTemplate;});
                People.SetCustomAccessors((_p_) => { return ((__Sortable__)_p_).__bf__People__; }, (_p_, _v_) => { ((__Sortable__)_p_).__bf__People__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Sortable__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ People;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "SortableListPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "SortableListPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__People__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ People {
    #line 4 "SortableListPage.json"
        get {
        #line hidden
            return Template.People.Getter(this); }
        #line 4 "SortableListPage.json"
        set {
        #line hidden
            Template.People.Setter(this, value); } }
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
    
    #line hidden
    public partial class SortableListPagePeople : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __SSoSchema__ DefaultTemplate = new __SSoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public SortableListPagePeople() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public SortableListPagePeople(__SSoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __SSoSchema__ Template { get { return (__SSoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__SoSortable__);
                    Properties.ClearExposed();
                    FirstName = Add<__TString__>("FirstName");
                    FirstName.DefaultValue = "";
                    FirstName.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__FirstName__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__FirstName__ = (System.String)_v_; }, false);
                    LastName = Add<__TString__>("LastName");
                    LastName.DefaultValue = "";
                    LastName.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__LastName__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__LastName__ = (System.String)_v_; }, false);
                    FullName = Add<__TString__>("FullName", bind:"FullName");
                    FullName.DefaultValue = "";
                    FullName.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__FullName__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__FullName__ = (System.String)_v_; }, false);
                    OrderNo = Add<__TLong__>("OrderNo$");
                    OrderNo.DefaultValue = 0L;
                    OrderNo.Editable = true;
                    OrderNo.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__OrderNo__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__OrderNo__ = (System.Int64)_v_; }, false);
                    OrderUpTrigger = Add<__TLong__>("OrderUpTrigger$");
                    OrderUpTrigger.DefaultValue = 0L;
                    OrderUpTrigger.Editable = true;
                    OrderUpTrigger.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__OrderUpTrigger__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__OrderUpTrigger__ = (System.Int64)_v_; }, false);
                    OrderUpTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.OrderUpTrigger() { App = (SortableListPagePeople)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((SortableListPagePeople)pup).Handle((Input.OrderUpTrigger)input); });
                    OrderDownTrigger = Add<__TLong__>("OrderDownTrigger$");
                    OrderDownTrigger.DefaultValue = 0L;
                    OrderDownTrigger.Editable = true;
                    OrderDownTrigger.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__OrderDownTrigger__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__OrderDownTrigger__ = (System.Int64)_v_; }, false);
                    OrderDownTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.OrderDownTrigger() { App = (SortableListPagePeople)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((SortableListPagePeople)pup).Handle((Input.OrderDownTrigger)input); });
                    OrderUpButtonDisabled = Add<__TBool__>("OrderUpButtonDisabled$", bind:"OrderUpButtonDisabled");
                    OrderUpButtonDisabled.DefaultValue = false;
                    OrderUpButtonDisabled.Editable = true;
                    OrderUpButtonDisabled.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__OrderUpButtonDisabled__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__OrderUpButtonDisabled__ = (System.Boolean)_v_; }, false);
                    OrderDownButtonDisabled = Add<__TBool__>("OrderDownButtonDisabled$", bind:"OrderDownButtonDisabled");
                    OrderDownButtonDisabled.DefaultValue = false;
                    OrderDownButtonDisabled.Editable = true;
                    OrderDownButtonDisabled.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__OrderDownButtonDisabled__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__OrderDownButtonDisabled__ = (System.Boolean)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __SoSortable__(this) { Parent = parent }; }
                public __TString__ FirstName;
                public __TString__ LastName;
                public __TString__ FullName;
                public __TLong__ OrderNo;
                public __TLong__ OrderUpTrigger;
                public __TLong__ OrderDownTrigger;
                public __TBool__ OrderUpButtonDisabled;
                public __TBool__ OrderDownButtonDisabled;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__FirstName__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String FirstName {
        #line 6 "SortableListPage.json"
            get {
            #line hidden
                return Template.FirstName.Getter(this); }
            #line 6 "SortableListPage.json"
            set {
            #line hidden
                Template.FirstName.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__LastName__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String LastName {
        #line 7 "SortableListPage.json"
            get {
            #line hidden
                return Template.LastName.Getter(this); }
            #line 7 "SortableListPage.json"
            set {
            #line hidden
                Template.LastName.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__FullName__;
        #line default
        #line hidden
        private System.Int64 __bf__OrderNo__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 OrderNo {
        #line 9 "SortableListPage.json"
            get {
            #line hidden
                return Template.OrderNo.Getter(this); }
            #line 9 "SortableListPage.json"
            set {
            #line hidden
                Template.OrderNo.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__OrderUpTrigger__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 OrderUpTrigger {
        #line 10 "SortableListPage.json"
            get {
            #line hidden
                return Template.OrderUpTrigger.Getter(this); }
            #line 10 "SortableListPage.json"
            set {
            #line hidden
                Template.OrderUpTrigger.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__OrderDownTrigger__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 OrderDownTrigger {
        #line 11 "SortableListPage.json"
            get {
            #line hidden
                return Template.OrderDownTrigger.Getter(this); }
            #line 11 "SortableListPage.json"
            set {
            #line hidden
                Template.OrderDownTrigger.Setter(this, value); } }
            #line default
        #line hidden
        private System.Boolean __bf__OrderUpButtonDisabled__;
        #line default
        #line hidden
        private System.Boolean __bf__OrderDownButtonDisabled__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class FirstName : Input<__SoSortable__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class LastName : Input<__SoSortable__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class FullName : Input<__SoSortable__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class OrderNo : Input<__SoSortable__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class OrderUpTrigger : Input<__SoSortable__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class OrderDownTrigger : Input<__SoSortable__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class OrderUpButtonDisabled : Input<__SoSortable__, __TBool__, bool> {
            }
            #line default
            
            #line hidden
            public class OrderDownButtonDisabled : Input<__SoSortable__, __TBool__, bool> {
            }
            #line default
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
