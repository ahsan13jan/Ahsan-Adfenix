// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModel\Corporation\MainViewModel.json"
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

namespace Ahsan {
using __MainView1__ = global::Ahsan.MainViewModel.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __MaCreateCo__ = global::Ahsan.MainViewModel.Input.CreateCorporation;
using __MaCoporati__ = global::Ahsan.MainViewModel.Input.CoporationNameToAdd;
using __MaHtml__ = global::Ahsan.MainViewModel.Input.Html;
using __MainView2__ = global::Ahsan.MainViewModel.Input;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __MaSchema__ = global::Ahsan.MainViewModel.JsonByExample.Schema;
using __MainView__ = global::Ahsan.MainViewModel;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class MainViewModel_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class MainViewModel : JsonViewModel {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __MaSchema__ DefaultTemplate = new __MaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MainViewModel() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MainViewModel(__MaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __MaSchema__ Template { get { return (__MaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : JsonViewModel.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__MainView__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Ahsan/Corporation/MainViewJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__MainView__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__MainView__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                CoporationNameToAdd = Add<__TString__>("CoporationNameToAdd$", bind:"CoporationNameToAdd");
                CoporationNameToAdd.DefaultValue = "";
                CoporationNameToAdd.Editable = true;
                CoporationNameToAdd.SetCustomAccessors((_p_) => { return ((__MainView__)_p_).__bf__CoporationNameToAdd__; }, (_p_, _v_) => { ((__MainView__)_p_).__bf__CoporationNameToAdd__ = (System.String)_v_; }, false);
                CreateCorporation = Add<__TLong__>("CreateCorporation$");
                CreateCorporation.DefaultValue = 0L;
                CreateCorporation.Editable = true;
                CreateCorporation.SetCustomAccessors((_p_) => { return ((__MainView__)_p_).__bf__CreateCorporation__; }, (_p_, _v_) => { ((__MainView__)_p_).__bf__CreateCorporation__ = (System.Int64)_v_; }, false);
                CreateCorporation.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.CreateCorporation() { App = (MainViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((MainViewModel)pup).Handle((Input.CreateCorporation)input); });
                CorporationList = Add<__TArray__>("CorporationList");
                CorporationList.SetCustomAccessors((_p_) => { return ((__MainView__)_p_).__bf__CorporationList__; }, (_p_, _v_) => { ((__MainView__)_p_).__bf__CorporationList__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __MainView__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ CoporationNameToAdd;
            public __TLong__ CreateCorporation;
            public __TArray__ CorporationList;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModel\Corporation\MainViewModel.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModel\Corporation\MainViewModel.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__CoporationNameToAdd__;
    #line default
    #line hidden
    private System.Int64 __bf__CreateCorporation__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CreateCorporation {
    #line 4 "ViewModel\Corporation\MainViewModel.json"
        get {
        #line hidden
            return Template.CreateCorporation.Getter(this); }
        #line 4 "ViewModel\Corporation\MainViewModel.json"
        set {
        #line hidden
            Template.CreateCorporation.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__CorporationList__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ CorporationList {
    #line 5 "ViewModel\Corporation\MainViewModel.json"
        get {
        #line hidden
            return Template.CorporationList.Getter(this); }
        #line 5 "ViewModel\Corporation\MainViewModel.json"
        set {
        #line hidden
            Template.CorporationList.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__MainView__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CoporationNameToAdd : Input<__MainView__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CreateCorporation : Input<__MainView__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
