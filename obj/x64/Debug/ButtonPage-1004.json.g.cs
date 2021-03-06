// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ButtonPage.json"
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
using System.Threading;
#pragma warning disable 0108
#pragma warning disable 1591

namespace KitchenSink {
using __BuHtml__ = global::KitchenSink.ButtonPage.Input.Html;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __BuOneCarro__ = global::KitchenSink.ButtonPage.Input.OneCarrotReaction;
using __BuCarrotEn__ = global::KitchenSink.ButtonPage.Input.CarrotEngineReaction;
using __BuCarrotsR__ = global::KitchenSink.ButtonPage.Input.CarrotsReaction;
using __BuTakeOneR__ = global::KitchenSink.ButtonPage.Input.TakeOneRegeneratingCarrotTrigger;
using __BuAddOneCa1__ = global::KitchenSink.ButtonPage.Input.AddOneCarrotDisabled;
using __BuAddOneCa__ = global::KitchenSink.ButtonPage.Input.AddOneCarrotTrigger;
using __BuEnableCa__ = global::KitchenSink.ButtonPage.Input.EnableCarrotEngine;
using __BuAddCarro__ = global::KitchenSink.ButtonPage.Input.AddCarrotsTrigger;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __ButtonPa2__ = global::KitchenSink.ButtonPage.Input;
using __ButtonPa1__ = global::KitchenSink.ButtonPage.JsonByExample;
using __TBool__ = global::Starcounter.Templates.TBool;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __BuSchema__ = global::KitchenSink.ButtonPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __ButtonPa__ = global::KitchenSink.ButtonPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ButtonPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class ButtonPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __BuSchema__ DefaultTemplate = new __BuSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ButtonPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ButtonPage(__BuSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __BuSchema__ Template { get { return (__BuSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ButtonPa__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/ButtonPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__ButtonPa__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__ButtonPa__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                AddCarrotsTrigger = Add<__TLong__>("AddCarrotsTrigger$");
                AddCarrotsTrigger.DefaultValue = 0L;
                AddCarrotsTrigger.Editable = true;
                AddCarrotsTrigger.SetCustomAccessors((_p_) => { return ((__ButtonPa__)_p_).__bf__AddCarrotsTrigger__; }, (_p_, _v_) => { ((__ButtonPa__)_p_).__bf__AddCarrotsTrigger__ = (System.Int64)_v_; }, false);
                AddCarrotsTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddCarrotsTrigger() { App = (ButtonPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((ButtonPage)pup).Handle((Input.AddCarrotsTrigger)input); });
                EnableCarrotEngine = Add<__TBool__>("EnableCarrotEngine$");
                EnableCarrotEngine.DefaultValue = false;
                EnableCarrotEngine.Editable = true;
                EnableCarrotEngine.SetCustomAccessors((_p_) => { return ((__ButtonPa__)_p_).__bf__EnableCarrotEngine__; }, (_p_, _v_) => { ((__ButtonPa__)_p_).__bf__EnableCarrotEngine__ = (System.Boolean)_v_; }, false);
                EnableCarrotEngine.AddHandler((Json pup, Property<Boolean> prop, Boolean value) => { return (new Input.EnableCarrotEngine() { App = (ButtonPage)pup, Template = (TBool)prop, Value = value }); }, (Json pup, Starcounter.Input<Boolean> input) => { ((ButtonPage)pup).Handle((Input.EnableCarrotEngine)input); });
                AddOneCarrotTrigger = Add<__TLong__>("AddOneCarrotTrigger$");
                AddOneCarrotTrigger.DefaultValue = 0L;
                AddOneCarrotTrigger.Editable = true;
                AddOneCarrotTrigger.SetCustomAccessors((_p_) => { return ((__ButtonPa__)_p_).__bf__AddOneCarrotTrigger__; }, (_p_, _v_) => { ((__ButtonPa__)_p_).__bf__AddOneCarrotTrigger__ = (System.Int64)_v_; }, false);
                AddOneCarrotTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddOneCarrotTrigger() { App = (ButtonPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((ButtonPage)pup).Handle((Input.AddOneCarrotTrigger)input); });
                AddOneCarrotDisabled = Add<__TBool__>("AddOneCarrotDisabled");
                AddOneCarrotDisabled.DefaultValue = false;
                AddOneCarrotDisabled.SetCustomAccessors((_p_) => { return ((__ButtonPa__)_p_).__bf__AddOneCarrotDisabled__; }, (_p_, _v_) => { ((__ButtonPa__)_p_).__bf__AddOneCarrotDisabled__ = (System.Boolean)_v_; }, false);
                TakeOneRegeneratingCarrotTrigger = Add<__TLong__>("TakeOneRegeneratingCarrotTrigger$");
                TakeOneRegeneratingCarrotTrigger.DefaultValue = 0L;
                TakeOneRegeneratingCarrotTrigger.Editable = true;
                TakeOneRegeneratingCarrotTrigger.SetCustomAccessors((_p_) => { return ((__ButtonPa__)_p_).__bf__TakeOneRegeneratingCarrotTrigger__; }, (_p_, _v_) => { ((__ButtonPa__)_p_).__bf__TakeOneRegeneratingCarrotTrigger__ = (System.Int64)_v_; }, false);
                TakeOneRegeneratingCarrotTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.TakeOneRegeneratingCarrotTrigger() { App = (ButtonPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((ButtonPage)pup).Handle((Input.TakeOneRegeneratingCarrotTrigger)input); });
                CarrotsReaction = Add<__TString__>("CarrotsReaction");
                CarrotsReaction.DefaultValue = "You don't have any carrots";
                CarrotsReaction.SetCustomAccessors((_p_) => { return ((__ButtonPa__)_p_).__bf__CarrotsReaction__; }, (_p_, _v_) => { ((__ButtonPa__)_p_).__bf__CarrotsReaction__ = (System.String)_v_; }, false);
                CarrotEngineReaction = Add<__TString__>("CarrotEngineReaction");
                CarrotEngineReaction.DefaultValue = "Carrot engine is off";
                CarrotEngineReaction.SetCustomAccessors((_p_) => { return ((__ButtonPa__)_p_).__bf__CarrotEngineReaction__; }, (_p_, _v_) => { ((__ButtonPa__)_p_).__bf__CarrotEngineReaction__ = (System.String)_v_; }, false);
                OneCarrotReaction = Add<__TString__>("OneCarrotReaction");
                OneCarrotReaction.DefaultValue = "You don't have any carrots";
                OneCarrotReaction.SetCustomAccessors((_p_) => { return ((__ButtonPa__)_p_).__bf__OneCarrotReaction__; }, (_p_, _v_) => { ((__ButtonPa__)_p_).__bf__OneCarrotReaction__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ButtonPa__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ AddCarrotsTrigger;
            public __TBool__ EnableCarrotEngine;
            public __TLong__ AddOneCarrotTrigger;
            public __TBool__ AddOneCarrotDisabled;
            public __TLong__ TakeOneRegeneratingCarrotTrigger;
            public __TString__ CarrotsReaction;
            public __TString__ CarrotEngineReaction;
            public __TString__ OneCarrotReaction;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ButtonPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ButtonPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddCarrotsTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddCarrotsTrigger {
    #line 4 "ButtonPage.json"
        get {
        #line hidden
            return Template.AddCarrotsTrigger.Getter(this); }
        #line 4 "ButtonPage.json"
        set {
        #line hidden
            Template.AddCarrotsTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__EnableCarrotEngine__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean EnableCarrotEngine {
    #line 5 "ButtonPage.json"
        get {
        #line hidden
            return Template.EnableCarrotEngine.Getter(this); }
        #line 5 "ButtonPage.json"
        set {
        #line hidden
            Template.EnableCarrotEngine.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddOneCarrotTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddOneCarrotTrigger {
    #line 6 "ButtonPage.json"
        get {
        #line hidden
            return Template.AddOneCarrotTrigger.Getter(this); }
        #line 6 "ButtonPage.json"
        set {
        #line hidden
            Template.AddOneCarrotTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__AddOneCarrotDisabled__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean AddOneCarrotDisabled {
    #line 7 "ButtonPage.json"
        get {
        #line hidden
            return Template.AddOneCarrotDisabled.Getter(this); }
        #line 7 "ButtonPage.json"
        set {
        #line hidden
            Template.AddOneCarrotDisabled.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TakeOneRegeneratingCarrotTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TakeOneRegeneratingCarrotTrigger {
    #line 9 "ButtonPage.json"
        get {
        #line hidden
            return Template.TakeOneRegeneratingCarrotTrigger.Getter(this); }
        #line 9 "ButtonPage.json"
        set {
        #line hidden
            Template.TakeOneRegeneratingCarrotTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__CarrotsReaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String CarrotsReaction {
    #line 11 "ButtonPage.json"
        get {
        #line hidden
            return Template.CarrotsReaction.Getter(this); }
        #line 11 "ButtonPage.json"
        set {
        #line hidden
            Template.CarrotsReaction.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__CarrotEngineReaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String CarrotEngineReaction {
    #line 12 "ButtonPage.json"
        get {
        #line hidden
            return Template.CarrotEngineReaction.Getter(this); }
        #line 12 "ButtonPage.json"
        set {
        #line hidden
            Template.CarrotEngineReaction.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__OneCarrotReaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String OneCarrotReaction {
    #line 13 "ButtonPage.json"
        get {
        #line hidden
            return Template.OneCarrotReaction.Getter(this); }
        #line 13 "ButtonPage.json"
        set {
        #line hidden
            Template.OneCarrotReaction.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__ButtonPa__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddCarrotsTrigger : Input<__ButtonPa__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class EnableCarrotEngine : Input<__ButtonPa__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class AddOneCarrotTrigger : Input<__ButtonPa__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AddOneCarrotDisabled : Input<__ButtonPa__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class TakeOneRegeneratingCarrotTrigger : Input<__ButtonPa__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class CarrotsReaction : Input<__ButtonPa__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CarrotEngineReaction : Input<__ButtonPa__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class OneCarrotReaction : Input<__ButtonPa__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
