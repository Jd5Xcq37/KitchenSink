// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "CallbackPage.json"
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
using __CCaErrorMes__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input.ErrorMessage;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.CallbackPage.CallbackPageItem>;
using __Callback1__ = global::KitchenSink.CallbackPage.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.CallbackPage.CallbackPageItem>;
using __Callback2__ = global::KitchenSink.CallbackPage.Input;
using __CaHtml__ = global::KitchenSink.CallbackPage.Input.Html;
using __CaSaveTrig__ = global::KitchenSink.CallbackPage.Input.SaveTrigger;
using __CCaSaveAndC__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input.SaveAndClientMessageTrigger;
using __CaSaveAndS__ = global::KitchenSink.CallbackPage.Input.SaveAndSpinTrigger;
using __CaSuccessM__ = global::KitchenSink.CallbackPage.Input.SuccessMessage;
using __CaErrorMes__ = global::KitchenSink.CallbackPage.Input.ErrorMessage;
using __CaSaveAndC__ = global::KitchenSink.CallbackPage.Input.SaveAndClientMessageTrigger;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __CaSaveAndM__ = global::KitchenSink.CallbackPage.Input.SaveAndMessageTrigger;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __CCaSaveAndM__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input.SaveAndMessageTrigger;
using __Callback__ = global::KitchenSink.CallbackPage;
using __CaSchema__ = global::KitchenSink.CallbackPage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __CaCallback__ = global::KitchenSink.CallbackPage.CallbackPageItem;
using __CCaSuccessM__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input.SuccessMessage;
using __Json__ = global::Starcounter.Json;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __CCaSchema__ = global::KitchenSink.CallbackPage.CallbackPageItem.JsonByExample.Schema;
using __CaCallback1__ = global::KitchenSink.CallbackPage.CallbackPageItem.JsonByExample;
using __CaCallback2__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input;
using __CCaSaveTrig__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input.SaveTrigger;
using __CCaSaveAndS__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input.SaveAndSpinTrigger;
using __TObject__ = global::Starcounter.Templates.TObject;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CallbackPage_json : s::TemplateAttribute {
    
    #line hidden
    public class Items : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class CallbackPage : Page {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CaSchema__ DefaultTemplate = new __CaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CallbackPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CallbackPage(__CaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CaSchema__ Template { get { return (__CaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : Page.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__Callback__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/CallbackPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                SaveTrigger = Add<__TLong__>("SaveTrigger$");
                SaveTrigger.DefaultValue = 0L;
                SaveTrigger.Editable = true;
                SaveTrigger.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__SaveTrigger__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__SaveTrigger__ = (System.Int64)_v_; }, false);
                SaveTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveTrigger() { App = (CallbackPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPage)pup).Handle((Input.SaveTrigger)input); });
                SaveAndSpinTrigger = Add<__TLong__>("SaveAndSpinTrigger$");
                SaveAndSpinTrigger.DefaultValue = 0L;
                SaveAndSpinTrigger.Editable = true;
                SaveAndSpinTrigger.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__SaveAndSpinTrigger__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__SaveAndSpinTrigger__ = (System.Int64)_v_; }, false);
                SaveAndSpinTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveAndSpinTrigger() { App = (CallbackPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPage)pup).Handle((Input.SaveAndSpinTrigger)input); });
                SaveAndMessageTrigger = Add<__TLong__>("SaveAndMessageTrigger$");
                SaveAndMessageTrigger.DefaultValue = 0L;
                SaveAndMessageTrigger.Editable = true;
                SaveAndMessageTrigger.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__SaveAndMessageTrigger__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__SaveAndMessageTrigger__ = (System.Int64)_v_; }, false);
                SaveAndMessageTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveAndMessageTrigger() { App = (CallbackPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPage)pup).Handle((Input.SaveAndMessageTrigger)input); });
                SuccessMessage = Add<__TString__>("SuccessMessage$");
                SuccessMessage.DefaultValue = "";
                SuccessMessage.Editable = true;
                SuccessMessage.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__SuccessMessage__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__SuccessMessage__ = (System.String)_v_; }, false);
                ErrorMessage = Add<__TString__>("ErrorMessage$");
                ErrorMessage.DefaultValue = "";
                ErrorMessage.Editable = true;
                ErrorMessage.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__ErrorMessage__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__ErrorMessage__ = (System.String)_v_; }, false);
                SaveAndClientMessageTrigger = Add<__TLong__>("SaveAndClientMessageTrigger$");
                SaveAndClientMessageTrigger.DefaultValue = 0L;
                SaveAndClientMessageTrigger.Editable = true;
                SaveAndClientMessageTrigger.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__SaveAndClientMessageTrigger__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__SaveAndClientMessageTrigger__ = (System.Int64)_v_; }, false);
                SaveAndClientMessageTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveAndClientMessageTrigger() { App = (CallbackPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPage)pup).Handle((Input.SaveAndClientMessageTrigger)input); });
                Items = Add<__TArray__>("Items");
                Items.SetCustomGetElementType((arr) => { return __CaCallback__.DefaultTemplate;});
                Items.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__Items__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__Items__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Callback__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ SaveTrigger;
            public __TLong__ SaveAndSpinTrigger;
            public __TLong__ SaveAndMessageTrigger;
            public __TString__ SuccessMessage;
            public __TString__ ErrorMessage;
            public __TLong__ SaveAndClientMessageTrigger;
            public __TArray__ Items;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "CallbackPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "CallbackPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveTrigger {
    #line 3 "CallbackPage.json"
        get {
        #line hidden
            return Template.SaveTrigger.Getter(this); }
        #line 3 "CallbackPage.json"
        set {
        #line hidden
            Template.SaveTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveAndSpinTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveAndSpinTrigger {
    #line 4 "CallbackPage.json"
        get {
        #line hidden
            return Template.SaveAndSpinTrigger.Getter(this); }
        #line 4 "CallbackPage.json"
        set {
        #line hidden
            Template.SaveAndSpinTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveAndMessageTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveAndMessageTrigger {
    #line 5 "CallbackPage.json"
        get {
        #line hidden
            return Template.SaveAndMessageTrigger.Getter(this); }
        #line 5 "CallbackPage.json"
        set {
        #line hidden
            Template.SaveAndMessageTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__SuccessMessage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SuccessMessage {
    #line 6 "CallbackPage.json"
        get {
        #line hidden
            return Template.SuccessMessage.Getter(this); }
        #line 6 "CallbackPage.json"
        set {
        #line hidden
            Template.SuccessMessage.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ErrorMessage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ErrorMessage {
    #line 7 "CallbackPage.json"
        get {
        #line hidden
            return Template.ErrorMessage.Getter(this); }
        #line 7 "CallbackPage.json"
        set {
        #line hidden
            Template.ErrorMessage.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveAndClientMessageTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveAndClientMessageTrigger {
    #line 8 "CallbackPage.json"
        get {
        #line hidden
            return Template.SaveAndClientMessageTrigger.Getter(this); }
        #line 8 "CallbackPage.json"
        set {
        #line hidden
            Template.SaveAndClientMessageTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Items__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Items {
    #line 9 "CallbackPage.json"
        get {
        #line hidden
            return Template.Items.Getter(this); }
        #line 9 "CallbackPage.json"
        set {
        #line hidden
            Template.Items.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Callback__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveTrigger : Input<__Callback__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SaveAndSpinTrigger : Input<__Callback__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SaveAndMessageTrigger : Input<__Callback__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SuccessMessage : Input<__Callback__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ErrorMessage : Input<__Callback__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveAndClientMessageTrigger : Input<__Callback__, __TLong__, long> {
        }
        #line default
    }
    #line default
    
    #line hidden
    public partial class CallbackPageItem : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CCaSchema__ DefaultTemplate = new __CCaSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CallbackPageItem() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CallbackPageItem(__CCaSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CCaSchema__ Template { get { return (__CCaSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CaCallback__);
                    Properties.ClearExposed();
                    SaveTrigger = Add<__TLong__>("SaveTrigger$");
                    SaveTrigger.DefaultValue = 0L;
                    SaveTrigger.Editable = true;
                    SaveTrigger.SetCustomAccessors((_p_) => { return ((__CaCallback__)_p_).__bf__SaveTrigger__; }, (_p_, _v_) => { ((__CaCallback__)_p_).__bf__SaveTrigger__ = (System.Int64)_v_; }, false);
                    SaveTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveTrigger() { App = (CallbackPageItem)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPageItem)pup).Handle((Input.SaveTrigger)input); });
                    SaveAndSpinTrigger = Add<__TLong__>("SaveAndSpinTrigger$");
                    SaveAndSpinTrigger.DefaultValue = 0L;
                    SaveAndSpinTrigger.Editable = true;
                    SaveAndSpinTrigger.SetCustomAccessors((_p_) => { return ((__CaCallback__)_p_).__bf__SaveAndSpinTrigger__; }, (_p_, _v_) => { ((__CaCallback__)_p_).__bf__SaveAndSpinTrigger__ = (System.Int64)_v_; }, false);
                    SaveAndSpinTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveAndSpinTrigger() { App = (CallbackPageItem)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPageItem)pup).Handle((Input.SaveAndSpinTrigger)input); });
                    SaveAndMessageTrigger = Add<__TLong__>("SaveAndMessageTrigger$");
                    SaveAndMessageTrigger.DefaultValue = 0L;
                    SaveAndMessageTrigger.Editable = true;
                    SaveAndMessageTrigger.SetCustomAccessors((_p_) => { return ((__CaCallback__)_p_).__bf__SaveAndMessageTrigger__; }, (_p_, _v_) => { ((__CaCallback__)_p_).__bf__SaveAndMessageTrigger__ = (System.Int64)_v_; }, false);
                    SaveAndMessageTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveAndMessageTrigger() { App = (CallbackPageItem)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPageItem)pup).Handle((Input.SaveAndMessageTrigger)input); });
                    SuccessMessage = Add<__TString__>("SuccessMessage$");
                    SuccessMessage.DefaultValue = "";
                    SuccessMessage.Editable = true;
                    SuccessMessage.SetCustomAccessors((_p_) => { return ((__CaCallback__)_p_).__bf__SuccessMessage__; }, (_p_, _v_) => { ((__CaCallback__)_p_).__bf__SuccessMessage__ = (System.String)_v_; }, false);
                    ErrorMessage = Add<__TString__>("ErrorMessage$");
                    ErrorMessage.DefaultValue = "";
                    ErrorMessage.Editable = true;
                    ErrorMessage.SetCustomAccessors((_p_) => { return ((__CaCallback__)_p_).__bf__ErrorMessage__; }, (_p_, _v_) => { ((__CaCallback__)_p_).__bf__ErrorMessage__ = (System.String)_v_; }, false);
                    SaveAndClientMessageTrigger = Add<__TLong__>("SaveAndClientMessageTrigger$");
                    SaveAndClientMessageTrigger.DefaultValue = 0L;
                    SaveAndClientMessageTrigger.Editable = true;
                    SaveAndClientMessageTrigger.SetCustomAccessors((_p_) => { return ((__CaCallback__)_p_).__bf__SaveAndClientMessageTrigger__; }, (_p_, _v_) => { ((__CaCallback__)_p_).__bf__SaveAndClientMessageTrigger__ = (System.Int64)_v_; }, false);
                    SaveAndClientMessageTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveAndClientMessageTrigger() { App = (CallbackPageItem)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPageItem)pup).Handle((Input.SaveAndClientMessageTrigger)input); });
                }
                public override object CreateInstance(s.Json parent) { return new __CaCallback__(this) { Parent = parent }; }
                public __TLong__ SaveTrigger;
                public __TLong__ SaveAndSpinTrigger;
                public __TLong__ SaveAndMessageTrigger;
                public __TString__ SuccessMessage;
                public __TString__ ErrorMessage;
                public __TLong__ SaveAndClientMessageTrigger;
            }
            #line default
        }
        #line default
        #line hidden
        private System.Int64 __bf__SaveTrigger__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SaveTrigger {
        #line 11 "CallbackPage.json"
            get {
            #line hidden
                return Template.SaveTrigger.Getter(this); }
            #line 11 "CallbackPage.json"
            set {
            #line hidden
                Template.SaveTrigger.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__SaveAndSpinTrigger__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SaveAndSpinTrigger {
        #line 12 "CallbackPage.json"
            get {
            #line hidden
                return Template.SaveAndSpinTrigger.Getter(this); }
            #line 12 "CallbackPage.json"
            set {
            #line hidden
                Template.SaveAndSpinTrigger.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__SaveAndMessageTrigger__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SaveAndMessageTrigger {
        #line 13 "CallbackPage.json"
            get {
            #line hidden
                return Template.SaveAndMessageTrigger.Getter(this); }
            #line 13 "CallbackPage.json"
            set {
            #line hidden
                Template.SaveAndMessageTrigger.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__SuccessMessage__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String SuccessMessage {
        #line 14 "CallbackPage.json"
            get {
            #line hidden
                return Template.SuccessMessage.Getter(this); }
            #line 14 "CallbackPage.json"
            set {
            #line hidden
                Template.SuccessMessage.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__ErrorMessage__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ErrorMessage {
        #line 15 "CallbackPage.json"
            get {
            #line hidden
                return Template.ErrorMessage.Getter(this); }
            #line 15 "CallbackPage.json"
            set {
            #line hidden
                Template.ErrorMessage.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__SaveAndClientMessageTrigger__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SaveAndClientMessageTrigger {
        #line 16 "CallbackPage.json"
            get {
            #line hidden
                return Template.SaveAndClientMessageTrigger.Getter(this); }
            #line 16 "CallbackPage.json"
            set {
            #line hidden
                Template.SaveAndClientMessageTrigger.Setter(this, value); } }
            #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class SaveTrigger : Input<__CaCallback__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SaveAndSpinTrigger : Input<__CaCallback__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SaveAndMessageTrigger : Input<__CaCallback__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SuccessMessage : Input<__CaCallback__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class ErrorMessage : Input<__CaCallback__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class SaveAndClientMessageTrigger : Input<__CaCallback__, __TLong__, long> {
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
