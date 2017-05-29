// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModel\FranchiseDetail\TransactionDetailViewModel.json"
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
using __TrHtml__ = global::Ahsan.TransactionDetailViewModel.Input.Html;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __TrAddress__ = global::Ahsan.TransactionDetailViewModel.Input.Address;
using __TrCommissi__ = global::Ahsan.TransactionDetailViewModel.Input.Commission;
using __TrSalesPri__ = global::Ahsan.TransactionDetailViewModel.Input.SalesPrice;
using __TrDate__ = global::Ahsan.TransactionDetailViewModel.Input.Date;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Transact2__ = global::Ahsan.TransactionDetailViewModel.Input;
using __Transact1__ = global::Ahsan.TransactionDetailViewModel.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __TrSchema__ = global::Ahsan.TransactionDetailViewModel.JsonByExample.Schema;
using __Transact__ = global::Ahsan.TransactionDetailViewModel;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class TransactionDetailViewModel_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class TransactionDetailViewModel : JsonViewModel {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __TrSchema__ DefaultTemplate = new __TrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TransactionDetailViewModel() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TransactionDetailViewModel(__TrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __TrSchema__ Template { get { return (__TrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : JsonViewModel.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__Transact__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Ahsan/FranchiseDetail/TransactionDetailJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Date = Add<__TString__>("Date");
                Date.DefaultValue = "";
                Date.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Date__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Date__ = (System.String)_v_; }, false);
                SalesPrice = Add<__TLong__>("SalesPrice");
                SalesPrice.DefaultValue = 0L;
                SalesPrice.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__SalesPrice__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__SalesPrice__ = (System.Int64)_v_; }, false);
                Commission = Add<__TLong__>("Commission");
                Commission.DefaultValue = 0L;
                Commission.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Commission__ = (System.Int64)_v_; }, false);
                Address = Add<__TString__>("Address");
                Address.DefaultValue = "";
                Address.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Address__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Transact__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Date;
            public __TLong__ SalesPrice;
            public __TLong__ Commission;
            public __TString__ Address;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModel\FranchiseDetail\TransactionDetailViewModel.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModel\FranchiseDetail\TransactionDetailViewModel.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Date__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Date {
    #line 3 "ViewModel\FranchiseDetail\TransactionDetailViewModel.json"
        get {
        #line hidden
            return Template.Date.Getter(this); }
        #line 3 "ViewModel\FranchiseDetail\TransactionDetailViewModel.json"
        set {
        #line hidden
            Template.Date.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SalesPrice__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SalesPrice {
    #line 4 "ViewModel\FranchiseDetail\TransactionDetailViewModel.json"
        get {
        #line hidden
            return Template.SalesPrice.Getter(this); }
        #line 4 "ViewModel\FranchiseDetail\TransactionDetailViewModel.json"
        set {
        #line hidden
            Template.SalesPrice.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Commission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Commission {
    #line 5 "ViewModel\FranchiseDetail\TransactionDetailViewModel.json"
        get {
        #line hidden
            return Template.Commission.Getter(this); }
        #line 5 "ViewModel\FranchiseDetail\TransactionDetailViewModel.json"
        set {
        #line hidden
            Template.Commission.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Address__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Address {
    #line 6 "ViewModel\FranchiseDetail\TransactionDetailViewModel.json"
        get {
        #line hidden
            return Template.Address.Getter(this); }
        #line 6 "ViewModel\FranchiseDetail\TransactionDetailViewModel.json"
        set {
        #line hidden
            Template.Address.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Transact__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Date : Input<__Transact__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SalesPrice : Input<__Transact__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Commission : Input<__Transact__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Address : Input<__Transact__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
