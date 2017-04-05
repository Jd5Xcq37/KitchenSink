// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "FlashMessagePage.json"
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
using __FlashMes1__ = global::KitchenSink.FlashMessagePage.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __FlClientMe__ = global::KitchenSink.FlashMessagePage.Input.ClientMessage;
using __FlServerMe__ = global::KitchenSink.FlashMessagePage.Input.ServerMessage;
using __FlShowMess__ = global::KitchenSink.FlashMessagePage.Input.ShowMessageTrigger;
using __FlHtml__ = global::KitchenSink.FlashMessagePage.Input.Html;
using __FlashMes2__ = global::KitchenSink.FlashMessagePage.Input;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __FlSchema__ = global::KitchenSink.FlashMessagePage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __FlashMes__ = global::KitchenSink.FlashMessagePage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FlashMessagePage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class FlashMessagePage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FlSchema__ DefaultTemplate = new __FlSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FlashMessagePage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FlashMessagePage(__FlSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FlSchema__ Template { get { return (__FlSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__FlashMes__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/FlashMessagePage.html";
                Html.SetCustomAccessors((_p_) => { return ((__FlashMes__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__FlashMes__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                ShowMessageTrigger = Add<__TLong__>("ShowMessageTrigger$");
                ShowMessageTrigger.DefaultValue = 0L;
                ShowMessageTrigger.Editable = true;
                ShowMessageTrigger.SetCustomAccessors((_p_) => { return ((__FlashMes__)_p_).__bf__ShowMessageTrigger__; }, (_p_, _v_) => { ((__FlashMes__)_p_).__bf__ShowMessageTrigger__ = (System.Int64)_v_; }, false);
                ShowMessageTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.ShowMessageTrigger() { App = (FlashMessagePage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FlashMessagePage)pup).Handle((Input.ShowMessageTrigger)input); });
                ServerMessage = Add<__TString__>("ServerMessage");
                ServerMessage.DefaultValue = "";
                ServerMessage.SetCustomAccessors((_p_) => { return ((__FlashMes__)_p_).__bf__ServerMessage__; }, (_p_, _v_) => { ((__FlashMes__)_p_).__bf__ServerMessage__ = (System.String)_v_; }, false);
                ClientMessage = Add<__TString__>("ClientMessage$");
                ClientMessage.DefaultValue = "";
                ClientMessage.Editable = true;
                ClientMessage.SetCustomAccessors((_p_) => { return ((__FlashMes__)_p_).__bf__ClientMessage__; }, (_p_, _v_) => { ((__FlashMes__)_p_).__bf__ClientMessage__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __FlashMes__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ ShowMessageTrigger;
            public __TString__ ServerMessage;
            public __TString__ ClientMessage;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "FlashMessagePage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "FlashMessagePage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__ShowMessageTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 ShowMessageTrigger {
    #line 3 "FlashMessagePage.json"
        get {
        #line hidden
            return Template.ShowMessageTrigger.Getter(this); }
        #line 3 "FlashMessagePage.json"
        set {
        #line hidden
            Template.ShowMessageTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ServerMessage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ServerMessage {
    #line 4 "FlashMessagePage.json"
        get {
        #line hidden
            return Template.ServerMessage.Getter(this); }
        #line 4 "FlashMessagePage.json"
        set {
        #line hidden
            Template.ServerMessage.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ClientMessage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ClientMessage {
    #line 5 "FlashMessagePage.json"
        get {
        #line hidden
            return Template.ClientMessage.Getter(this); }
        #line 5 "FlashMessagePage.json"
        set {
        #line hidden
            Template.ClientMessage.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__FlashMes__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ShowMessageTrigger : Input<__FlashMes__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class ServerMessage : Input<__FlashMes__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ClientMessage : Input<__FlashMes__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
