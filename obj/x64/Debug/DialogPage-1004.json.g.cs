// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "DialogPage.json"
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
using __DialogPa2__ = global::KitchenSink.DialogPage.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __DiMessageC__ = global::KitchenSink.DialogPage.Input.MessageCss;
using __DiMessage__ = global::KitchenSink.DialogPage.Input.Message;
using __DiConfirmT__ = global::KitchenSink.DialogPage.Input.ConfirmTrigger;
using __DiRejectTr__ = global::KitchenSink.DialogPage.Input.RejectTrigger;
using __DiOpened__ = global::KitchenSink.DialogPage.Input.Opened;
using __DiOpenTrig__ = global::KitchenSink.DialogPage.Input.OpenTrigger;
using __DiHtml__ = global::KitchenSink.DialogPage.Input.Html;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __DialogPa1__ = global::KitchenSink.DialogPage.JsonByExample;
using __TBool__ = global::Starcounter.Templates.TBool;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __DiSchema__ = global::KitchenSink.DialogPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __DialogPa__ = global::KitchenSink.DialogPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class DialogPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class DialogPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __DiSchema__ DefaultTemplate = new __DiSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DialogPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DialogPage(__DiSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __DiSchema__ Template { get { return (__DiSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__DialogPa__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/DialogPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__DialogPa__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__DialogPa__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                OpenTrigger = Add<__TLong__>("OpenTrigger$");
                OpenTrigger.DefaultValue = 0L;
                OpenTrigger.Editable = true;
                OpenTrigger.SetCustomAccessors((_p_) => { return ((__DialogPa__)_p_).__bf__OpenTrigger__; }, (_p_, _v_) => { ((__DialogPa__)_p_).__bf__OpenTrigger__ = (System.Int64)_v_; }, false);
                OpenTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.OpenTrigger() { App = (DialogPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((DialogPage)pup).Handle((Input.OpenTrigger)input); });
                Opened = Add<__TBool__>("Opened");
                Opened.DefaultValue = false;
                Opened.SetCustomAccessors((_p_) => { return ((__DialogPa__)_p_).__bf__Opened__; }, (_p_, _v_) => { ((__DialogPa__)_p_).__bf__Opened__ = (System.Boolean)_v_; }, false);
                RejectTrigger = Add<__TLong__>("RejectTrigger$");
                RejectTrigger.DefaultValue = 0L;
                RejectTrigger.Editable = true;
                RejectTrigger.SetCustomAccessors((_p_) => { return ((__DialogPa__)_p_).__bf__RejectTrigger__; }, (_p_, _v_) => { ((__DialogPa__)_p_).__bf__RejectTrigger__ = (System.Int64)_v_; }, false);
                RejectTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.RejectTrigger() { App = (DialogPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((DialogPage)pup).Handle((Input.RejectTrigger)input); });
                ConfirmTrigger = Add<__TLong__>("ConfirmTrigger$");
                ConfirmTrigger.DefaultValue = 0L;
                ConfirmTrigger.Editable = true;
                ConfirmTrigger.SetCustomAccessors((_p_) => { return ((__DialogPa__)_p_).__bf__ConfirmTrigger__; }, (_p_, _v_) => { ((__DialogPa__)_p_).__bf__ConfirmTrigger__ = (System.Int64)_v_; }, false);
                ConfirmTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.ConfirmTrigger() { App = (DialogPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((DialogPage)pup).Handle((Input.ConfirmTrigger)input); });
                Message = Add<__TString__>("Message");
                Message.DefaultValue = "Opend dialog and select an action";
                Message.SetCustomAccessors((_p_) => { return ((__DialogPa__)_p_).__bf__Message__; }, (_p_, _v_) => { ((__DialogPa__)_p_).__bf__Message__ = (System.String)_v_; }, false);
                MessageCss = Add<__TString__>("MessageCss");
                MessageCss.DefaultValue = "alert alert-info";
                MessageCss.SetCustomAccessors((_p_) => { return ((__DialogPa__)_p_).__bf__MessageCss__; }, (_p_, _v_) => { ((__DialogPa__)_p_).__bf__MessageCss__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __DialogPa__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ OpenTrigger;
            public __TBool__ Opened;
            public __TLong__ RejectTrigger;
            public __TLong__ ConfirmTrigger;
            public __TString__ Message;
            public __TString__ MessageCss;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "DialogPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "DialogPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__OpenTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 OpenTrigger {
    #line 3 "DialogPage.json"
        get {
        #line hidden
            return Template.OpenTrigger.Getter(this); }
        #line 3 "DialogPage.json"
        set {
        #line hidden
            Template.OpenTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__Opened__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean Opened {
    #line 4 "DialogPage.json"
        get {
        #line hidden
            return Template.Opened.Getter(this); }
        #line 4 "DialogPage.json"
        set {
        #line hidden
            Template.Opened.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__RejectTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 RejectTrigger {
    #line 5 "DialogPage.json"
        get {
        #line hidden
            return Template.RejectTrigger.Getter(this); }
        #line 5 "DialogPage.json"
        set {
        #line hidden
            Template.RejectTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__ConfirmTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 ConfirmTrigger {
    #line 6 "DialogPage.json"
        get {
        #line hidden
            return Template.ConfirmTrigger.Getter(this); }
        #line 6 "DialogPage.json"
        set {
        #line hidden
            Template.ConfirmTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Message__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Message {
    #line 7 "DialogPage.json"
        get {
        #line hidden
            return Template.Message.Getter(this); }
        #line 7 "DialogPage.json"
        set {
        #line hidden
            Template.Message.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__MessageCss__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String MessageCss {
    #line 8 "DialogPage.json"
        get {
        #line hidden
            return Template.MessageCss.Getter(this); }
        #line 8 "DialogPage.json"
        set {
        #line hidden
            Template.MessageCss.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__DialogPa__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class OpenTrigger : Input<__DialogPa__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Opened : Input<__DialogPa__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class RejectTrigger : Input<__DialogPa__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class ConfirmTrigger : Input<__DialogPa__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Message : Input<__DialogPa__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class MessageCss : Input<__DialogPa__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
