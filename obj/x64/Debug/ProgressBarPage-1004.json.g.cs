// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ProgressBarPage.json"
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
using __Progress2__ = global::KitchenSink.ProgressBarPage.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __PrDownload__ = global::KitchenSink.ProgressBarPage.Input.DownloadButtonText;
using __PrFileDown__ = global::KitchenSink.ProgressBarPage.Input.FileDownloadText;
using __PrTaskIsRu__ = global::KitchenSink.ProgressBarPage.Input.TaskIsRunnning;
using __PrStartPro__ = global::KitchenSink.ProgressBarPage.Input.StartProgressTrigger;
using __PrProgress__ = global::KitchenSink.ProgressBarPage.Input.Progress;
using __PrHtml__ = global::KitchenSink.ProgressBarPage.Input.Html;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TBool__ = global::Starcounter.Templates.TBool;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __PrSchema__ = global::KitchenSink.ProgressBarPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Progress__ = global::KitchenSink.ProgressBarPage;
using __Progress1__ = global::KitchenSink.ProgressBarPage.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ProgressBarPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class ProgressBarPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __PrSchema__ DefaultTemplate = new __PrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ProgressBarPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ProgressBarPage(__PrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __PrSchema__ Template { get { return (__PrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Progress__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/ProgressBarPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Progress__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Progress__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Progress = Add<__TLong__>("Progress");
                Progress.DefaultValue = 0L;
                Progress.SetCustomAccessors((_p_) => { return ((__Progress__)_p_).__bf__Progress__; }, (_p_, _v_) => { ((__Progress__)_p_).__bf__Progress__ = (System.Int64)_v_; }, false);
                StartProgressTrigger = Add<__TLong__>("StartProgressTrigger$");
                StartProgressTrigger.DefaultValue = 0L;
                StartProgressTrigger.Editable = true;
                StartProgressTrigger.SetCustomAccessors((_p_) => { return ((__Progress__)_p_).__bf__StartProgressTrigger__; }, (_p_, _v_) => { ((__Progress__)_p_).__bf__StartProgressTrigger__ = (System.Int64)_v_; }, false);
                StartProgressTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.StartProgressTrigger() { App = (ProgressBarPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((ProgressBarPage)pup).Handle((Input.StartProgressTrigger)input); });
                TaskIsRunnning = Add<__TBool__>("TaskIsRunnning");
                TaskIsRunnning.DefaultValue = false;
                TaskIsRunnning.SetCustomAccessors((_p_) => { return ((__Progress__)_p_).__bf__TaskIsRunnning__; }, (_p_, _v_) => { ((__Progress__)_p_).__bf__TaskIsRunnning__ = (System.Boolean)_v_; }, false);
                FileDownloadText = Add<__TString__>("FileDownloadText");
                FileDownloadText.DefaultValue = "";
                FileDownloadText.SetCustomAccessors((_p_) => { return ((__Progress__)_p_).__bf__FileDownloadText__; }, (_p_, _v_) => { ((__Progress__)_p_).__bf__FileDownloadText__ = (System.String)_v_; }, false);
                DownloadButtonText = Add<__TString__>("DownloadButtonText");
                DownloadButtonText.DefaultValue = "Download (imaginary) file!";
                DownloadButtonText.SetCustomAccessors((_p_) => { return ((__Progress__)_p_).__bf__DownloadButtonText__; }, (_p_, _v_) => { ((__Progress__)_p_).__bf__DownloadButtonText__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Progress__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ Progress;
            public __TLong__ StartProgressTrigger;
            public __TBool__ TaskIsRunnning;
            public __TString__ FileDownloadText;
            public __TString__ DownloadButtonText;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ProgressBarPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ProgressBarPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Progress__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Progress {
    #line 3 "ProgressBarPage.json"
        get {
        #line hidden
            return Template.Progress.Getter(this); }
        #line 3 "ProgressBarPage.json"
        set {
        #line hidden
            Template.Progress.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__StartProgressTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 StartProgressTrigger {
    #line 5 "ProgressBarPage.json"
        get {
        #line hidden
            return Template.StartProgressTrigger.Getter(this); }
        #line 5 "ProgressBarPage.json"
        set {
        #line hidden
            Template.StartProgressTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__TaskIsRunnning__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean TaskIsRunnning {
    #line 7 "ProgressBarPage.json"
        get {
        #line hidden
            return Template.TaskIsRunnning.Getter(this); }
        #line 7 "ProgressBarPage.json"
        set {
        #line hidden
            Template.TaskIsRunnning.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FileDownloadText__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FileDownloadText {
    #line 9 "ProgressBarPage.json"
        get {
        #line hidden
            return Template.FileDownloadText.Getter(this); }
        #line 9 "ProgressBarPage.json"
        set {
        #line hidden
            Template.FileDownloadText.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__DownloadButtonText__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String DownloadButtonText {
    #line 10 "ProgressBarPage.json"
        get {
        #line hidden
            return Template.DownloadButtonText.Getter(this); }
        #line 10 "ProgressBarPage.json"
        set {
        #line hidden
            Template.DownloadButtonText.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Progress__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Progress : Input<__Progress__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class StartProgressTrigger : Input<__Progress__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TaskIsRunnning : Input<__Progress__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class FileDownloadText : Input<__Progress__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class DownloadButtonText : Input<__Progress__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
