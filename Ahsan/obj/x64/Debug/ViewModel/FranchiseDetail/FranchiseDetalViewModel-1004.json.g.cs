// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
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
using __FfrAddress__ = global::Ahsan.FranchiseDetalViewModel.franchiseJson.Input.Address;
using __Frtransact2__ = global::Ahsan.FranchiseDetalViewModel.transactionJson.Input;
using __FtrCity__ = global::Ahsan.FranchiseDetalViewModel.transactionJson.Input.City;
using __FtrCountry__ = global::Ahsan.FranchiseDetalViewModel.transactionJson.Input.Country;
using __FtrName__ = global::Ahsan.FranchiseDetalViewModel.transactionJson.Input.Name;
using __FtrNumber__ = global::Ahsan.FranchiseDetalViewModel.transactionJson.Input.Number;
using __FtrStreet__ = global::Ahsan.FranchiseDetalViewModel.transactionJson.Input.Street;
using __FtrZipCode__ = global::Ahsan.FranchiseDetalViewModel.transactionJson.Input.ZipCode;
using __FtrDate__ = global::Ahsan.FranchiseDetalViewModel.transactionJson.Input.Date;
using __FtrSalesPri__ = global::Ahsan.FranchiseDetalViewModel.transactionJson.Input.SalesPrice;
using __FtrCommissi__ = global::Ahsan.FranchiseDetalViewModel.transactionJson.Input.Commission;
using __FtrAddress__ = global::Ahsan.FranchiseDetalViewModel.transactionJson.Input.Address;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __Franchis2__ = global::Ahsan.FranchiseDetalViewModel.Input;
using __FrHtml__ = global::Ahsan.FranchiseDetalViewModel.Input.Html;
using __FrSaveFran__ = global::Ahsan.FranchiseDetalViewModel.Input.SaveFranchise;
using __FrSaveTran__ = global::Ahsan.FranchiseDetalViewModel.Input.SaveTransaction;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __Frtransact1__ = global::Ahsan.FranchiseDetalViewModel.transactionJson.JsonByExample;
using __Frtransact__ = global::Ahsan.FranchiseDetalViewModel.transactionJson;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __FfrZipCode__ = global::Ahsan.FranchiseDetalViewModel.franchiseJson.Input.ZipCode;
using __Franchis__ = global::Ahsan.FranchiseDetalViewModel;
using __FrSchema__ = global::Ahsan.FranchiseDetalViewModel.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __FfrSchema__ = global::Ahsan.FranchiseDetalViewModel.franchiseJson.JsonByExample.Schema;
using __TObject__ = global::Starcounter.Templates.TObject;
using __FtrSchema__ = global::Ahsan.FranchiseDetalViewModel.transactionJson.JsonByExample.Schema;
using __TLong__ = global::Starcounter.Templates.TLong;
using __Json__ = global::Starcounter.Json;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __Franchis1__ = global::Ahsan.FranchiseDetalViewModel.JsonByExample;
using __Frfranchis__ = global::Ahsan.FranchiseDetalViewModel.franchiseJson;
using __Frfranchis1__ = global::Ahsan.FranchiseDetalViewModel.franchiseJson.JsonByExample;
using __Frfranchis2__ = global::Ahsan.FranchiseDetalViewModel.franchiseJson.Input;
using __FfrCity__ = global::Ahsan.FranchiseDetalViewModel.franchiseJson.Input.City;
using __FfrCountry__ = global::Ahsan.FranchiseDetalViewModel.franchiseJson.Input.Country;
using __FfrName__ = global::Ahsan.FranchiseDetalViewModel.franchiseJson.Input.Name;
using __FfrNumber__ = global::Ahsan.FranchiseDetalViewModel.franchiseJson.Input.Number;
using __FfrStreet__ = global::Ahsan.FranchiseDetalViewModel.franchiseJson.Input.Street;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseDetalViewModel_json : s::TemplateAttribute {
    
    #line hidden
    public class franchise : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class transaction : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class FranchiseDetalViewModel : JsonViewModel {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetalViewModel() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetalViewModel(__FrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FrSchema__ Template { get { return (__FrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : JsonViewModel.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__Franchis__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Ahsan/FranchiseDetail/FranchiseDetailJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                franchise = Add<__FfrSchema__>("franchise", bind:"franchise");
                franchise.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__franchise__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__franchise__ = (__Frfranchis__)_v_; }, false);
                transaction = Add<__FtrSchema__>("transaction", bind:"transaction");
                transaction.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__transaction__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__transaction__ = (__Frtransact__)_v_; }, false);
                TransactionList = Add<__TArray__>("TransactionList");
                TransactionList.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TransactionList__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TransactionList__ = (__Arr__)_v_; }, false);
                SaveFranchise = Add<__TLong__>("SaveFranchise$");
                SaveFranchise.DefaultValue = 0L;
                SaveFranchise.Editable = true;
                SaveFranchise.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SaveFranchise__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SaveFranchise__ = (System.Int64)_v_; }, false);
                SaveFranchise.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveFranchise() { App = (FranchiseDetalViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseDetalViewModel)pup).Handle((Input.SaveFranchise)input); });
                SaveTransaction = Add<__TLong__>("SaveTransaction$");
                SaveTransaction.DefaultValue = 0L;
                SaveTransaction.Editable = true;
                SaveTransaction.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SaveTransaction__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SaveTransaction__ = (System.Int64)_v_; }, false);
                SaveTransaction.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveTransaction() { App = (FranchiseDetalViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseDetalViewModel)pup).Handle((Input.SaveTransaction)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __FfrSchema__ franchise;
            public __FtrSchema__ transaction;
            public __TArray__ TransactionList;
            public __TLong__ SaveFranchise;
            public __TLong__ SaveTransaction;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Frfranchis__ __bf__franchise__;
    #line default
    #line hidden
    private __Frtransact__ __bf__transaction__;
    #line default
    #line hidden
    private __Arr__ __bf__TransactionList__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ TransactionList {
    #line 25 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
        get {
        #line hidden
            return Template.TransactionList.Getter(this); }
        #line 25 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
        set {
        #line hidden
            Template.TransactionList.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveFranchise__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveFranchise {
    #line 26 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
        get {
        #line hidden
            return Template.SaveFranchise.Getter(this); }
        #line 26 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
        set {
        #line hidden
            Template.SaveFranchise.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveTransaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveTransaction {
    #line 27 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
        get {
        #line hidden
            return Template.SaveTransaction.Getter(this); }
        #line 27 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
        set {
        #line hidden
            Template.SaveTransaction.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class franchiseJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FfrSchema__ DefaultTemplate = new __FfrSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public franchiseJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public franchiseJson(__FfrSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FfrSchema__ Template { get { return (__FfrSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__Frfranchis__);
                    Properties.ClearExposed();
                    City = Add<__TString__>("City$");
                    City.DefaultValue = "";
                    City.Editable = true;
                    City.SetCustomAccessors((_p_) => { return ((__Frfranchis__)_p_).__bf__City__; }, (_p_, _v_) => { ((__Frfranchis__)_p_).__bf__City__ = (System.String)_v_; }, false);
                    Country = Add<__TString__>("Country$");
                    Country.DefaultValue = "";
                    Country.Editable = true;
                    Country.SetCustomAccessors((_p_) => { return ((__Frfranchis__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__Frfranchis__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__Frfranchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Frfranchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Number = Add<__TString__>("Number$");
                    Number.DefaultValue = "";
                    Number.Editable = true;
                    Number.SetCustomAccessors((_p_) => { return ((__Frfranchis__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__Frfranchis__)_p_).__bf__Number__ = (System.String)_v_; }, false);
                    Street = Add<__TString__>("Street$");
                    Street.DefaultValue = "";
                    Street.Editable = true;
                    Street.SetCustomAccessors((_p_) => { return ((__Frfranchis__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__Frfranchis__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                    ZipCode = Add<__TString__>("ZipCode$");
                    ZipCode.DefaultValue = "";
                    ZipCode.Editable = true;
                    ZipCode.SetCustomAccessors((_p_) => { return ((__Frfranchis__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__Frfranchis__)_p_).__bf__ZipCode__ = (System.String)_v_; }, false);
                    Address = Add<__TString__>("Address");
                    Address.DefaultValue = "";
                    Address.SetCustomAccessors((_p_) => { return ((__Frfranchis__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__Frfranchis__)_p_).__bf__Address__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __Frfranchis__(this) { Parent = parent }; }
                public __TString__ City;
                public __TString__ Country;
                public __TString__ Name;
                public __TString__ Number;
                public __TString__ Street;
                public __TString__ ZipCode;
                public __TString__ Address;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__City__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String City {
        #line 4 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.City.Getter(this); }
            #line 4 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.City.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Country__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Country {
        #line 5 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.Country.Getter(this); }
            #line 5 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.Country.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 6 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 6 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Number__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Number {
        #line 7 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.Number.Getter(this); }
            #line 7 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.Number.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Street__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Street {
        #line 8 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.Street.Getter(this); }
            #line 8 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.Street.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__ZipCode__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ZipCode {
        #line 9 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.ZipCode.Getter(this); }
            #line 9 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.ZipCode.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Address__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Address {
        #line 10 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.Address.Getter(this); }
            #line 10 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.Address.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class City : Input<__Frfranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Country : Input<__Frfranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__Frfranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Number : Input<__Frfranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Street : Input<__Frfranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ZipCode : Input<__Frfranchis__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Address : Input<__Frfranchis__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class transactionJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FtrSchema__ DefaultTemplate = new __FtrSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public transactionJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public transactionJson(__FtrSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FtrSchema__ Template { get { return (__FtrSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__Frtransact__);
                    Properties.ClearExposed();
                    City = Add<__TString__>("City$");
                    City.DefaultValue = "";
                    City.Editable = true;
                    City.SetCustomAccessors((_p_) => { return ((__Frtransact__)_p_).__bf__City__; }, (_p_, _v_) => { ((__Frtransact__)_p_).__bf__City__ = (System.String)_v_; }, false);
                    Country = Add<__TString__>("Country$");
                    Country.DefaultValue = "";
                    Country.Editable = true;
                    Country.SetCustomAccessors((_p_) => { return ((__Frtransact__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__Frtransact__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__Frtransact__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Frtransact__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Number = Add<__TString__>("Number$");
                    Number.DefaultValue = "";
                    Number.Editable = true;
                    Number.SetCustomAccessors((_p_) => { return ((__Frtransact__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__Frtransact__)_p_).__bf__Number__ = (System.String)_v_; }, false);
                    Street = Add<__TString__>("Street$");
                    Street.DefaultValue = "";
                    Street.Editable = true;
                    Street.SetCustomAccessors((_p_) => { return ((__Frtransact__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__Frtransact__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                    ZipCode = Add<__TString__>("ZipCode$");
                    ZipCode.DefaultValue = "";
                    ZipCode.Editable = true;
                    ZipCode.SetCustomAccessors((_p_) => { return ((__Frtransact__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__Frtransact__)_p_).__bf__ZipCode__ = (System.String)_v_; }, false);
                    Date = Add<__TString__>("Date$");
                    Date.DefaultValue = "";
                    Date.Editable = true;
                    Date.SetCustomAccessors((_p_) => { return ((__Frtransact__)_p_).__bf__Date__; }, (_p_, _v_) => { ((__Frtransact__)_p_).__bf__Date__ = (System.String)_v_; }, false);
                    SalesPrice = Add<__TLong__>("SalesPrice$");
                    SalesPrice.DefaultValue = 0L;
                    SalesPrice.Editable = true;
                    SalesPrice.SetCustomAccessors((_p_) => { return ((__Frtransact__)_p_).__bf__SalesPrice__; }, (_p_, _v_) => { ((__Frtransact__)_p_).__bf__SalesPrice__ = (System.Int64)_v_; }, false);
                    Commission = Add<__TLong__>("Commission$");
                    Commission.DefaultValue = 0L;
                    Commission.Editable = true;
                    Commission.SetCustomAccessors((_p_) => { return ((__Frtransact__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__Frtransact__)_p_).__bf__Commission__ = (System.Int64)_v_; }, false);
                    Address = Add<__TString__>("Address");
                    Address.DefaultValue = "";
                    Address.SetCustomAccessors((_p_) => { return ((__Frtransact__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__Frtransact__)_p_).__bf__Address__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __Frtransact__(this) { Parent = parent }; }
                public __TString__ City;
                public __TString__ Country;
                public __TString__ Name;
                public __TString__ Number;
                public __TString__ Street;
                public __TString__ ZipCode;
                public __TString__ Date;
                public __TLong__ SalesPrice;
                public __TLong__ Commission;
                public __TString__ Address;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__City__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String City {
        #line 14 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.City.Getter(this); }
            #line 14 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.City.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Country__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Country {
        #line 15 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.Country.Getter(this); }
            #line 15 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.Country.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 16 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 16 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Number__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Number {
        #line 17 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.Number.Getter(this); }
            #line 17 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.Number.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Street__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Street {
        #line 18 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.Street.Getter(this); }
            #line 18 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.Street.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__ZipCode__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ZipCode {
        #line 19 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.ZipCode.Getter(this); }
            #line 19 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.ZipCode.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Date__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Date {
        #line 20 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.Date.Getter(this); }
            #line 20 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.Date.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__SalesPrice__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SalesPrice {
        #line 21 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.SalesPrice.Getter(this); }
            #line 21 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.SalesPrice.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__Commission__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 Commission {
        #line 22 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.Commission.Getter(this); }
            #line 22 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.Commission.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Address__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Address {
        #line 23 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            get {
            #line hidden
                return Template.Address.Getter(this); }
            #line 23 "ViewModel\FranchiseDetail\FranchiseDetalViewModel.json"
            set {
            #line hidden
                Template.Address.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class City : Input<__Frtransact__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Country : Input<__Frtransact__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__Frtransact__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Number : Input<__Frtransact__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Street : Input<__Frtransact__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ZipCode : Input<__Frtransact__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Date : Input<__Frtransact__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class SalesPrice : Input<__Frtransact__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Commission : Input<__Frtransact__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Address : Input<__Frtransact__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveFranchise : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SaveTransaction : Input<__Franchis__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
