// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModel\Corporation\CorporationViewModel.json"
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
using __Corporat2__ = global::Ahsan.CorporationViewModel.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoSortOnTr__ = global::Ahsan.CorporationViewModel.Input.SortOnTrend;
using __CoSortOnAv__ = global::Ahsan.CorporationViewModel.Input.SortOnAverageComission;
using __CoSortOnTo__ = global::Ahsan.CorporationViewModel.Input.SortOnTotalComission;
using __CoSortOnNu__ = global::Ahsan.CorporationViewModel.Input.SortOnNumberOfHomes;
using __CoAddFranc__ = global::Ahsan.CorporationViewModel.Input.AddFranchise;
using __CoFranchis__ = global::Ahsan.CorporationViewModel.Input.FranchiseNameToAdd;
using __CoName__ = global::Ahsan.CorporationViewModel.Input.Name;
using __CoHtml__ = global::Ahsan.CorporationViewModel.Input.Html;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __Corporat1__ = global::Ahsan.CorporationViewModel.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::Ahsan.CorporationViewModel.JsonByExample.Schema;
using __Corporat__ = global::Ahsan.CorporationViewModel;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CorporationViewModel_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class CorporationViewModel : JsonViewModel {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationViewModel() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationViewModel(__CoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema__ Template { get { return (__CoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : JsonViewModel.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__Corporat__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Ahsan/Corporation/CorporationJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                FranchiseNameToAdd = Add<__TString__>("FranchiseNameToAdd$", bind:"FranchiseNameToAdd");
                FranchiseNameToAdd.DefaultValue = "";
                FranchiseNameToAdd.Editable = true;
                FranchiseNameToAdd.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__FranchiseNameToAdd__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__FranchiseNameToAdd__ = (System.String)_v_; }, false);
                AddFranchise = Add<__TLong__>("AddFranchise$");
                AddFranchise.DefaultValue = 0L;
                AddFranchise.Editable = true;
                AddFranchise.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__AddFranchise__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__AddFranchise__ = (System.Int64)_v_; }, false);
                AddFranchise.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddFranchise() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.AddFranchise)input); });
                SortOnNumberOfHomes = Add<__TLong__>("SortOnNumberOfHomes$");
                SortOnNumberOfHomes.DefaultValue = 0L;
                SortOnNumberOfHomes.Editable = true;
                SortOnNumberOfHomes.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SortOnNumberOfHomes__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SortOnNumberOfHomes__ = (System.Int64)_v_; }, false);
                SortOnNumberOfHomes.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortOnNumberOfHomes() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.SortOnNumberOfHomes)input); });
                SortOnTotalComission = Add<__TLong__>("SortOnTotalComission$");
                SortOnTotalComission.DefaultValue = 0L;
                SortOnTotalComission.Editable = true;
                SortOnTotalComission.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SortOnTotalComission__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SortOnTotalComission__ = (System.Int64)_v_; }, false);
                SortOnTotalComission.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortOnTotalComission() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.SortOnTotalComission)input); });
                SortOnAverageComission = Add<__TLong__>("SortOnAverageComission$");
                SortOnAverageComission.DefaultValue = 0L;
                SortOnAverageComission.Editable = true;
                SortOnAverageComission.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SortOnAverageComission__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SortOnAverageComission__ = (System.Int64)_v_; }, false);
                SortOnAverageComission.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortOnAverageComission() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.SortOnAverageComission)input); });
                SortOnTrend = Add<__TLong__>("SortOnTrend$");
                SortOnTrend.DefaultValue = 0L;
                SortOnTrend.Editable = true;
                SortOnTrend.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SortOnTrend__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SortOnTrend__ = (System.Int64)_v_; }, false);
                SortOnTrend.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortOnTrend() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.SortOnTrend)input); });
                FranchiseList = Add<__TArray__>("FranchiseList");
                FranchiseList.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__FranchiseList__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__FranchiseList__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TString__ FranchiseNameToAdd;
            public __TLong__ AddFranchise;
            public __TLong__ SortOnNumberOfHomes;
            public __TLong__ SortOnTotalComission;
            public __TLong__ SortOnAverageComission;
            public __TLong__ SortOnTrend;
            public __TArray__ FranchiseList;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModel\Corporation\CorporationViewModel.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModel\Corporation\CorporationViewModel.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "ViewModel\Corporation\CorporationViewModel.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "ViewModel\Corporation\CorporationViewModel.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FranchiseNameToAdd__;
    #line default
    #line hidden
    private System.Int64 __bf__AddFranchise__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddFranchise {
    #line 5 "ViewModel\Corporation\CorporationViewModel.json"
        get {
        #line hidden
            return Template.AddFranchise.Getter(this); }
        #line 5 "ViewModel\Corporation\CorporationViewModel.json"
        set {
        #line hidden
            Template.AddFranchise.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortOnNumberOfHomes__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortOnNumberOfHomes {
    #line 6 "ViewModel\Corporation\CorporationViewModel.json"
        get {
        #line hidden
            return Template.SortOnNumberOfHomes.Getter(this); }
        #line 6 "ViewModel\Corporation\CorporationViewModel.json"
        set {
        #line hidden
            Template.SortOnNumberOfHomes.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortOnTotalComission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortOnTotalComission {
    #line 7 "ViewModel\Corporation\CorporationViewModel.json"
        get {
        #line hidden
            return Template.SortOnTotalComission.Getter(this); }
        #line 7 "ViewModel\Corporation\CorporationViewModel.json"
        set {
        #line hidden
            Template.SortOnTotalComission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortOnAverageComission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortOnAverageComission {
    #line 8 "ViewModel\Corporation\CorporationViewModel.json"
        get {
        #line hidden
            return Template.SortOnAverageComission.Getter(this); }
        #line 8 "ViewModel\Corporation\CorporationViewModel.json"
        set {
        #line hidden
            Template.SortOnAverageComission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortOnTrend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortOnTrend {
    #line 9 "ViewModel\Corporation\CorporationViewModel.json"
        get {
        #line hidden
            return Template.SortOnTrend.Getter(this); }
        #line 9 "ViewModel\Corporation\CorporationViewModel.json"
        set {
        #line hidden
            Template.SortOnTrend.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__FranchiseList__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ FranchiseList {
    #line 10 "ViewModel\Corporation\CorporationViewModel.json"
        get {
        #line hidden
            return Template.FranchiseList.Getter(this); }
        #line 10 "ViewModel\Corporation\CorporationViewModel.json"
        set {
        #line hidden
            Template.FranchiseList.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FranchiseNameToAdd : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddFranchise : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortOnNumberOfHomes : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortOnTotalComission : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortOnAverageComission : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortOnTrend : Input<__Corporat__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
